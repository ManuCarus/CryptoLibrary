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
    public class AsymmetricController
    {
        // cryptographic algorithms
        public static string cRsa = "RSA";
        public static string[] cAsymmetricAlgorithms = new string[] { cRsa };
        public static string cDefaultAsymmetricAlgorithm = cRsa;

        // default key sizes
        public static int cRsaKeySizeBits = 1024;

        // padding modes
        public static string[] cPaddingModes = new string[] { "OAEP padding (PKCS#1 v2)", "Direct Encryption (PKCS#1 v1.5)" };
        public static string cPaddingModeOAEP = "OAEP padding (PKCS#1 v2)";

        // private members
        private AsymmetricAlgorithm asymmetricAlgorithm = null;
        private string algorithmName;
        private int keySize; // bits

        // ctor
        public AsymmetricController(string algorithmName)
        {
            this.algorithmName = algorithmName;
            this.keySize = DefaultKeySize;
            CreateAsymmetricAlgorithm(algorithmName, DefaultKeySize);
        }

        // public properties
        public string Algorithm
        {
            get { return algorithmName; }
        }

        public bool IsKnownAlgorithm
        {
            get { return ( asymmetricAlgorithm != null); }
        }

        public string KeyExchangeAlgorithm
        {
            get
            {
                if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
                return asymmetricAlgorithm.KeyExchangeAlgorithm;
            }
        }

        public string SignatureAlgorithm
        {
            get
            {
                if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
                return asymmetricAlgorithm.SignatureAlgorithm;
            }
        }

        public string KeyXml
        {
            get
            {
                if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
                return asymmetricAlgorithm.ToXmlString(true);
            }
        }

        public int KeySize
        {
            get
            {
                if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
                return this.keySize;
            }

            set
            {
                if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
                if (!IsValidKeySize(value)) throw new Exception("invalid key size");

                this.keySize = value;
                CreateAsymmetricAlgorithm(algorithmName, value);
            }
        }

        public KeySizes[] LegalKeySizes
        {
            get
            {
                if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
                return asymmetricAlgorithm.LegalKeySizes;
            }
        }

        public int DefaultKeySize
        {
            get
            {
                if (algorithmName.Equals(cRsa)) return cRsaKeySizeBits;
                else throw new Exception("invalid asymmetric algorithm");
            }
        }

        public bool IsValidKeySize(int keySize) // bits
        {
            if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");

            KeySizes[] legalKeySizes = asymmetricAlgorithm.LegalKeySizes;

            foreach (KeySizes legalKeySize in legalKeySizes)
            {
                for (int i = legalKeySize.MinSize; i <= legalKeySize.MaxSize; i += Math.Max(legalKeySize.SkipSize, 1))
                {
                    if (keySize.Equals(i)) return true;
                }
            }

            return false;
        }

        private void CreateAsymmetricAlgorithm(string algorithmName)
        {
            CreateAsymmetricAlgorithm(algorithmName, DefaultKeySize);
        }

        private void CreateAsymmetricAlgorithm(string algorithmName, int keySize)
        {
            if (algorithmName.Equals(cRsa)) asymmetricAlgorithm = new RSACryptoServiceProvider(keySize);
            else throw new Exception("invalid asymmetric algorithm");
        }

        public void GenerateKey()
        {
            CreateAsymmetricAlgorithm(algorithmName);
        }

        public void GenerateKey(int keySize) // bits
        {
            if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");
            if (!IsValidKeySize(keySize)) throw new Exception("invalid key size");

            CreateAsymmetricAlgorithm(algorithmName, keySize);
        }

        public byte[] Encrypt(string encodingName, string keyXml, bool blnOAEP, string message)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);
            byte[] rawData = encoding.GetBytes(message);

            // encryption
            byte[] encryptedMessage = Encrypt(encodingName, keyXml, blnOAEP, rawData);
            return encryptedMessage;
        }

        public byte[] Encrypt(string encodingName, string keyXml, bool blnOAEP, byte[] message)
        {
            // validation
            if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");

            // setting encryption properties
            asymmetricAlgorithm.FromXmlString(keyXml);

            // encryption
            if (asymmetricAlgorithm.GetType() == typeof(RSACryptoServiceProvider))
            {
                RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)asymmetricAlgorithm;

                byte[] encryptedMessage = rsa.Encrypt(message, blnOAEP);
                return encryptedMessage;
            }
            else
            {
                throw new Exception("invalid asymmetric algorithm");
            }
        }

        public byte[] Decrypt(string keyXml, bool blnOAEP, byte[] encryptedMessage)
        {
            // validation
            if (asymmetricAlgorithm == null) throw new Exception("invalid asymmetric algorithm");

            // setting encryption properties
            asymmetricAlgorithm.FromXmlString(keyXml);

            // decryption
            if (asymmetricAlgorithm.GetType() == typeof(RSACryptoServiceProvider))
            {
                RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)asymmetricAlgorithm;

                byte[] decryptedMessage = rsa.Decrypt(encryptedMessage, blnOAEP);
                return decryptedMessage;
            }
            else
            {
                throw new Exception("invalid asymmetric algorithm");
            }
        }

    }
}
