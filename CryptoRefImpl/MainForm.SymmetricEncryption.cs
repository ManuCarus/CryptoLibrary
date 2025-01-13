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
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CryptoLibrary.Controller;

namespace CryptoSamples.View
{
    partial class MainForm
    {
        // private members
        private SymmetricController symmetricController = null;

        // symmetric controller creator
        private SymmetricController GetSymmetricController(string symmetricAlgorithmName)
        {
            if (symmetricController == null) symmetricController = new SymmetricController(symmetricAlgorithmName);
            else if (!symmetricController.Algorithm.Equals(symmetricAlgorithmName)) symmetricController = new SymmetricController(symmetricAlgorithmName);

            return symmetricController;
        }

        private void PopulateSymmetricEncryptionControls()
        {
            // cboSymmetricAlgorithm
            foreach (string symmetricAlgorithm in SymmetricController.cSymmetricAlgorithms) cboSymmetricAlgorithm.Items.Add(symmetricAlgorithm);
            if (cboSymmetricAlgorithm.Items.Contains(SymmetricController.cDefaultSymmetricAlgorithm)) cboSymmetricAlgorithm.SelectedItem = SymmetricController.cDefaultSymmetricAlgorithm;
            else if (cboSymmetricAlgorithm.Items.Count > 0) cboSymmetricAlgorithm.SelectedIndex = 0;

            // cboSymmetricEncoding
            cboSymmetricEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboSymmetricEncoding.Items.Add(encoding.WebName);
            }
            cboSymmetricEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void ClearSymmetricEncryptionOutputFields()
        {
            txtSymmetricallyEncryptedValue.Text = String.Empty;
            txtEncryptedValueSize.Text = String.Empty;
            txtSymmetricallyDecryptedValue.Text = String.Empty;
        }

        private void cboSymmetricAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSymmetricAlgorithm();
        }

        private void ChangeSymmetricAlgorithm()
        {
            // clear symmetric algorithm properties
            txtSymmetricKeySize.Text = String.Empty;
            txtSymmetricBlockSize.Text = String.Empty;
            txtSymmetricKey.Text = String.Empty;
            txtSymmetricEncryptionInitializationVector.Text = String.Empty;
            cboSymmetricCipherMode.Items.Clear();
            cboSymmetricPaddingMode.Items.Clear();
            ClearSymmetricEncryptionOutputFields();

            // validation
            if ((cboSymmetricAlgorithm.SelectedIndex < 0) || (cboSymmetricAlgorithm.SelectedIndex >= cboSymmetricAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboSymmetricAlgorithm.Focus();
                return;
            }

            // create controller with new algorithm
            string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
            symmetricController = GetSymmetricController(symmetricAlgorithmName);

            if (!symmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboSymmetricAlgorithm.Focus();
                return;
            }

            // txtSymmetricKeySize
            txtSymmetricKeySize.Text = symmetricController.KeySize.ToString();

            // lblSymmetricKeySizeBits
            StringBuilder legalKeySizes = new StringBuilder();
            foreach (KeySizes keySizes in symmetricController.LegalKeySizes) legalKeySizes.Append(String.Format(cKeySizeFormat, keySizes.MinSize.ToString(), keySizes.MaxSize.ToString(), keySizes.SkipSize.ToString()) + ",");            
            legalKeySizes.Remove(legalKeySizes.Length - 1, 1);
            lblSymmetricKeySizeBits.Text = legalKeySizes.ToString();

            // txtSymmetricBlockSize
            txtSymmetricBlockSize.Text = symmetricController.BlockSize.ToString();

            // lblSymmetricAlgorithmBlockSizeBits
            StringBuilder legalBlockSizes = new StringBuilder();
            foreach (KeySizes blockSizes in symmetricController.LegalBlockSizes) legalBlockSizes.Append(String.Format(cBlockSizeFormat, blockSizes.MinSize.ToString(), blockSizes.MaxSize.ToString(), blockSizes.SkipSize.ToString()) + ",");            
            legalBlockSizes.Remove(legalBlockSizes.Length - 1, 1);
            lblSymmetricBlockSizeBits.Text = legalBlockSizes.ToString();

            // cboSymmetricCipherMode
            foreach (string cipherMode in SymmetricController.cCipherModes) cboSymmetricCipherMode.Items.Add(cipherMode);
            if (cboSymmetricCipherMode.Items.Count > 0) cboSymmetricCipherMode.SelectedIndex = 0;

            // cboSymmetricPaddingMode
            foreach (string paddingMode in SymmetricController.cPaddingModes) cboSymmetricPaddingMode.Items.Add(paddingMode);
            if (cboSymmetricPaddingMode.Items.Count > 0) cboSymmetricPaddingMode.SelectedIndex = 0;

            // txtSymmetricKey
            DisplaySymmetricKey(symmetricController.Key);

            // txtSymmetricEncryptionInitializationVector
            DisplayInitializationVector(symmetricController.IV);
        }

        private void txtSymmetricKeySize_TextChanged(object sender, EventArgs e)
        {
            txtSymmetricKey.Text = String.Empty;
            ClearSymmetricEncryptionOutputFields();
        }

        private void cboSymmetricCipherMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSymmetricEncryptionOutputFields();
        }

        private void cboSymmetricPaddingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSymmetricEncryptionOutputFields();
        }

        private void txtSymmetricKey_TextChanged(object sender, EventArgs e)
        {
            ClearSymmetricEncryptionOutputFields();
        }

        private void txtSymmetricEncryptionInitializationVector_TextChanged(object sender, EventArgs e)
        {
            ClearSymmetricEncryptionOutputFields();
        }

        private void txtSymmetricBlockSize_TextChanged(object sender, EventArgs e)
        {
            txtSymmetricEncryptionInitializationVector.Text = String.Empty;
            ClearSymmetricEncryptionOutputFields();
        }
        
        private void cboSymmetricEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSymmetricEncryptionOutputFields();
        }

        private void txtInputToBeSymmetricallyEncrypted_TextChanged(object sender, EventArgs e)
        {
            ClearSymmetricEncryptionOutputFields();
        }

        private void DisplaySymmetricKey(byte[] key)
        {
            string formattedKey = Formatter.BinaryToHex(key);
            txtSymmetricKey.Text = formattedKey;
        }

        private void DisplayInitializationVector(byte[] iv)
        {
            string formattedIV = Formatter.BinaryToHex(iv);
            txtSymmetricEncryptionInitializationVector.Text = formattedIV;
        }

        private void btnDeriveSymmetricKeyFromPassphrase_Click(object sender, EventArgs e)
        {
            string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
            SymmetricController symmetricController = GetSymmetricController(symmetricAlgorithmName);

            if (!symmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboSymmetricAlgorithm.Focus();
                return;
            }

            string passphrase = txtSymmetricEncryptionPassphrase.Text;

            if (String.IsNullOrEmpty(passphrase))
            {
                MessageBox.Show("Please enter a passphrase!", "Warning", MessageBoxButtons.OK);
                txtSymmetricEncryptionPassphrase.Focus();
                return;
            }

            ClearSymmetricEncryptionOutputFields();
            symmetricController.DeriveKey(passphrase);
            DisplaySymmetricKey(symmetricController.Key);
            DisplayInitializationVector(symmetricController.IV);
        }

        private void btnCreateSymmetricKey_Click(object sender, EventArgs e)
        {
            string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
            SymmetricController symmetricController = GetSymmetricController(symmetricAlgorithmName);

            if (!symmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboSymmetricAlgorithm.Focus();
                return;
            }

            if (!IsValidSymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtSymmetricKeySize.Focus();
                return;
            }

            ClearSymmetricEncryptionOutputFields();
            symmetricController.GenerateKey(GetValidSymmetricKeySize());
            DisplaySymmetricKey(symmetricController.Key);
        }

        private void btnCreateInitializationVector_Click(object sender, EventArgs e)
        {
            string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
            SymmetricController symmetricController = GetSymmetricController(symmetricAlgorithmName);

            if (!symmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboSymmetricAlgorithm.Focus();
                return;
            }

            ClearSymmetricEncryptionOutputFields();
            symmetricController.GenerateIV(GetValidSymmetricBlockSize());
            DisplayInitializationVector(symmetricController.IV);
        }

        private int GetValidSymmetricKeySize()
        {
            int keySize = int.Parse(txtSymmetricKeySize.Text, NumberStyles.Integer);
            return keySize;
        }

        private bool IsValidSymmetricKeySize()
        {
            try
            {
                int keySize = GetValidSymmetricKeySize();
                return symmetricController.IsValidKeySize(keySize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private int GetValidSymmetricBlockSize()
        {
            int blockSize = int.Parse(txtSymmetricBlockSize.Text, NumberStyles.Integer);
            return blockSize;
        }

        private bool IsValidBlockSize()
        {
            try
            {
                int blockSize = GetValidSymmetricBlockSize();
                return symmetricController.IsValidBlockSize(blockSize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidateSymmetricEncryptionControls()
        {
            string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
            SymmetricController symmetricController = GetSymmetricController(symmetricAlgorithmName);

            if (!symmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a symmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboSymmetricAlgorithm.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSymmetricKeySize.Text))
            {
                MessageBox.Show("Please enter a key size!", "Warning", MessageBoxButtons.OK);
                txtAsymmetricKeySize.Focus();
                return false;
            }

            if (!IsValidSymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtSymmetricKeySize.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSymmetricBlockSize.Text))
            {
                MessageBox.Show("Please enter a block size!", "Warning", MessageBoxButtons.OK);
                txtAsymmetricKeySize.Focus();
                return false;
            }

            if (!IsValidBlockSize())
            {
                MessageBox.Show("Please enter a valid block size!", "Warning", MessageBoxButtons.OK);
                txtSymmetricBlockSize.Focus();
                return false;
            }

            if ((cboSymmetricCipherMode.SelectedIndex < 0) || (cboSymmetricCipherMode.SelectedIndex >= cboSymmetricCipherMode.Items.Count))
            {
                MessageBox.Show("Please select a cipher mode!", "Warning", MessageBoxButtons.OK);
                cboSymmetricCipherMode.Focus();
                return false;
            }

            if ((cboSymmetricPaddingMode.SelectedIndex < 0) || (cboSymmetricPaddingMode.SelectedIndex >= cboSymmetricPaddingMode.Items.Count))
            {
                MessageBox.Show("Please select a padding mode!", "Warning", MessageBoxButtons.OK);
                cboSymmetricPaddingMode.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSymmetricKey.Text))
            {
                MessageBox.Show("Please create a symmetric key!", "Warning", MessageBoxButtons.OK);
                btnCreateSymmetricKey.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSymmetricEncryptionInitializationVector.Text))
            {
                MessageBox.Show("Please create an initialization vector!", "Warning", MessageBoxButtons.OK);
                btnCreateInitializationVector.Focus();
                return false;
            }

            if ((cboSymmetricEncoding.SelectedIndex < 0) || (cboSymmetricEncoding.SelectedIndex >= cboSymmetricEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding!", "Warning", MessageBoxButtons.OK);
                cboSymmetricEncoding.Focus();
                return false;
            }

            return true;
        }
        
        private void btnEncryptSymmetrically_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateSymmetricEncryptionControls()) return;

                if (String.IsNullOrEmpty(txtInputToBeSymmetricallyEncrypted.Text))
                {
                    MessageBox.Show("Please enter a text to be encrypted!", "Warning", MessageBoxButtons.OK);
                    txtInputToBeSymmetricallyEncrypted.Focus();
                    return;
                }

                // symmetric encryption
                string cipherModeName = (string)cboSymmetricCipherMode.SelectedItem;
                string paddingModeName = (string)cboSymmetricPaddingMode.SelectedItem;
                string encodingName = (string)cboSymmetricEncoding.SelectedItem;
                byte[] key = Formatter.HexToBinary(txtSymmetricKey.Text);
                byte[] iv = Formatter.HexToBinary(txtSymmetricEncryptionInitializationVector.Text);
                int blockSize = GetValidSymmetricBlockSize();
                string textToBeEncrypted = txtInputToBeSymmetricallyEncrypted.Text;

                string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
                SymmetricController symmetricController = GetSymmetricController(symmetricAlgorithmName);

                byte[] encryptedBytes = symmetricController.Encrypt(cipherModeName, paddingModeName, encodingName, key, iv, blockSize, textToBeEncrypted);

                // display results
                string encryptedText = Formatter.BinaryToHex(encryptedBytes);

                txtSymmetricallyEncryptedValue.Text = encryptedText;
                txtEncryptedValueSize.Text = encryptedBytes.Length.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDecryptSymmetrically_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateSymmetricEncryptionControls()) return;

                if (String.IsNullOrEmpty(txtSymmetricallyEncryptedValue.Text))
                {
                    MessageBox.Show("Please encrypt first!", "Warning", MessageBoxButtons.OK);
                    btnEncryptSymmetrically.Focus();
                    return;
                }

                // symmetric decryption properties
                string cipherModeName = (string)cboSymmetricCipherMode.SelectedItem;
                string paddingModeName = (string)cboSymmetricPaddingMode.SelectedItem;
                string encodingName = (string)cboSymmetricEncoding.SelectedItem;
                byte[] key = Formatter.HexToBinary(txtSymmetricKey.Text);
                byte[] iv = Formatter.HexToBinary(txtSymmetricEncryptionInitializationVector.Text);
                int blockSize = GetValidSymmetricBlockSize();
                byte[] textToBeDecrypted = Formatter.HexToBinary(txtSymmetricallyEncryptedValue.Text);

                string symmetricAlgorithmName = (string)cboSymmetricAlgorithm.SelectedItem;
                SymmetricController symmetricController = GetSymmetricController(symmetricAlgorithmName);

                string decryptedText = symmetricController.Decrypt(cipherModeName, paddingModeName, encodingName, key, iv, blockSize, textToBeDecrypted);

                // display results
                txtSymmetricallyDecryptedValue.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

    }
}
