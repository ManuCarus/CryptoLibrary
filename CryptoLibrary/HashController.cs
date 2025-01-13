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
    public class HashController
    {
        // cryptographic algorithms
        public static string[] cHashAlgorithms = new string[] { "SHA256", "SHA384", "SHA512", "RIPEMD160" };

        // private members
        private HashAlgorithm hashAlgorithm = null;
        private Encoding encoding = null;

        // public properties
        public bool IsKnownAlgorithm
        {
            get { return (hashAlgorithm != null); }
        }

        // ctor
        public HashController(string algorithmName)
        {
            hashAlgorithm = HashAlgorithm.Create(algorithmName);
        }

        public HashController(string algorithmName, string encodingName) : this(algorithmName)
        {
            encoding = EncodingController.GetEncodingByName(encodingName);
        }

        // hashing
        public byte[] Hash(string data)
        {
            if (hashAlgorithm == null) throw new Exception("hash algorithm not set!");
            if (encoding == null) throw new Exception("encoding not set!");

            byte[] rawData = encoding.GetBytes(data);
            byte[] digest = hashAlgorithm.ComputeHash(rawData);

            return digest;
        }

        public byte[] Hash(Stream stream)
        {
            if (hashAlgorithm == null) throw new Exception("hash algorithm not set!");

            byte[] digest = hashAlgorithm.ComputeHash(stream);
            return digest;
        }
    }
}
