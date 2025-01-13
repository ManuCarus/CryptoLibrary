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
        private AsymmetricController asymmetricController = null;

        // asymmetric controller creator
        private AsymmetricController GetAsymmetricController(string asymmetricAlgorithmName)
        {
            if (asymmetricController == null) asymmetricController = new AsymmetricController(asymmetricAlgorithmName);
            else if (!asymmetricController.Algorithm.Equals(asymmetricAlgorithmName)) asymmetricController = new AsymmetricController(asymmetricAlgorithmName);

            return asymmetricController;
        }

        private void PopulateAsymmetricEncryptionControls()
        {
            // cboAsymmetricAlgorithm
            foreach (string asymmetricAlgorithm in AsymmetricController.cAsymmetricAlgorithms) cboAsymmetricAlgorithm.Items.Add(asymmetricAlgorithm);
            if (cboAsymmetricAlgorithm.Items.Count > 0) cboAsymmetricAlgorithm.SelectedIndex = 0;

            ChangeAsymmetricAlgorithm();

            // cboAsymmetricEncoding
            cboAsymmetricEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboAsymmetricEncoding.Items.Add(encoding.WebName);
            }
            cboAsymmetricEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void ClearAsymmetricEncryptionOutputFields()
        {
            txtAsymmetricallyEncryptedValue.Text = String.Empty;
            txtAsymmetricallyEncryptedValueSize.Text = String.Empty;
            txtAsymmetricallyDecryptedValue.Text = String.Empty;
        }

        private void cboAsymmetricAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeAsymmetricAlgorithm();
        }

        private void cboAsymmetricEncryptionPaddingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAsymmetricEncryptionOutputFields();
        }

        private void cboAsymmetricEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAsymmetricEncryptionOutputFields();
        }

        private void txtAsymmetricTextToBeEncrypted_TextChanged(object sender, EventArgs e)
        {
            ClearAsymmetricEncryptionOutputFields();
        }

        private void ChangeAsymmetricAlgorithm()
        {
            // clear asymmetric algorithm properties
            txtAsymmetricKeySize.Text = String.Empty;
            txtAsymmetricKeyExchangeAlgorithm.Text = String.Empty;
            txtPublicPrivateKey.Text = String.Empty;
            ClearAsymmetricEncryptionOutputFields();

            // validation
            if ((cboAsymmetricAlgorithm.SelectedIndex < 0) || (cboAsymmetricAlgorithm.SelectedIndex >= cboAsymmetricAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboAsymmetricAlgorithm.Focus();
                return;
            }

            // create controller with new algorithm
            string asymmetricAlgorithmName = (string)cboAsymmetricAlgorithm.SelectedItem;
            AsymmetricController asymmetricController = GetAsymmetricController(asymmetricAlgorithmName);

            if (!asymmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboAsymmetricAlgorithm.Focus();
                return;
            }

            // txtAsymmetricKeySize
            txtAsymmetricKeySize.Text = asymmetricController.KeySize.ToString();

            // lblAsymmetricKeySizeBits
            StringBuilder legalKeySizes = new StringBuilder();
            foreach (KeySizes keySizes in asymmetricController.LegalKeySizes) legalKeySizes.Append(String.Format(cKeySizeFormat, keySizes.MinSize.ToString(), keySizes.MaxSize.ToString(), keySizes.SkipSize.ToString()) + ",");            
            legalKeySizes.Remove(legalKeySizes.Length - 1, 1);
            lblAsymmetricKeySizeBits.Text = legalKeySizes.ToString();

            // cboAsymmetricEncryptionPaddingMode
            cboAsymmetricEncryptionPaddingMode.Items.Clear();
            foreach (string paddingMode in AsymmetricController.cPaddingModes) cboAsymmetricEncryptionPaddingMode.Items.Add(paddingMode);
            if (cboAsymmetricEncryptionPaddingMode.Items.Count > 0) cboAsymmetricEncryptionPaddingMode.SelectedIndex = 0;

            // txtAsymmetricKeyExchangeAlgorithm
            txtAsymmetricKeyExchangeAlgorithm.Text = asymmetricController.KeyExchangeAlgorithm;

            // txtPublicPrivateKey
            DisplayAsymmetricKey(asymmetricController.KeyXml);
        }

        private void txtAsymmetricKeySize_TextChanged(object sender, EventArgs e)
        {
            txtPublicPrivateKey.Text = String.Empty;
            ClearAsymmetricEncryptionOutputFields();
        }

        private void txtPublicPrivateKey_TextChanged(object sender, EventArgs e)
        {
            ClearAsymmetricEncryptionOutputFields();
        }

        private void DisplayAsymmetricKey(string xmlKey)
        {
            string formattedXmlKey = Formatter.FormatXmlKey(xmlKey);
            txtPublicPrivateKey.Text = formattedXmlKey;
        }

        private void btnCreateAsymmetricKey_Click(object sender, EventArgs e)
        {
            string asymmetricAlgorithmName = (string)cboAsymmetricAlgorithm.SelectedItem;
            AsymmetricController asymmetricController = GetAsymmetricController(asymmetricAlgorithmName);

            if (!asymmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboAsymmetricAlgorithm.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtAsymmetricKeySize.Text))
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtAsymmetricKeySize.Focus();
                return;
            }

            if (!IsValidAsymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtAsymmetricKeySize.Focus();
                return;
            }

            ClearAsymmetricEncryptionOutputFields();
            asymmetricController.GenerateKey(GetValidAsymmetricKeySize());
            DisplayAsymmetricKey(asymmetricController.KeyXml);
        }

        private int GetValidAsymmetricKeySize()
        {
            int keySize = int.Parse(txtAsymmetricKeySize.Text, NumberStyles.Integer);
            return keySize;
        }

        private bool IsValidAsymmetricKeySize()
        {
            try
            {
                int keySize = GetValidAsymmetricKeySize();
                return asymmetricController.IsValidKeySize(keySize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidateAsymmetricEncryptionControls()
        {
            string asymmetricAlgorithmName = (string)cboAsymmetricAlgorithm.SelectedItem;
            AsymmetricController asymmetricController = GetAsymmetricController(asymmetricAlgorithmName);

            if (!asymmetricController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an asymmetric algorithm!", "Warning", MessageBoxButtons.OK);
                cboAsymmetricAlgorithm.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtAsymmetricKeySize.Text))
            {
                MessageBox.Show("Please enter a key size!", "Warning", MessageBoxButtons.OK);
                txtAsymmetricKeySize.Focus();
                return false;
            }

            if (!IsValidAsymmetricKeySize())
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtSymmetricKeySize.Focus();
                return false;
            }

            if ((cboAsymmetricEncryptionPaddingMode.SelectedIndex < 0) || (cboAsymmetricEncryptionPaddingMode.SelectedIndex >= cboAsymmetricEncryptionPaddingMode.Items.Count))
            {
                MessageBox.Show("Please select a padding mode!", "Warning", MessageBoxButtons.OK);
                cboAsymmetricEncryptionPaddingMode.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtPublicPrivateKey.Text))
            {
                MessageBox.Show("Please create an asymmetric key!", "Warning", MessageBoxButtons.OK);
                btnCreateAsymmetricKey.Focus();
                return false;
            }

            if ((cboAsymmetricEncoding.SelectedIndex < 0) || (cboAsymmetricEncoding.SelectedIndex >= cboAsymmetricEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding!", "Warning", MessageBoxButtons.OK);
                cboAsymmetricEncoding.Focus();
                return false;
            }

            return true;
        }

        private void btnEncryptAsymmetrically_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateAsymmetricEncryptionControls()) return;

                if (String.IsNullOrEmpty(txtAsymmetricTextToBeEncrypted.Text))
                {
                    MessageBox.Show("Please enter a text to be encrypted!", "Warning", MessageBoxButtons.OK);
                    txtAsymmetricTextToBeEncrypted.Focus();
                    return;
                }

                // asymmetric encryption
                string paddingModeName = (string)cboAsymmetricEncryptionPaddingMode.SelectedItem;
                string keyXml = txtPublicPrivateKey.Text;
                string encodingName = (string)cboAsymmetricEncoding.SelectedItem;
                string textToBeEncrypted = txtAsymmetricTextToBeEncrypted.Text;

                string asymmetricAlgorithmName = (string)cboAsymmetricAlgorithm.SelectedItem;
                AsymmetricController asymmetricController = GetAsymmetricController(asymmetricAlgorithmName);

                bool blnOAEP = (paddingModeName.Equals(AsymmetricController.cPaddingModeOAEP));
                byte[] encryptedBytes = asymmetricController.Encrypt(encodingName, keyXml, blnOAEP, textToBeEncrypted);

                // display results
                string encryptedText = Formatter.BinaryToHex(encryptedBytes);

                txtAsymmetricallyEncryptedValue.Text = encryptedText;
                txtAsymmetricallyEncryptedValueSize.Text = encryptedBytes.Length.ToString();
            }
            catch (CryptographicException cex)
            {
                if (cex.Message.Contains("Bad Length."))
                {
                    MessageBox.Show(cex.Message + "(Input to be encrypted is too long for the given key size!)", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAsymmetricallyDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateAsymmetricEncryptionControls()) return;

                if (String.IsNullOrEmpty(txtAsymmetricallyEncryptedValue.Text))
                {
                    MessageBox.Show("Please encrypt first!", "Warning", MessageBoxButtons.OK);
                    btnEncryptAsymmetrically.Focus();
                    return;
                }

                // asymmetric decryption properties
                string paddingModeName = (string)cboAsymmetricEncryptionPaddingMode.SelectedItem;
                string keyXml = txtPublicPrivateKey.Text;
                string encodingName = (string)cboAsymmetricEncoding.SelectedItem;
                byte[] textToBeDecrypted = Formatter.HexToBinary(txtAsymmetricallyEncryptedValue.Text);

                string asymmetricAlgorithmName = (string)cboAsymmetricAlgorithm.SelectedItem;
                AsymmetricController asymmetricController = GetAsymmetricController(asymmetricAlgorithmName);

                bool blnOAEP = (paddingModeName.Equals(AsymmetricController.cPaddingModeOAEP));
                byte[] decryptedBytes = asymmetricController.Decrypt(keyXml, blnOAEP, textToBeDecrypted);
                
                // conversion
                Encoding encoding = EncodingController.GetEncodingByName(encodingName);
                string decryptedText = encoding.GetString(decryptedBytes);

                // display results
                txtAsymmetricallyDecryptedValue.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

    }
}
