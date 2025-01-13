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
    public class SignatureController
    {
        // cryptographic algorithms
        public static string cDsa = "DSA";
        public static string cRsa = "RSA";
        private static string cSha1 = "SHA1";

        public static string[] cSignatureAlgorithms = new string[] { cDsa, cRsa };
        public static string[] cDsaHashAlgorithms = new string[] { cSha1 };
        public static string[] cRsaHashAlgorithms = new string[] { "SHA256", "SHA384", "SHA512" };

        // default key sizes
        public static int cDsaKeySizeBits = 1024;
        public static int cRsaKeySizeBits = 1024;

        // internal abstraction layer
        private abstract class SignatureAlgorithm
        {
            protected AsymmetricAlgorithm asymmetricAlgorithm = null;
            protected HashAlgorithm hashAlgorithm = null;
            protected string hashAlgorithmName;

            internal SignatureAlgorithm(string hashAlgorithmName)
            {
                this.hashAlgorithm = HashAlgorithm.Create(hashAlgorithmName);
                this.hashAlgorithmName = hashAlgorithmName;
            }

            internal HashAlgorithm HashAlgorithm { get { return hashAlgorithm; } }
            internal string KeyExchangeAlgorithm { get { return asymmetricAlgorithm.KeyExchangeAlgorithm; } }
            internal string SignAlgorithm { get { return asymmetricAlgorithm.SignatureAlgorithm; } }
            internal int KeySize { get { return asymmetricAlgorithm.KeySize; } }
            internal KeySizes[] LegalKeySizes { get { return asymmetricAlgorithm.LegalKeySizes; } }
            internal void FromXmlString(string xmlString) { asymmetricAlgorithm.FromXmlString(xmlString); }
            internal string ToXmlString(bool includePrivateParameters) { return asymmetricAlgorithm.ToXmlString(includePrivateParameters); }

            internal abstract byte[] Sign(byte[] data);
            internal abstract byte[] Sign(Stream inputStream);
            internal abstract bool VerifyData(byte[] data, byte[] signature);
            internal abstract bool VerifyHash(byte[] hash, byte[] signature);
        }

        private class DsaAlgorithm : SignatureAlgorithm
        {
            internal DsaAlgorithm(string hashAlgorithmName, int keySize) : base(hashAlgorithmName)
            {
                asymmetricAlgorithm = new DSACryptoServiceProvider(keySize);
            }

            internal override byte[] Sign(byte[] data) { return ((DSACryptoServiceProvider)asymmetricAlgorithm).SignData(data); }
            internal override byte[] Sign(Stream inputStream) { return ((DSACryptoServiceProvider)asymmetricAlgorithm).SignData(inputStream); }
            internal override bool VerifyData(byte[] data, byte[] signature) { return ((DSACryptoServiceProvider)asymmetricAlgorithm).VerifyData(data, signature); }
            internal override bool VerifyHash(byte[] hash, byte[] signature) { return ((DSACryptoServiceProvider)asymmetricAlgorithm).VerifyHash(hash, hashAlgorithmName, signature); }
        }

        private class RsaAlgorithm : SignatureAlgorithm
        {
            internal RsaAlgorithm(string hashAlgorithmName, int keySize) : base(hashAlgorithmName)
            {
                asymmetricAlgorithm = new RSACryptoServiceProvider(keySize);
            }

            internal override byte[] Sign(byte[] data) { return ((RSACryptoServiceProvider)asymmetricAlgorithm).SignData(data, hashAlgorithm); }
            internal override byte[] Sign(Stream inputStream) { return ((RSACryptoServiceProvider)asymmetricAlgorithm).SignData(inputStream, hashAlgorithm); }
            internal override bool VerifyData(byte[] data, byte[] signature) { return ((RSACryptoServiceProvider)asymmetricAlgorithm).VerifyData(data, hashAlgorithm, signature); }
            internal override bool VerifyHash(byte[] hash, byte[] signature) { return ((RSACryptoServiceProvider)asymmetricAlgorithm).VerifyHash(hash, CryptoConfig.MapNameToOID(hashAlgorithmName), signature); }
        }

        // private members
        private SignatureAlgorithm signatureAlgorithm = null;
        private string signatureAlgorithmName;
        private string hashAlgorithmName;
        private int keySize; // bits

        // ctor
        public SignatureController(string signatureAlgorithmName, string hashAlgorithmName)
        {
            this.signatureAlgorithmName = signatureAlgorithmName;
            this.hashAlgorithmName = hashAlgorithmName;
            this.keySize = DefaultKeySize;

            CreateSignatureAlgorithm(signatureAlgorithmName, hashAlgorithmName, DefaultKeySize);
        }

        // public properties
        public string SignatureAlgorithmName
        {
            get { return signatureAlgorithmName; }
        }

        public string HashAlgorithmName
        {
            get { return hashAlgorithmName; }
        }

        public bool IsKnownSignatureAlgorithm
        {
            get { return (signatureAlgorithm != null); }
        }

        public bool IsKnownHashAlgorithm
        {
            get { return (signatureAlgorithm.HashAlgorithm != null); }
        }

        public string KeyExchangeAlgorithm
        {
            get
            {
                if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
                return signatureAlgorithm.KeyExchangeAlgorithm;
            }
        }

        public string SignAlgorithm
        {
            get
            {
                if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
                return signatureAlgorithm.SignAlgorithm;
            }
        }

        public int KeySize
        {
            get
            {
                if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
                return this.keySize;
            }

            set
            {
                if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
                if (!IsValidKeySize(value)) throw new Exception("invalid key size");

                this.keySize = value;
                CreateSignatureAlgorithm(signatureAlgorithmName, hashAlgorithmName, value);
            }
        }

        public KeySizes[] LegalKeySizes
        {
            get
            {
                if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
                return signatureAlgorithm.LegalKeySizes;
            }
        }

        public int DefaultKeySize
        {
            get
            {
                if (signatureAlgorithmName.Equals(cDsa)) return cDsaKeySizeBits;
                else if (signatureAlgorithmName.Equals(cRsa)) return cRsaKeySizeBits;
                else throw new Exception("invalid signature algorithm");
            }
        }

        public string KeyXml
        {
            get
            {
                if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
                return signatureAlgorithm.ToXmlString(true);
            }
        }

        public bool IsValidKeySize(int keySize) // bits
        {
            if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");

            KeySizes[] legalKeySizes = signatureAlgorithm.LegalKeySizes;

            foreach (KeySizes legalKeySize in legalKeySizes)
            {
                for (int i = legalKeySize.MinSize; i <= legalKeySize.MaxSize; i += Math.Max(legalKeySize.SkipSize, 1))
                {
                    if (keySize.Equals(i)) return true;
                }
            }

            return false;
        }

        private void CreateSignatureAlgorithm(string signatureAlgorithmName, string hashAlgorithmName)
        {
            CreateSignatureAlgorithm(signatureAlgorithmName, hashAlgorithmName, DefaultKeySize);
        }

        private void CreateSignatureAlgorithm(string signatureAlgorithmName, string hashAlgorithmName, int keySize)
        {
            if (signatureAlgorithmName.Equals(cDsa)) signatureAlgorithm = new DsaAlgorithm(hashAlgorithmName, keySize);
            else if (signatureAlgorithmName.Equals(cRsa)) signatureAlgorithm = new RsaAlgorithm(hashAlgorithmName, keySize);
            else throw new Exception("invalid asymmetric algorithm");
        }

        public void GenerateKey()
        {
            CreateSignatureAlgorithm(signatureAlgorithmName, hashAlgorithmName);
        }

        public void GenerateKey(int keySize) // bits
        {
            if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
            if (!IsValidKeySize(keySize)) throw new Exception("invalid key size");

            CreateSignatureAlgorithm(signatureAlgorithmName, hashAlgorithmName, keySize);
        }

        public byte[] Sign(string encodingName, string keyXml, string message)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
            if (signatureAlgorithm.HashAlgorithm == null) throw new Exception("invalid hash algorithm");

            // setting key
            signatureAlgorithm.FromXmlString(keyXml);

            // signing
            byte[] rawData = encoding.GetBytes(message);
            byte[] signature = signatureAlgorithm.Sign(rawData);

            return signature;
        }

        public byte[] Sign(string encodingName, string keyXml, Stream stream)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
            if (signatureAlgorithm.HashAlgorithm == null) throw new Exception("invalid hash algorithm");

            // setting encryption properties
            signatureAlgorithm.FromXmlString(keyXml);

            // signing
            byte[] signature = signatureAlgorithm.Sign(stream);
            return signature;
        }

        public bool Verify(string encodingName, string keyXml, string message, byte[] signature)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
            if (signatureAlgorithm.HashAlgorithm == null) throw new Exception("invalid hash algorithm");

            // setting key
            signatureAlgorithm.FromXmlString(keyXml);

            // verification
            byte[] rawData = encoding.GetBytes(message);
            bool ok = signatureAlgorithm.VerifyData(rawData, signature);

            return ok;
        }

        public bool Verify(string encodingName, string keyXml, Stream stream, byte[] signature)
        {
            // conversion
            Encoding encoding = EncodingController.GetEncodingByName(encodingName);

            // validation
            if (signatureAlgorithm == null) throw new Exception("invalid signature algorithm");
            if (signatureAlgorithm.HashAlgorithm == null) throw new Exception("invalid hash algorithm");

            // setting key
            signatureAlgorithm.FromXmlString(keyXml);

            // verification
            byte[] hash = signatureAlgorithm.HashAlgorithm.ComputeHash(stream);
            bool ok = signatureAlgorithm.VerifyHash(hash, signature);

            return ok;
        }

    }
}
