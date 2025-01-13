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
    public class HybridController
    {
        // private members
        private AsymmetricController asymmetricController = null;
        private SymmetricController symmetricController = null;

        // ctor
        public HybridController(AsymmetricController asymmetricController, SymmetricController symmetricController)
        {
            this.asymmetricController = asymmetricController;
            this.symmetricController = symmetricController;
        }

        // public properties
        public string AsymmetricAlgorithm
        {
            get { return asymmetricController.Algorithm; }
        }

        public string SymmetricAlgorithm
        {
            get { return symmetricController.Algorithm; }
        }

        // encryption
        public byte[] EncryptSymmetrically(string cipherModeName, string paddingModeName, string encodingName, byte[] key, byte[] iv, int blockSize, string textToBeEncrypted)
        {
            return symmetricController.Encrypt(cipherModeName, paddingModeName, encodingName, key, iv, blockSize, textToBeEncrypted);
        }

        public byte[] EncryptSymmetricKey(string encodingName, string asymmetricKeyXml, bool blnOAEP, byte[] sessionKey)
        {
            return asymmetricController.Encrypt(encodingName, asymmetricKeyXml, blnOAEP, sessionKey);
        }

        // decryption
        public byte[] DecryptSymmetricKey(string keyXml, bool blnOAEP, byte[] textToBeDecrypted)
        {
            return asymmetricController.Decrypt(keyXml, blnOAEP, textToBeDecrypted);
        }

        public string DecryptSymmetrically(string cipherModeName, string paddingModeName, string encodingName, byte[] key, byte[] iv, int blockSize, byte[] textToBeDecrypted)
        {
            return symmetricController.Decrypt(cipherModeName, paddingModeName, encodingName, key, iv, blockSize, textToBeDecrypted);
        }

    }
}
