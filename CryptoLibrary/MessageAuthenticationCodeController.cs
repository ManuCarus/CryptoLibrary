/*
   CryptoLibrary - implements safe cryptographic algorithms and encapsulates classes for easy use.
   Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de)

   This library exposes security functionality to the programmer, such as random number generation, hashing, 
   salted hashing, message authentication code, symmetric encryption, asymmetric encryption, hybrid encryption, 
   digital signature and in-memory protection. The library is accompanied by a sophisticated reference implementation, 
   that demonstrates how to make use of the CryptoLibrary.

   This program is free software; you can redistribute it and/or modify it under the terms of 
   the GNU General Public License as published by the Free Software Foundation; 
   either version 3 of the License, or (at your option) any later version.

   This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
   without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
   See the GNU General Public License for more details.

   You should have received a copy of the GNU General Public License along with this program; 
   if not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoLibrary.Controller
{
    public class MessageAuthenticationCodeController
    {
        // cryptographic algorithms
        public static string cMacTripleDes = "MACTripleDES";
        public static string[] cMacAlgorithms = new string[] { "HMACSHA256", "HMACSHA384", "HMACSHA512", "HMACRIPEMD160", cMacTripleDes };

        // private members
        private KeyedHashAlgorithm macAlgorithm = null;
        private Encoding encoding = null;

        // public properties
        public bool IsKnownAlgorithm
        {
            get { return (macAlgorithm != null); }
        }

        // ctor
        public MessageAuthenticationCodeController(string algorithmName, string encodingName)
        {
            macAlgorithm = KeyedHashAlgorithm.Create(algorithmName);
            encoding = EncodingController.GetEncodingByName(encodingName);
        }

        // hashing
        public byte[] Hash(string message, string passphrase)
        {
            if (macAlgorithm == null) throw new Exception("mac algorithm not set!");
            if (encoding == null) throw new Exception("encoding not set!");

            byte[] data = encoding.GetBytes(message);
            byte[] key = encoding.GetBytes(passphrase);

            macAlgorithm.Key = key;

            byte[] digest = macAlgorithm.ComputeHash(data);
            return digest;
        }

        public byte[] Hash(Stream stream, string passphrase)
        {
            if (macAlgorithm == null) throw new Exception("mac algorithm not set!");
            if (encoding == null) throw new Exception("encoding not set!");

            byte[] key = encoding.GetBytes(passphrase);

            macAlgorithm.Key = key;

            byte[] digest = macAlgorithm.ComputeHash(stream);
            return digest;
        }

        public bool Authenticate(string message, string passphrase, byte[] givenMac)
        {
            byte[] computedMac = Hash(message, passphrase);
            return Compare(computedMac, givenMac);
        }

        public bool Authenticate(Stream stream, string passphrase, byte[] givenMac)
        {
            byte[] computedMac = Hash(stream, passphrase);
            return Compare(computedMac, givenMac);
        }

        private bool Compare(byte[] computedMac, byte[] givenMac)
        {
            if (computedMac.Length != givenMac.Length) return false;
            for (int i = 0; i < computedMac.Length; i++) if (computedMac[i] != givenMac[i]) return false;
            return true;
        }

    }
}
