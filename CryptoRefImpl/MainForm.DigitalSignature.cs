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
        private SignatureController signatureController = null;

        // digital signature controller creator
        private SignatureController GetSignatureController(string signatureAlgorithmName, string hashAlgorithmName)
        {
            if (signatureController == null) signatureController = new SignatureController(signatureAlgorithmName, hashAlgorithmName);
            else if (!signatureController.SignatureAlgorithmName.Equals(signatureAlgorithmName) ||
                     !signatureController.HashAlgorithmName.Equals(hashAlgorithmName)) signatureController = new SignatureController(signatureAlgorithmName, hashAlgorithmName);

            return signatureController;
        }

        private void PopulateSignatureControls()
        {
            // cboDigitalSignatureAlgorithm
            foreach (string algorithm in SignatureController.cSignatureAlgorithms) cboDigitalSignatureAlgorithm.Items.Add(algorithm);
            if (cboDigitalSignatureAlgorithm.Items.Count > 0) cboDigitalSignatureAlgorithm.SelectedIndex = 0;
            PopulateSignatureHashAlgorithms();
            ChangeSignatureAlgorithm();

            // cboDigitalSignatureEncoding
            cboDigitalSignatureEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboDigitalSignatureEncoding.Items.Add(encoding.WebName);
            }
            cboDigitalSignatureEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void PopulateSignatureHashAlgorithms()
        {
            string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
            string[] hashAlgorithms;

            if (signatureAlgorithmName.Equals(SignatureController.cDsa)) hashAlgorithms = SignatureController.cDsaHashAlgorithms;
            else if (signatureAlgorithmName.Equals(SignatureController.cRsa)) hashAlgorithms = SignatureController.cRsaHashAlgorithms;
            else throw new Exception("invalid signature algorithm");

            cboDigitalSignatureHashAlgorithm.Items.Clear();
            foreach (string algorithm in hashAlgorithms) cboDigitalSignatureHashAlgorithm.Items.Add(algorithm);
            if (cboDigitalSignatureHashAlgorithm.Items.Count > 0) cboDigitalSignatureHashAlgorithm.SelectedIndex = 0;
            ChangeSignatureHashAlgorithm();
        }

        private void ClearSignatureOutputFields()
        {
            txtDigitalSignatureResult.Text = String.Empty;
            txtDigitalSignatureSize.Text = String.Empty;
            txtDigitalSignatureVerification.Text = String.Empty;
        }

        private void cboDigitalSignatureAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSignatureHashAlgorithms();
            ChangeSignatureHashAlgorithm();
        }

        private void cboDigitalSignatureHashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSignatureHashAlgorithm();
        }

        private void txtDigitalSignatureKeySize_TextChanged(object sender, EventArgs e)
        {
            txtDigitalSignatureKeyXml.Text = String.Empty;
            ClearSignatureOutputFields();
        }
        
        private void cboDigitalSignatureEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSignatureOutputFields();
        }

        private void txtDigitalSignatureTextToBeSigned_TextChanged(object sender, EventArgs e)
        {
            ClearSignatureOutputFields();
            rdoDigitalSignatureTextToBeSigned.Checked = true;
        }

        private void txtDigitalSignatureFileToBeSigned_TextChanged(object sender, EventArgs e)
        {
            ClearSignatureOutputFields();
            rdoDigitalSignatureFileToBeSigned.Checked = true;
        }

        private void btnDigitalSignatureChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rdoDigitalSignatureFileToBeSigned.Checked = true;
                txtDigitalSignatureFileToBeSigned.Text = dlg.FileName;
                ClearSignatureOutputFields();
            }
        }

        private void ChangeSignatureAlgorithm()
        {
            // clear digital signature algorithm properties
            txtDigitalSignatureKeySize.Text = String.Empty;
            txtDigitalSignatureKeyExchangeAlgorithm.Text = String.Empty;
            txtDigitalSignatureSignatureAlgorithm.Text = String.Empty;
            txtDigitalSignatureKeyXml.Text = String.Empty;

            ClearSignatureOutputFields();

            // validation
            if ((cboDigitalSignatureAlgorithm.SelectedIndex < 0) || (cboDigitalSignatureAlgorithm.SelectedIndex >= cboDigitalSignatureAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a signature algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureAlgorithm.Focus();
                return;
            }

            if (cboDigitalSignatureHashAlgorithm.Items.Count == 0) return; // still on init dialog. wait for cboDigitalSignatureHashAlgorithm to be populated (and set to default entry)

            if ((cboDigitalSignatureHashAlgorithm.SelectedIndex < 0) || (cboDigitalSignatureHashAlgorithm.SelectedIndex >= cboDigitalSignatureHashAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureHashAlgorithm.Focus();
                return;
            }

            // create controller with new algorithm
            string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
            string hashAlgorithmName = (string)cboDigitalSignatureHashAlgorithm.SelectedItem;

            SignatureController signatureController = GetSignatureController(signatureAlgorithmName, hashAlgorithmName);

            if (!signatureController.IsKnownSignatureAlgorithm)
            {
                MessageBox.Show("Please select a signature algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureAlgorithm.Focus();
                return;
            }

            if (!signatureController.IsKnownHashAlgorithm)
            {
                MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureHashAlgorithm.Focus();
                return;
            }

            // txtDigitalSignatureKeySize
            txtDigitalSignatureKeySize.Text = signatureController.KeySize.ToString();

            // lblDigitalSignatureKeySizeBits
            StringBuilder legalKeySizes = new StringBuilder();
            foreach (KeySizes keySizes in signatureController.LegalKeySizes) legalKeySizes.Append(String.Format(cKeySizeFormat, keySizes.MinSize.ToString(), keySizes.MaxSize.ToString(), keySizes.SkipSize.ToString()) + ",");
            legalKeySizes.Remove(legalKeySizes.Length - 1, 1);
            lblDigitalSignatureKeySizeBits.Text = legalKeySizes.ToString();

            // txtDigitalSignatureKeyExchangeAlgorithm
            txtDigitalSignatureKeyExchangeAlgorithm.Text = signatureController.KeyExchangeAlgorithm;

            // txtDigitalSignatureSignatureAlgorithm
            txtDigitalSignatureSignatureAlgorithm.Text = signatureController.SignAlgorithm;

            // txtDigitalSignatureKeyXml
            DisplaySignatureKey(signatureController.KeyXml);
        }

        private void ChangeSignatureHashAlgorithm()
        {
            // clear digital signature algorithm properties
            txtDigitalSignatureKeySize.Text = String.Empty;
            txtDigitalSignatureKeyExchangeAlgorithm.Text = String.Empty;
            txtDigitalSignatureSignatureAlgorithm.Text = String.Empty;
            txtDigitalSignatureKeyXml.Text = String.Empty;

            ClearSignatureOutputFields();

            // validation
            if ((cboDigitalSignatureAlgorithm.SelectedIndex < 0) || (cboDigitalSignatureAlgorithm.SelectedIndex >= cboDigitalSignatureAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a signature algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureAlgorithm.Focus();
                return;
            }

            if (cboDigitalSignatureHashAlgorithm.Items.Count == 0) return; // still on init dialog. wait for cboDigitalSignatureHashAlgorithm to be populated (and set to default entry)

            if ((cboDigitalSignatureHashAlgorithm.SelectedIndex < 0) || (cboDigitalSignatureHashAlgorithm.SelectedIndex >= cboDigitalSignatureHashAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureHashAlgorithm.Focus();
                return;
            }

            // create controller with new algorithm
            string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
            string hashAlgorithmName = (string)cboDigitalSignatureHashAlgorithm.SelectedItem;

            SignatureController signatureController = GetSignatureController(signatureAlgorithmName, hashAlgorithmName);

            if (!signatureController.IsKnownSignatureAlgorithm)
            {
                MessageBox.Show("Please select a signature algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureAlgorithm.Focus();
                return;
            }

            if (!signatureController.IsKnownHashAlgorithm)
            {
                MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureHashAlgorithm.Focus();
                return;
            }

            // txtDigitalSignatureKeySize
            txtDigitalSignatureKeySize.Text = signatureController.KeySize.ToString();

            // lblDigitalSignatureKeySizeBits
            StringBuilder legalKeySizes = new StringBuilder();
            foreach (KeySizes keySizes in signatureController.LegalKeySizes) legalKeySizes.Append(String.Format(cKeySizeFormat, keySizes.MinSize.ToString(), keySizes.MaxSize.ToString(), keySizes.SkipSize.ToString()) + ",");
            legalKeySizes.Remove(legalKeySizes.Length - 1, 1);
            lblDigitalSignatureKeySizeBits.Text = legalKeySizes.ToString();

            // txtDigitalSignatureKeyExchangeAlgorithm
            txtDigitalSignatureKeyExchangeAlgorithm.Text = signatureController.KeyExchangeAlgorithm;

            // txtDigitalSignatureSignatureAlgorithm
            txtDigitalSignatureSignatureAlgorithm.Text = signatureController.SignAlgorithm;

            // txtDigitalSignatureKeyXml
            DisplaySignatureKey(signatureController.KeyXml);
        }

        private void txtDigitalSignatureKeyXml_TextChanged(object sender, EventArgs e)
        {
            ClearSignatureOutputFields();
        }

        private void DisplaySignatureKey(string xmlKey)
        {
            string formattedXmlKey = Formatter.FormatXmlKey(xmlKey);
            txtDigitalSignatureKeyXml.Text = formattedXmlKey;
        }


        private void btnDigitalSignatureCreateKey_Click(object sender, EventArgs e)
        {
            string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
            string hashAlgorithmName = (string)cboDigitalSignatureHashAlgorithm.SelectedItem;

            SignatureController signatureController = GetSignatureController(signatureAlgorithmName, hashAlgorithmName);

            if (!signatureController.IsKnownSignatureAlgorithm)
            {
                MessageBox.Show("Please select a signature algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureAlgorithm.Focus();
                return;
            }

            if (!signatureController.IsKnownHashAlgorithm)
            {
                MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureHashAlgorithm.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtDigitalSignatureKeySize.Text))
            {
                MessageBox.Show("Please enter a key size!", "Warning", MessageBoxButtons.OK);
                txtDigitalSignatureKeySize.Focus();
                return;
            }

            if (!IsValidSignatureKeySize())
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtDigitalSignatureKeySize.Focus();
                return;
            } 

            ClearSignatureOutputFields();
            signatureController.GenerateKey(GetValidSignatureKeySize());
            DisplaySignatureKey(signatureController.KeyXml);
        }

        private int GetValidSignatureKeySize()
        {
            int keySize = int.Parse(txtDigitalSignatureKeySize.Text, NumberStyles.Integer);
            return keySize;
        }

        private bool IsValidSignatureKeySize()
        {
            try
            {
                int keySize = GetValidSignatureKeySize();
                return signatureController.IsValidKeySize(keySize);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidateSignatureControls()
        {
            string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
            string hashAlgorithmName = (string)cboDigitalSignatureHashAlgorithm.SelectedItem;

            SignatureController signatureController = GetSignatureController(signatureAlgorithmName, hashAlgorithmName);

            if (!signatureController.IsKnownSignatureAlgorithm)
            {
                MessageBox.Show("Please select a signature algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureAlgorithm.Focus();
                return false;
            }

            if (!signatureController.IsKnownHashAlgorithm)
            {
                MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureHashAlgorithm.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtDigitalSignatureKeySize.Text))
            {
                MessageBox.Show("Please enter a key size!", "Warning", MessageBoxButtons.OK);
                txtDigitalSignatureKeySize.Focus();
                return false;
            }

            if (!IsValidSignatureKeySize())
            {
                MessageBox.Show("Please enter a valid key size!", "Warning", MessageBoxButtons.OK);
                txtDigitalSignatureKeySize.Focus();
                return false;
            } 
            
            if (String.IsNullOrEmpty(txtDigitalSignatureKeyXml.Text))
            {
                MessageBox.Show("Please create a signature key!", "Warning", MessageBoxButtons.OK);
                btnDigitalSignatureCreateKey.Focus();
                return false;
            }

            if ((cboDigitalSignatureEncoding.SelectedIndex < 0) || (cboDigitalSignatureEncoding.SelectedIndex >= cboDigitalSignatureEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding!", "Warning", MessageBoxButtons.OK);
                cboDigitalSignatureEncoding.Focus();
                return false;
            }

            if (rdoDigitalSignatureTextToBeSigned.Checked)
            {
                if (String.IsNullOrEmpty(txtDigitalSignatureTextToBeSigned.Text))
                {
                    MessageBox.Show("Please enter a text to be signed!", "Warning", MessageBoxButtons.OK);
                    txtDigitalSignatureTextToBeSigned.Focus();
                    return false;
                }
            }
            else if (rdoDigitalSignatureFileToBeSigned.Checked)
            {
                if (String.IsNullOrEmpty(txtDigitalSignatureFileToBeSigned.Text))
                {
                    MessageBox.Show("Please choose a file to be signed!", "Warning", MessageBoxButtons.OK);
                    txtDigitalSignatureFileToBeSigned.Focus();
                    return false;
                }

                if (!File.Exists(txtDigitalSignatureFileToBeSigned.Text))
                {
                    MessageBox.Show("The file does not exist!", "Warning", MessageBoxButtons.OK);
                    txtDigitalSignatureFileToBeSigned.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please check what to sign!", "Warning", MessageBoxButtons.OK);
                rdoDigitalSignatureTextToBeSigned.Focus();
                return false;
            }

            return true;
        }

        private void btnDigitalSignatureSignText_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;

            try
            {
                ClearSignatureOutputFields();

                // validation
                if (!ValidateSignatureControls()) return;

                // signing
                string keyXml = txtDigitalSignatureKeyXml.Text;
                string encodingName = (string)cboDigitalSignatureEncoding.SelectedItem;
                string textToBeSigned = txtDigitalSignatureTextToBeSigned.Text;
                string fileToBeSigned = txtDigitalSignatureFileToBeSigned.Text;

                string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
                string hashAlgorithmName = (string)cboDigitalSignatureHashAlgorithm.SelectedItem;

                SignatureController signatureController = GetSignatureController(signatureAlgorithmName, hashAlgorithmName);
                byte[] signature;

                if (rdoDigitalSignatureTextToBeSigned.Checked)
                {
                    signature = signatureController.Sign(encodingName, keyXml, textToBeSigned);
                }
                else if (rdoDigitalSignatureFileToBeSigned.Checked)
                {
                    fileStream = new FileStream(fileToBeSigned, FileMode.Open, FileAccess.Read);
                    signature = signatureController.Sign(encodingName, keyXml, fileStream);
                }
                else
                {
                    throw new Exception("sign input not set!");
                }

                // display results
                string signatureText = Formatter.BinaryToHex(signature);

                txtDigitalSignatureResult.Text = signatureText;
                txtDigitalSignatureSize.Text = (signature.Length * 8).ToString();
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
            finally
            {
                if (fileStream != null) fileStream.Close();
            }
        }

        private void btnDigitalSignatureVerifyText_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;

            try
            {
                // validation
                if (!ValidateSignatureControls()) return;

                if (String.IsNullOrEmpty(txtDigitalSignatureResult.Text))
                {
                    MessageBox.Show("Please sign first!", "Warning", MessageBoxButtons.OK);
                    btnDigitalSignatureSignText.Focus();
                    return;
                }

                // signing
                string keyXml = txtDigitalSignatureKeyXml.Text;
                string encodingName = (string)cboDigitalSignatureEncoding.SelectedItem;
                string textToBeSigned = txtDigitalSignatureTextToBeSigned.Text;
                string fileToBeSigned = txtDigitalSignatureFileToBeSigned.Text;
                string signatureText = txtDigitalSignatureResult.Text;
                byte[] signature = Formatter.HexToBinary(signatureText);

                string signatureAlgorithmName = (string)cboDigitalSignatureAlgorithm.SelectedItem;
                string hashAlgorithmName = (string)cboDigitalSignatureHashAlgorithm.SelectedItem;

                SignatureController signatureController = GetSignatureController(signatureAlgorithmName, hashAlgorithmName);
                bool ok;

                if (rdoDigitalSignatureTextToBeSigned.Checked)
                {
                    ok = signatureController.Verify(encodingName, keyXml, textToBeSigned, signature);
                }
                else if (rdoDigitalSignatureFileToBeSigned.Checked)
                {
                    fileStream = new FileStream(fileToBeSigned, FileMode.Open, FileAccess.Read);
                    ok = signatureController.Verify(encodingName, keyXml, fileStream, signature);
                }
                else
                {
                    throw new Exception("sign input not set!");
                }

                // display results
                txtDigitalSignatureVerification.Text = ok.ToString();
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
            finally
            {
                if (fileStream != null) fileStream.Close();
            }
        }

    }
}
