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
    public class SaltedHashController
    {
        // cryptographic algorithms
        public static string[] cHashAlgorithms = HashController.cHashAlgorithms;
        private static int cSaltLength = 8; // bytes

        // private members
        private HashAlgorithm hashAlgorithm = null;
        private Encoding encoding = null;

        // public properties
        public bool IsKnownAlgorithm
        {
            get { return (hashAlgorithm != null); }
        }

        // ctor
        public SaltedHashController(string algorithmName)
        {
            hashAlgorithm = HashAlgorithm.Create(algorithmName);
        }

        public SaltedHashController(string algorithmName, string encodingName) : this(algorithmName)
        {
            encoding = EncodingController.GetEncodingByName(encodingName);
        }

        // hashing
        public byte[] Hash(string message, out byte[] unsaltedHash, out byte[] salt, out byte[] saltedHash)
        {
            if (hashAlgorithm == null) throw new Exception("hash algorithm not set!");
            if (encoding == null) throw new Exception("encoding not set!");

            byte[] data = encoding.GetBytes(message);
            unsaltedHash = hashAlgorithm.ComputeHash(data);

            byte[] saltedHashAndSalt = SaltHash(unsaltedHash, out salt, out saltedHash);
            return saltedHashAndSalt;
        }

        public byte[] Hash(Stream stream, out byte[] unsaltedHash, out byte[] salt, out byte[] saltedHash)
        {
            if (hashAlgorithm == null) throw new Exception("hash algorithm not set!");

            unsaltedHash = hashAlgorithm.ComputeHash(stream);

            byte[] saltedHashAndSalt = SaltHash(unsaltedHash, out salt, out saltedHash);
            return saltedHashAndSalt;
        }

        // helper
        private byte[] SaltHash(byte[] unsaltedHash, out byte[] salt, out byte[] saltedHash)
        {
            salt = GetRandomSalt();

            byte[] unsaltedHashAndSalt = new byte[unsaltedHash.Length + salt.Length];
            unsaltedHash.CopyTo(unsaltedHashAndSalt, 0);
            salt.CopyTo(unsaltedHashAndSalt, unsaltedHash.Length);

            saltedHash = hashAlgorithm.ComputeHash(unsaltedHashAndSalt);

            byte[] saltedHashAndSalt = new byte[saltedHash.Length + salt.Length];
            saltedHash.CopyTo(saltedHashAndSalt, 0);
            salt.CopyTo(saltedHashAndSalt, saltedHash.Length);

            return saltedHashAndSalt;
        }

        private byte[] GetRandomSalt()
        {
            byte[] salt = RandomNumberController.GenerateBytes(cSaltLength);
            return salt;
        }

    }
}
