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
    public class SymmetricController
    {
        // cryptographic algorithms
        public static string cRijndael = "Rijndael";
        public static string cTripleDES = "TripleDES";
        public static string[] cSymmetricAlgorithms = new string[] { cRijndael, cTripleDES };
        public static string cDefaultSymmetricAlgorithm = cRijndael;

        // default key sizes
        public static int cRijndaelKeySizeBits = 256;
        public static int cTripleDESKeySizeBits = 192;

        // default block sizes
        public static int cRijndaelBlockSizeBits = 128;
        public static int cTripleDESBlockSizeBits = 64;

        // cipher modes
        public static string[] cCipherModes = new string[] { "CBC", "CFB", "CTS", "ECB", "OFB" };

        // padding modes
        public static string[] cPaddingModes = new string[] { "PKCS7", "Zeros", "ANSIX923", "ISO10126", "None" };

        // private members
        private SymmetricAlgorithm symmetricAlgorithm = null;
        private string algorithmName;
        private byte[] key;
        private byte[] iv;

        // ctor
        public SymmetricController(string algorithmName)
        {
            this.algorithmName = algorithmName;
            symmetricAlgorithm = SymmetricAlgorithm.Create(algorithmName);
            key = null;
            iv = null;
        }

        // public properties
        public string Algorithm
        {
            get { return algorithmName;  }
        }

        public bool IsKnownAlgorithm
        {
            get { return ( symmetricAlgorithm != null); }
        }

        public byte[] Key
        {
            get 
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

                if (key == null) this.GenerateKey();
                return this.key;
            }

            set
            {
                this.key = value;
            }
        }

        public byte[] IV
        {
            get 
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

                if (iv == null) this.GenerateIV();
                return this.iv;
            }

            set
            {
                this.iv = value;
            }
        }

        public int KeySize
        {
            get 
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");
                return this.Key.Length * 8; // bits
            } 
        }

        public int BlockSize
        {
            get
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");
                return symmetricAlgorithm.BlockSize;
            }
        }

        public KeySizes[] LegalKeySizes
        {
            get 
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");
                return symmetricAlgorithm.LegalKeySizes; 
            }
        }

        public KeySizes[] LegalBlockSizes
        {
            get 
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");
                return symmetricAlgorithm.LegalBlockSizes; 
            }
        }

        public int DefaultKeySize
        {
            get
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

                if (algorithmName.Equals(cRijndael)) return cRijndaelKeySizeBits;
                else if (algorithmName.Equals(cTripleDES)) return cTripleDESKeySizeBits;
                else throw new Exception("invalid symmetric algorithm");
            }
        }

        public int DefaultBlockSize
        {
            get
            {
                if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

                if (algorithmName.Equals(cRijndael)) return cRijndaelBlockSizeBits;
                else if (algorithmName.Equals(cTripleDES)) return cTripleDESBlockSizeBits;
                else throw new Exception("invalid symmetric algorithm");
            }
        }

        public bool IsValidKeySize(int keySize) // bits
        {
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");
            return symmetricAlgorithm.ValidKeySize(keySize);
        }

        public bool IsValidBlockSize(int blockSize) // bits
        {
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

            KeySizes[] legalBlockSizes = symmetricAlgorithm.LegalBlockSizes;

            foreach(KeySizes legalBlockSize in legalBlockSizes)
            {
                for (int i = legalBlockSize.MinSize; i <= legalBlockSize.MaxSize; i += Math.Max(legalBlockSize.SkipSize, 1))
                {
                    if (blockSize.Equals(i)) return true;
                }
            }

            return false;
        }

        public void GenerateKey()
        {
            GenerateKey(DefaultKeySize);
        }

        public void GenerateKey(int keySize) // bits
        {
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");
            if (!symmetricAlgorithm.ValidKeySize(keySize)) throw new Exception("invalid key size");

            this.key = RandomNumberController.GenerateBytes(keySize / 8);
        }

        public void GenerateIV()
        {
            GenerateIV(DefaultBlockSize);
        }

        public void GenerateIV(int blockSize) // bits
        {
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

            this.iv = RandomNumberController.GenerateBytes(blockSize / 8);
        }

        public void DeriveKey(string passphrase)
        {
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

            byte[] salt = RandomNumberController.GenerateBytes(256);

            int countInterations = RandomNumberController.GenerateBytes(1)[0];
            if (countInterations == 0) countInterations = passphrase.Length;

            Rfc2898DeriveBytes rdb = new Rfc2898DeriveBytes(passphrase, salt, countInterations);

            this.Key = rdb.GetBytes(symmetricAlgorithm.KeySize / 8);
            this.IV = rdb.GetBytes(symmetricAlgorithm.IV.Length);
        }

        public byte[] Encrypt(string cipherModeName, string paddingModeName, string encodingName, byte[] key, byte[] iv, int blockSize, string message)
        {
            // conversion
            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cipherModeName);
            PaddingMode paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), paddingModeName);
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

            // setting encryption properties
            symmetricAlgorithm.Mode = cipherMode;
            symmetricAlgorithm.Padding = paddingMode;
            symmetricAlgorithm.BlockSize = blockSize;

            // encryption
            ICryptoTransform encryptor = symmetricAlgorithm.CreateEncryptor(key, iv);
            byte[] encryptedMessage = Encrypt(encryptor, message, encoding);

            return encryptedMessage;
        }

        public byte[] Encrypt(ICryptoTransform encryptor, string message, Encoding encoding)
        {
            MemoryStream memoryStream = null;
            CryptoStream cryptoStream = null;

            try
            {
                memoryStream = new MemoryStream();
                cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                byte[] rawData = encoding.GetBytes(message);

                cryptoStream.Write(rawData, 0, rawData.Length);
                cryptoStream.FlushFinalBlock();

                // retrieve text representation of encrypted stream from memory
                memoryStream.Seek(0, SeekOrigin.Begin);
                byte[] encryptedMessage = memoryStream.ToArray();

                return encryptedMessage;
            }
            finally
            {
                if (cryptoStream != null) cryptoStream.Close();
                if (memoryStream != null) memoryStream.Close();
            }
        }

        public string Decrypt(string cipherModeName, string paddingModeName, string encodingName, byte[] key, byte[] iv, int blockSize, byte[] encryptedData)
        {
            // conversion
            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cipherModeName);
            PaddingMode paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), paddingModeName);
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (symmetricAlgorithm == null) throw new Exception("invalid symmetric algorithm");

            // setting encryption properties
            symmetricAlgorithm.Mode = cipherMode;
            symmetricAlgorithm.Padding = paddingMode;
            symmetricAlgorithm.BlockSize = blockSize;

            // decryption
            ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor(key, iv);
            string decryptedData = Decrypt(decryptor, encryptedData, encoding);

            return decryptedData;
        }

        private string Decrypt(ICryptoTransform decryptor, byte[] encryptedData, Encoding encoding)
        {
            MemoryStream memoryStream = null;
            CryptoStream cryptoStream = null;

            try
            {
                memoryStream = new MemoryStream(encryptedData);
                cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

                byte[] buffer = new byte[256];
                int bytesRead = 0;

                StringBuilder decryptedData = new StringBuilder();

                while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length - 1)) > 0)
                {
                    string decryptedBuffer = encoding.GetString(buffer, 0, bytesRead);
                    decryptedData.Append(decryptedBuffer);
                }

                // strip off trailing zeroes (due to block sizes)
                return decryptedData.ToString();
            }
            finally
            {
                if (cryptoStream != null) cryptoStream.Close();
                if (memoryStream != null) memoryStream.Close();
            }
        }

    }
}
