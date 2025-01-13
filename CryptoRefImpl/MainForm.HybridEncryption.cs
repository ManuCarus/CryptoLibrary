/*
   CryptoRefImpl - demonstrates the use of safe cryptographic algorithms within the CryptoLibrary
   Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de)

   This reference implementation demonstrates how to make use of the CryptoLibrary. 
   CryptoLibrary exposes security functionality to the programmer, such as random number generation, hashing,
   salted hashing, message authentication code, symmetric encryption, asymmetric encryption, hybrid encryption,
   digital signature and in-memory protection.
 
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
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CryptoLibrary.Controller;

namespace CryptoSamples.View
{
    partial class MainForm
    {
        // private members
        private AsymmetricController asymmetricHybridController = null;
        private SymmetricController symmetricHybridController = null;
        private HybridController hybridController = null;

        // hybrid encryption controller creator
        private AsymmetricController GetAsymmetricHybridController(string algorithmName)
        {
            if (asymmetricHybridController == null) asymmetricHybridController = new AsymmetricController(algorithmName);
            else if (!asymmetricHybridController.Algorithm.Equals(algorithmName)) asymmetricHybridController = new AsymmetricController(algorithmName);

            return asymmetricHybridController;
        }

        private SymmetricController GetSymmetricHybridController(string algorithmName)
        {
            if (symmetricHybridController == null) symmetricHybridController = new SymmetricController(algorithmName);
            else if (!symmetricHybridController.Algorithm.Equals(algorithmName)) symmetricHybridController = new SymmetricController(algorithmName);

            return symmetricHybridController;
        }

        private HybridController GetHybridController(string asymmetricAlgorithmName, string symmetricAlgorithmName)
        {
            AsymmetricController asymmetricHybridController = GetAsymmetricHybridController(asymmetricAlgorithmName);
            SymmetricController symmetricHybridController = GetSymmetricHybridController(symmetricAlgorithmName);

            if (hybridController == null) hybridController = new HybridController(asymmetricHybridController, symmetricHybridController);
            else if (!hybridController.AsymmetricAlgorithm.Equals(asymmetricAlgorithmName)) hybridController = new HybridController(asymmetricHybridController, symmetricHybridController);
            else if (!hybridController.SymmetricAlgorithm.Equals(symmetricAlgorithmName)) hybridController = new HybridController(asymmetricHybridController, symmetricHybridController);

            return hybridController;
        }

        private void PopulateHybridControls()
        {
            // cboHybridEncryptionAsymmetricAlgorithm
            cboHybridEncryptionAsymmetricAlgorithm.Items.Clear();
            foreach (string asymmetricAlgorithm in AsymmetricController.cAsymmetricAlgorithms) cboHybridEncryptionAsymmetricAlgorithm.Items.Add(asymmetricAlgorithm);
            if (cboHybridEncryptionAsymmetricAlgorithm.Items.Count > 0) cboHybridEncryptionAsymmetricAlgorithm.SelectedIndex = 0;

            // cboHybridEncryptionAsymmetricAlgorithmPaddingMode
            cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Items.Clear();
            foreach (string paddingMode in AsymmetricController.cPaddingModes) cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Items.Add(paddingMode);
            if (cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Items.Count > 0) cboHybridEncryptionAsymmetricAlgorithmPaddingMode.SelectedIndex = 0;

            // cboHybridEncryptionSymmetricAlgorithm
            cboHybridEncryptionSymmetricAlgorithm.Items.Clear();
            foreach (string symmetricAlgorithm in SymmetricController.cSymmetricAlgorithms) cboHybridEncryptionSymmetricAlgorithm.Items.Add(symmetricAlgorithm);
            if (cboHybridEncryptionSymmetricAlgorithm.Items.Count > 0) cboHybridEncryptionSymmetricAlgorithm.SelectedIndex = 0;

            // cboHybridEncryptionEncoding
            cboHybridEncryptionEncoding.Items.Clear();
            cboHybridEncryptionEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboHybridEncryptionEncoding.Items.Add(encoding.WebName);
            }
            cboHybridEncryptionEncoding.SelectedItem = EncodingController.cDefaultEncoding;

            ChangeAsymmetricHybridAlgorithm();
            ChangeSymmetricHybridAlgorithm();
        }

        private void ClearHybridOutputFields()
        {
            txtHybridEncryptionEncryptedSessionKey.Text = String.Empty;
            txtHybridEncryptionEncryptedIV.Text = String.Empty;
            txtHybridEncryptionEncryptedText.Text = String.Empty;
            txtHybridEncryptionDecryptedSessionKey.Text = String.Empty;
            txtHybridEncryptionDecryptedIV.Text = String.Empty;
            txtHybridEncryptionDecryptedText.Text = String.Empty;
        }

        private void cboHybridEncryptionAsymmetricAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeAsymmetricHybridAlgorithm();
        }

        private void cboHybridEncryptionAsymmetricAlgorithmPaddingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void cboHybridEncryptionEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }


        private void cboHybridEncryptionSymmetricAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSymmetricHybridAlgorithm();
        }

        private void txtHybridEncryptionAsymmetricAlgorithmKeyXml_TextChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void txtHybridEncryptionAsymmetricAlgorithmKeySize_TextChanged(object sender, EventArgs e)
        {
            txtHybridEncryptionAsymmetricAlgorithmKeyXml.Text = String.Empty;
            ClearHybridOutputFields();
        }
        
        private void ChangeAsymmetricHybridAlgorithm()
        {
            // clear asymmetric algorithm properties
            txtHybridEncryptionAsymmetricAlgorithmKeySize.Text = String.Empty;
            txtHybridEncryptionAsymmetricAlgorithmKeyXml.Text = String.Empty;
            ClearHybridOutputFields();

            // validation
            if ((cboHybridEncryptionAsymmetricAlgorithm.SelectedIndex < 0) || (cboHybridEncryptionAsymmetricAlgorithm.SelectedIndex >= cboHybridEncryptionAsymmetricAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionAsymmetricAlgorithm.Focus();
                return;
            }            

            // create controller with new algorithm
            string asymmetricAlgorithmName = (string)cboHybridEncryptionAsymmetricAlgorithm.SelectedItem;
            asymmetricHybridController = GetAsymmetricHybridController(asymmetricAlgorithmName);

            if (!asymmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionAsymmetricAlgorithm.Focus();
                return;
            }

            // txtHybridEncryptionAsymmetricAlgorithmKeySize
            txtHybridEncryptionAsymmetricAlgorithmKeySize.Text = asymmetricHybridController.KeySize.ToString();

            // lblHybridEncryptionAsymmetricAlgorithmKeySizeBits
            StringBuilder legalKeySizes = new StringBuilder();
            foreach (KeySizes keySizes in asymmetricHybridController.LegalKeySizes) legalKeySizes.Append(String.Format(cKeySizeFormat, keySizes.MinSize.ToString(), keySizes.MaxSize.ToString(), keySizes.SkipSize.ToString()) + ",");
            legalKeySizes.Remove(legalKeySizes.Length - 1, 1);
            lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.Text = legalKeySizes.ToString();

            // txtHybridEncryptionAsymmetricAlgorithmKeyXml
            DisplayAsymmetricHybridKey(asymmetricHybridController.KeyXml);
        }

        private void ChangeSymmetricHybridAlgorithm()
        {
            // clear symmetric algorithm properties
            txtHybridEncryptionSymmetricAlgorithmKeySize.Text = String.Empty;
            txtHybridEncryptionSymmetricAlgorithmBlockSize.Text = String.Empty;
            txtHybridEncryptionSymmetricKey.Text = String.Empty;
            txtHybridEncryptionIv.Text = String.Empty;
            txtHybridEncryptionIv.Text = String.Empty;
            cboHybridEncryptionSymmetricAlgorithmCipherMode.Items.Clear();
            cboHybridEncryptionSymmetricAlgorithmPaddingMode.Items.Clear();

            ClearHybridOutputFields();

            // validation
            if ((cboHybridEncryptionSymmetricAlgorithm.SelectedIndex < 0) || (cboHybridEncryptionSymmetricAlgorithm.SelectedIndex >= cboHybridEncryptionSymmetricAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithm.Focus();
                return;
            }

            // create controller with new algorithm
            string symmetricAlgorithmName = (string)cboHybridEncryptionSymmetricAlgorithm.SelectedItem;
            symmetricHybridController = GetSymmetricHybridController(symmetricAlgorithmName);

            if (!symmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithm.Focus();
                return;
            }

            // txtHybridEncryptionSymmetricAlgorithmKeySize
            txtHybridEncryptionSymmetricAlgorithmKeySize.Text = symmetricHybridController.KeySize.ToString();

            // lblHybridEncryptionSymmetricAlgorithmKeySizeBits
            StringBuilder legalKeySizes = new StringBuilder();
            foreach (KeySizes keySizes in symmetricHybridController.LegalKeySizes) legalKeySizes.Append(String.Format(cKeySizeFormat, keySizes.MinSize.ToString(), keySizes.MaxSize.ToString(), keySizes.SkipSize.ToString()) + ",");
            legalKeySizes.Remove(legalKeySizes.Length - 1, 1);
            lblHybridEncryptionSymmetricAlgorithmKeySizeBits.Text = legalKeySizes.ToString();

            // txtHybridEncryptionSymmetricAlgorithmBlockSize
            txtHybridEncryptionSymmetricAlgorithmBlockSize.Text = symmetricHybridController.BlockSize.ToString();

            // lblHybridEncryptionSymmetricAlgorithmBlockSizeBits
            StringBuilder legalBlockSizes = new StringBuilder();
            foreach (KeySizes blockSizes in symmetricHybridController.LegalBlockSizes) legalBlockSizes.Append(String.Format(cBlockSizeFormat, blockSizes.MinSize.ToString(), blockSizes.MaxSize.ToString(), blockSizes.SkipSize.ToString()) + ",");
            legalBlockSizes.Remove(legalBlockSizes.Length - 1, 1);
            lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.Text = legalBlockSizes.ToString();

            // cboHybridEncryptionSymmetricAlgorithmCipherMode
            foreach (string cipherMode in SymmetricController.cCipherModes) cboHybridEncryptionSymmetricAlgorithmCipherMode.Items.Add(cipherMode);
            if (cboHybridEncryptionSymmetricAlgorithmCipherMode.Items.Count > 0) cboHybridEncryptionSymmetricAlgorithmCipherMode.SelectedIndex = 0;

            // cboHybridEncryptionSymmetricAlgorithmPaddingMode
            foreach (string paddingMode in SymmetricController.cPaddingModes) cboHybridEncryptionSymmetricAlgorithmPaddingMode.Items.Add(paddingMode);
            if (cboHybridEncryptionSymmetricAlgorithmPaddingMode.Items.Count > 0) cboHybridEncryptionSymmetricAlgorithmPaddingMode.SelectedIndex = 0;

            // txtHybridEncryptionSymmetricKey
            DisplaySymmetricHybridKey(symmetricHybridController.Key);

            // txtHybridEncryptionIv
            DisplayHybridInitializationVector(symmetricHybridController.IV);
        }

        private void DisplayAsymmetricHybridKey(string xmlKey)
        {
            string formattedXmlKey = Formatter.FormatXmlKey(xmlKey);
            txtHybridEncryptionAsymmetricAlgorithmKeyXml.Text = formattedXmlKey;
        }

        private void DisplaySymmetricHybridKey(byte[] key)
        {
            string formattedKey = Formatter.BinaryToHex(key);
            txtHybridEncryptionSymmetricKey.Text = formattedKey;
        }

        private void DisplayHybridInitializationVector(byte[] iv)
        {
            string formattedIV = Formatter.BinaryToHex(iv);
            txtHybridEncryptionIv.Text = formattedIV;
        }

        private void txtHybridEncryptionSymmetricAlgorithmKeySize_TextChanged(object sender, EventArgs e)
        {
            txtHybridEncryptionSymmetricKey.Text = String.Empty;
            ClearHybridOutputFields();
        }

        private void txtHybridEncryptionSymmetricAlgorithmBlockSize_TextChanged(object sender, EventArgs e)
        {
            txtHybridEncryptionIv.Text = String.Empty;
            ClearHybridOutputFields();
        }
        
        private void cboHybridEncryptionSymmetricAlgorithmCipherMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void cboHybridEncryptionSymmetricAlgorithmPaddingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void txtHybridEncryptionSymmetricKey_TextChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void txtHybridEncryptionIv_TextChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void txtHybridEncryptionTextToBeEncrypted_TextChanged(object sender, EventArgs e)
        {
            ClearHybridOutputFields();
        }

        private void btnHybridEncryptionCreateAsymmetricKey_Click(object sender, EventArgs e)
        {
            string asymmetricAlgorithmName = (string)cboHybridEncryptionAsymmetricAlgorithm.SelectedItem;
            AsymmetricController asymmetricHybridController = GetAsymmetricHybridController(asymmetricAlgorithmName);

            if (!asymmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionAsymmetricAlgorithm.Focus();
                return;
            }

            if (!IsValidHybridAsymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid asymmetric key size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionAsymmetricAlgorithmKeySize.Focus();
                return;
            }

            ClearHybridOutputFields();
            asymmetricHybridController.GenerateKey(GetValidHybridAsymmetricKeySize());
            DisplayAsymmetricHybridKey(asymmetricHybridController.KeyXml);
        }

        private int GetValidHybridAsymmetricKeySize()
        {
            int keySize = int.Parse(txtHybridEncryptionAsymmetricAlgorithmKeySize.Text, NumberStyles.Integer);
            return keySize;
        }

        private bool IsValidHybridAsymmetricKeySize()
        {
            try
            {
                int keySize = GetValidHybridAsymmetricKeySize();
                return asymmetricHybridController.IsValidKeySize(keySize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private int GetValidHybridSymmetricKeySize()
        {
            int keySize = int.Parse(txtHybridEncryptionSymmetricAlgorithmKeySize.Text, NumberStyles.Integer);
            return keySize;
        }

        private bool IsValidHybridSymmetricKeySize()
        {
            try
            {
                int keySize = GetValidHybridSymmetricKeySize();
                return symmetricHybridController.IsValidKeySize(keySize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private int GetValidHybridSymmetricBlockSize()
        {
            int blockSize = int.Parse(txtHybridEncryptionSymmetricAlgorithmBlockSize.Text, NumberStyles.Integer);
            return blockSize;
        }

        private bool IsValidHybridSymmetricBlockSize()
        {
            try
            {
                int blockSize = GetValidHybridSymmetricBlockSize();
                return symmetricHybridController.IsValidBlockSize(blockSize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnHybridEncryptionCreateSymmetricKey_Click(object sender, EventArgs e)
        {
            string symmetricAlgorithmName = (string)cboHybridEncryptionSymmetricAlgorithm.SelectedItem;
            SymmetricController symmetricHybridController = GetSymmetricHybridController(symmetricAlgorithmName);

            if (!symmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithm.Focus();
                return;
            }

            if (!IsValidHybridSymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid symmetric key size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionSymmetricKey.Focus();
                return;
            }

            ClearHybridOutputFields();
            symmetricHybridController.GenerateKey(GetValidHybridSymmetricKeySize());
            DisplaySymmetricHybridKey(symmetricHybridController.Key);
        }

        private void btnHybridEncryptionCreateIv_Click(object sender, EventArgs e)
        {
            string symmetricAlgorithmName = (string)cboHybridEncryptionSymmetricAlgorithm.SelectedItem;
            SymmetricController symmetricHybridController = GetSymmetricHybridController(symmetricAlgorithmName);

            if (!symmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithm.Focus();
                return;
            }

            ClearHybridOutputFields();
            symmetricHybridController.GenerateIV(GetValidHybridSymmetricBlockSize());
            DisplayHybridInitializationVector(symmetricHybridController.IV);
        }

        private bool ValidateHybridControls()
        {
            string asymmetricAlgorithmName = (string)cboHybridEncryptionAsymmetricAlgorithm.SelectedItem;
            string symmetricAlgorithmName = (string)cboHybridEncryptionSymmetricAlgorithm.SelectedItem;

            AsymmetricController asymmetricHybridController = GetAsymmetricHybridController(asymmetricAlgorithmName);
            SymmetricController symmetricHybridController = GetSymmetricHybridController(symmetricAlgorithmName);
            HybridController hybridController = GetHybridController(asymmetricAlgorithmName, symmetricAlgorithmName);

            // asymmetric algorithm
            if (!asymmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionAsymmetricAlgorithm.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtHybridEncryptionAsymmetricAlgorithmKeySize.Text))
            {
                MessageBox.Show("Please enter an asymmetric key size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionAsymmetricAlgorithmKeySize.Focus();
                return false;
            }

            if (!IsValidHybridAsymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid asymmetric key size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionAsymmetricAlgorithmKeySize.Focus();
                return false;
            }

            if ((cboHybridEncryptionAsymmetricAlgorithmPaddingMode.SelectedIndex < 0) || (cboHybridEncryptionAsymmetricAlgorithmPaddingMode.SelectedIndex >= cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Items.Count))
            {
                MessageBox.Show("Please select an asymmetric padding mode!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtHybridEncryptionAsymmetricAlgorithmKeyXml.Text))
            {
                MessageBox.Show("Please create an asymmetric key!", "Warning", MessageBoxButtons.OK);
                btnHybridEncryptionCreateAsymmetricKey.Focus();
                return false;
            }

            // symmetric algorithm
            if (!symmetricHybridController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithm.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtHybridEncryptionSymmetricAlgorithmKeySize.Text))
            {
                MessageBox.Show("Please enter a symmetric key size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionSymmetricAlgorithmKeySize.Focus();
                return false;
            }

            if (!IsValidHybridSymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid symmetric key size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionSymmetricAlgorithmKeySize.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtHybridEncryptionSymmetricAlgorithmBlockSize.Text))
            {
                MessageBox.Show("Please enter a symmetric block size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionSymmetricAlgorithmBlockSize.Focus();
                return false;
            }

            if (!IsValidHybridSymmetricBlockSize())
            {
                MessageBox.Show("Please enter a valid symmetric block size!", "Warning", MessageBoxButtons.OK);
                txtHybridEncryptionSymmetricAlgorithmBlockSize.Focus();
                return false;
            }

            if ((cboHybridEncryptionSymmetricAlgorithmCipherMode.SelectedIndex < 0) || (cboHybridEncryptionSymmetricAlgorithmCipherMode.SelectedIndex >= cboHybridEncryptionSymmetricAlgorithmCipherMode.Items.Count))
            {
                MessageBox.Show("Please select a cipher mode!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithmCipherMode.Focus();
                return false;
            }

            if ((cboHybridEncryptionSymmetricAlgorithmPaddingMode.SelectedIndex < 0) || (cboHybridEncryptionSymmetricAlgorithmPaddingMode.SelectedIndex >= cboHybridEncryptionSymmetricAlgorithmPaddingMode.Items.Count))
            {
                MessageBox.Show("Please select a symmetric padding mode!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionSymmetricAlgorithmPaddingMode.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtHybridEncryptionSymmetricKey.Text))
            {
                MessageBox.Show("Please create a session key!", "Warning", MessageBoxButtons.OK);
                btnHybridEncryptionCreateSymmetricKey.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtHybridEncryptionIv.Text))
            {
                MessageBox.Show("Please create an initialization vector!", "Warning", MessageBoxButtons.OK);
                btnHybridEncryptionCreateIv.Focus();
                return false;
            }

            if ((cboHybridEncryptionEncoding.SelectedIndex < 0) || (cboHybridEncryptionEncoding.SelectedIndex >= cboHybridEncryptionEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding!", "Warning", MessageBoxButtons.OK);
                cboHybridEncryptionEncoding.Focus();
                return false;
            }

            return true;
        }

        private void btnHybridEncryptionEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateHybridControls()) return;

                if (String.IsNullOrEmpty(txtHybridEncryptionTextToBeEncrypted.Text))
                {
                    MessageBox.Show("Please enter a text to be encrypted!", "Warning", MessageBoxButtons.OK);
                    txtHybridEncryptionTextToBeEncrypted.Focus();
                    return;
                }

                // symmetric encryption (of data)
                string cipherModeName = (string)cboHybridEncryptionSymmetricAlgorithmCipherMode.SelectedItem;
                string symmetricPaddingModeName = (string)cboHybridEncryptionSymmetricAlgorithmPaddingMode.SelectedItem;
                byte[] key = Formatter.HexToBinary(txtHybridEncryptionSymmetricKey.Text);
                byte[] iv = Formatter.HexToBinary(txtHybridEncryptionIv.Text);
                int blockSize = GetValidHybridSymmetricBlockSize();
                string encodingName = (string)cboHybridEncryptionEncoding.SelectedItem;
                string textToBeEncrypted = txtHybridEncryptionTextToBeEncrypted.Text;

                string asymmetricAlgorithmName = (string)cboHybridEncryptionAsymmetricAlgorithm.SelectedItem;
                string symmetricAlgorithmName = (string)cboHybridEncryptionSymmetricAlgorithm.SelectedItem;

                HybridController hybridController = GetHybridController(asymmetricAlgorithmName, symmetricAlgorithmName);
                byte[] encryptedText = hybridController.EncryptSymmetrically(cipherModeName, symmetricPaddingModeName, encodingName, key, iv, blockSize, textToBeEncrypted);

                // asymmetric encryption (of session key)
                string asymmetricKeyXml = txtHybridEncryptionAsymmetricAlgorithmKeyXml.Text;
                string asymmetricPaddingModeName = (string)cboHybridEncryptionAsymmetricAlgorithmPaddingMode.SelectedItem;
                bool blnOAEP = (asymmetricPaddingModeName.Equals(AsymmetricController.cPaddingModeOAEP));

                byte[] encryptedSessionKey = hybridController.EncryptSymmetricKey(encodingName, asymmetricKeyXml, blnOAEP, key);
                byte[] encryptedIV = hybridController.EncryptSymmetricKey(encodingName, asymmetricKeyXml, blnOAEP, iv);

                // display results
                string encryptedSessionKeyHex = Formatter.BinaryToHex(encryptedSessionKey);
                string encryptedIvHex = Formatter.BinaryToHex(encryptedIV);
                string encryptedTextHex = Formatter.BinaryToHex(encryptedText);

                txtHybridEncryptionEncryptedSessionKey.Text = encryptedSessionKeyHex;
                txtHybridEncryptionEncryptedIV.Text = encryptedIvHex;
                txtHybridEncryptionEncryptedText.Text = encryptedTextHex;
            }
            catch (CryptographicException cex)
            {
                if (cex.Message.Contains("Bad Length.")) MessageBox.Show(cex.Message + "(Session key is too big for the given asymmetric key size!)", "Error", MessageBoxButtons.OK);
                else MessageBox.Show(cex.Message, "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnHybridEncryptionDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateHybridControls()) return;

                if (String.IsNullOrEmpty(txtHybridEncryptionEncryptedText.Text) || String.IsNullOrEmpty(txtHybridEncryptionEncryptedSessionKey.Text))
                {
                    MessageBox.Show("Please encrypt first!", "Warning", MessageBoxButtons.OK);
                    btnHybridEncryptionEncrypt.Focus();
                    return;
                }

                // asymmetric decryption (of syssion key)
                int asymmetricKeySize = GetValidHybridAsymmetricKeySize();
                string asymmetricKeyXml = txtHybridEncryptionAsymmetricAlgorithmKeyXml.Text;
                string asymmetricPaddingModeName = (string)cboHybridEncryptionAsymmetricAlgorithmPaddingMode.SelectedItem;
                bool blnOAEP = (asymmetricPaddingModeName.Equals(AsymmetricController.cPaddingModeOAEP));
                string encodingName = (string)cboHybridEncryptionEncoding.SelectedItem;
                byte[] keyToBeDecrypted = Formatter.HexToBinary(txtHybridEncryptionEncryptedSessionKey.Text);
                byte[] ivToBeDecrypted = Formatter.HexToBinary(txtHybridEncryptionEncryptedIV.Text);
                int blockSize = GetValidHybridSymmetricBlockSize();

                string asymmetricAlgorithmName = (string)cboHybridEncryptionAsymmetricAlgorithm.SelectedItem;
                string symmetricAlgorithmName = (string)cboHybridEncryptionSymmetricAlgorithm.SelectedItem;

                HybridController hybridController = GetHybridController(asymmetricAlgorithmName, symmetricAlgorithmName);

                byte[] decryptedSessionKey = hybridController.DecryptSymmetricKey(asymmetricKeyXml, blnOAEP, keyToBeDecrypted);
                byte[] decryptedIv = hybridController.DecryptSymmetricKey(asymmetricKeyXml, blnOAEP, ivToBeDecrypted);

                // symmetric decryption (of data)
                string cipherModeName = (string)cboHybridEncryptionSymmetricAlgorithmCipherMode.SelectedItem;
                string symmetricPaddingModeName = (string)cboHybridEncryptionSymmetricAlgorithmPaddingMode.SelectedItem;
                byte[] textToBeDecrypted = Formatter.HexToBinary(txtHybridEncryptionEncryptedText.Text);

                string decryptedText = hybridController.DecryptSymmetrically(cipherModeName, symmetricPaddingModeName, encodingName, decryptedSessionKey, decryptedIv, blockSize, textToBeDecrypted);

                // display results
                txtHybridEncryptionDecryptedSessionKey.Text = Formatter.BinaryToHex(decryptedSessionKey);
                txtHybridEncryptionDecryptedIV.Text = Formatter.BinaryToHex(decryptedIv);
                txtHybridEncryptionDecryptedText.Text = decryptedText;
            }
            catch (CryptographicException cex)
            {
                if (cex.Message.Contains("Bad Length.")) MessageBox.Show(cex.Message + "(Session key is too big for the given asymmetric key size!)", "Error", MessageBoxButtons.OK);
                else MessageBox.Show(cex.Message, "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

    }
}
