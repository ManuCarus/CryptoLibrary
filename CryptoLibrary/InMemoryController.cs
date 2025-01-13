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
using System.Security.Cryptography;
using System.Text;

namespace CryptoLibrary.Controller
{
    public class InMemoryController
    {
        // cryptographic algorithms
        public static string cProtectedMemory = "ProtectedMemory";
        public static string cProtectedData = "ProtectedData";
        public static string[] cInMemoryAlgorithms = new string[] { cProtectedMemory, cProtectedData };
        private static int cEntropyBytes = 256;

        private abstract class InMemoryAlgorithm
        {
            internal static InMemoryAlgorithm Create(string algorithmName)
            {
                if (algorithmName.Equals(cProtectedMemory)) return new ProtectedMemoryAlgorithm();
                else if (algorithmName.Equals(cProtectedData)) return new ProtectedDataAlgorithm();
                else return null;
            }

            protected byte[] entropy = null;

            internal InMemoryAlgorithm()
            {
                this.entropy = RandomNumberController.GenerateBytes(cEntropyBytes);
            }

            internal abstract byte[] Protect(byte[] data, string scope);
            internal abstract byte[] Unprotect(byte[] protectedData, string scope);
        }

        private class ProtectedMemoryAlgorithm : InMemoryAlgorithm
        {
            internal override byte[] Protect(byte[] data, string scopeName)
            {
                MemoryProtectionScope scope = (MemoryProtectionScope)Enum.Parse(typeof(MemoryProtectionScope), scopeName);
                ProtectedMemory.Protect(data, scope);
                return data;
            }

            internal override byte[] Unprotect(byte[] data, string scopeName)
            {
                MemoryProtectionScope scope = (MemoryProtectionScope)Enum.Parse(typeof(MemoryProtectionScope), scopeName);
                ProtectedMemory.Unprotect(data, scope);
                return data;
            }
        }

        private class ProtectedDataAlgorithm : InMemoryAlgorithm
        {
            internal override byte[] Protect(byte[] data, string scopeName)
            {
                DataProtectionScope scope = (DataProtectionScope)Enum.Parse(typeof(DataProtectionScope), scopeName);

                byte[] protectedData = ProtectedData.Protect(data, entropy, scope);
                return protectedData;
            }

            internal override byte[] Unprotect(byte[] data, string scopeName)
            {
                DataProtectionScope scope = (DataProtectionScope)Enum.Parse(typeof(DataProtectionScope), scopeName);
                
                byte[] unprotectedData = ProtectedData.Unprotect(data, entropy, scope);
                return unprotectedData;
            }
        }

        // private members
        private InMemoryAlgorithm inMemoryAlgorithm = null;
        private string algorithmName;

        // ctor
        public InMemoryController(string algorithmName)
        {
            this.algorithmName = algorithmName;
            inMemoryAlgorithm = InMemoryAlgorithm.Create(algorithmName);
        }

        // public properties
        public string Algorithm
        {
            get { return algorithmName; }
        }

        public bool IsKnownAlgorithm
        {
            get { return (inMemoryAlgorithm != null); }
        }

        public byte[] Protect(string scopeName, string encodingName, string data, out byte[] rawData)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (inMemoryAlgorithm == null) throw new Exception("invalid protection algorithm");

            // protection
            rawData = encoding.GetBytes(data);
            
            byte[] dataToBeProtected = (byte[])rawData.Clone();
            byte[] protectedData = inMemoryAlgorithm.Protect(dataToBeProtected, scopeName);

            return protectedData;
        }

        public string Unprotect(string scopeName, string encodingName, byte[] data)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (inMemoryAlgorithm == null) throw new Exception("invalid protection algorithm");

            // protection
            byte[] unprotectedData = inMemoryAlgorithm.Unprotect(data, scopeName);

            string unprotectedText = encoding.GetString(unprotectedData);
            return unprotectedText;
        }

    
    }
}
