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
using System.IO;
using System.Text;
using System.Windows.Forms;
using CryptoLibrary.Controller;

namespace CryptoSamples.View
{
    partial class MainForm
    {
        private void PopulateMessageAuthenticationCodeControls()
        {
            // cboMacAlgorithm
            foreach (string algorithm in MessageAuthenticationCodeController.cMacAlgorithms) cboMacAlgorithm.Items.Add(algorithm);
            if (cboMacAlgorithm.Items.Count > 0) cboMacAlgorithm.SelectedIndex = 0;

            // cboMacEncoding
            cboMacEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboMacEncoding.Items.Add(encoding.WebName);
            }
            cboMacEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void ClearMessageAuthenticationCodeOutputFields()
        {
            txtMacMessageDigest.Text = String.Empty;
            txtMacDigestSize.Text = String.Empty;
            txtMacAuthentication.Text = String.Empty;
        }

        private void cboMacAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMessageAuthenticationCodeOutputFields();
        }

        private void cboMacEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMessageAuthenticationCodeOutputFields();
        }

        private void txtMacSecretKey_TextChanged(object sender, EventArgs e)
        {
            ClearMessageAuthenticationCodeOutputFields();
        }

        private void txtMacTextToBeHashed_TextChanged(object sender, EventArgs e)
        {
            ClearMessageAuthenticationCodeOutputFields();
            rdoMacTextToBeHashed.Checked = true;
        }

        private void txtMacFileToBeHashed_TextChanged(object sender, EventArgs e)
        {
            ClearMessageAuthenticationCodeOutputFields();
            rdoMacFileToBeHashed.Checked = true;
        }

        private void btnMacChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rdoMacFileToBeHashed.Checked = true;
                txtMacFileToBeHashed.Text = dlg.FileName;
                ClearMessageAuthenticationCodeOutputFields();
            }
        }

        private bool ValidateMessageAuthenticationCodeControls()
        {
            if ((cboMacAlgorithm.SelectedIndex < 0) || (cboMacAlgorithm.SelectedIndex >= cboMacAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a message authentication code algorithm first!", "Warning", MessageBoxButtons.OK);
                cboMacAlgorithm.Focus();
                return false;
            }

            if ((cboMacEncoding.SelectedIndex < 0) || (cboMacEncoding.SelectedIndex >= cboMacEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding first!", "Warning", MessageBoxButtons.OK);
                cboMacEncoding.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtMacSecretKey.Text))
            {
                MessageBox.Show("Please enter a passphrase to authenticate the hash!", "Warning", MessageBoxButtons.OK);
                txtMacSecretKey.Focus();
                return false;
            }

            string macAlgorithmName = (string)cboMacAlgorithm.SelectedItem;
            string macKey = txtMacSecretKey.Text;

            if (macAlgorithmName.Equals(MessageAuthenticationCodeController.cMacTripleDes))
            {
                if ((macKey.Length != 16) && (macKey.Length != 24))
                {
                    MessageBox.Show("Invalid key size (must be 16 or 24)!", "Warning", MessageBoxButtons.OK);
                    txtMacSecretKey.Focus();
                    return false;
                }
            }

            if (rdoMacTextToBeHashed.Checked)
            {
                if (String.IsNullOrEmpty(txtMacTextToBeHashed.Text))
                {
                    MessageBox.Show("Please enter a text to be hashed!", "Warning", MessageBoxButtons.OK);
                    txtMacTextToBeHashed.Focus();
                    return false;
                }
            }
            else if (rdoMacFileToBeHashed.Checked)
            {
                if (String.IsNullOrEmpty(txtMacFileToBeHashed.Text))
                {
                    MessageBox.Show("Please select a file to be hashed!", "Warning", MessageBoxButtons.OK);
                    txtMacFileToBeHashed.Focus();
                    return false;
                }

                if (!File.Exists(txtMacFileToBeHashed.Text))
                {
                    MessageBox.Show("The file does not exist!", "Warning", MessageBoxButtons.OK);
                    txtMacFileToBeHashed.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please check what to hash!", "Warning", MessageBoxButtons.OK);
                rdoMacTextToBeHashed.Focus();
                return false;
            }

            return true;
        }

        private void btnMacHashText_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;

            try
            {
                ClearMessageAuthenticationCodeOutputFields();

                // validation
                if (!ValidateMessageAuthenticationCodeControls()) return;

                string algorithmName = (string)cboMacAlgorithm.SelectedItem;
                string encodingName = (string)cboMacEncoding.SelectedItem;
                string secretKey = txtMacSecretKey.Text;
                string message = txtMacTextToBeHashed.Text;
                string filename = txtMacFileToBeHashed.Text;

                MessageAuthenticationCodeController macController = new MessageAuthenticationCodeController(algorithmName, encodingName);

                if (!macController.IsKnownAlgorithm)
                {
                    MessageBox.Show("Please select a message authentication code algorithm!", "Warning", MessageBoxButtons.OK);
                    cboMacAlgorithm.Focus();
                    return;
                }

                // hashing
                byte[] digest;
                
                if (rdoMacTextToBeHashed.Checked)
                {
                    digest = macController.Hash(message, secretKey);
                }
                else if (rdoMacFileToBeHashed.Checked)
                {
                    fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    digest = macController.Hash(fileStream, secretKey);
                }
                else
                {
                    throw new Exception("hash input not set!");
                }

                DisplayMacDigest(digest);
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

        private void DisplayMacDigest(byte[] digest)
        {
            string messageDigest = Formatter.BinaryToHex(digest);
            int digestLength = digest.Length * 8; // bits

            txtMacMessageDigest.Text = messageDigest;
            txtMacDigestSize.Text = digestLength.ToString();
        }

        private void btnMacAuthenticateText_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;

            try
            {
                // validation
                if (!ValidateMessageAuthenticationCodeControls()) return;

                string algorithmName = (string)cboMacAlgorithm.SelectedItem;
                string encodingName = (string)cboMacEncoding.SelectedItem;
                string secretKey = txtMacSecretKey.Text;
                string message = txtMacTextToBeHashed.Text;
                string filename = txtMacFileToBeHashed.Text;
                string givenMacHex = txtMacMessageDigest.Text;

                MessageAuthenticationCodeController macController = new MessageAuthenticationCodeController(algorithmName, encodingName);

                if (!macController.IsKnownAlgorithm)
                {
                    MessageBox.Show("Please select a message authentication code algorithm!", "Warning", MessageBoxButtons.OK);
                    cboMacAlgorithm.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(txtMacMessageDigest.Text))
                {
                    MessageBox.Show("Please hash first!", "Warning", MessageBoxButtons.OK);
                    btnMacHashText.Focus();
                    return;
                }

                // hashing
                byte[] givenMac = Formatter.HexToBinary(givenMacHex);
                bool ok;

                if (rdoMacTextToBeHashed.Checked)
                {
                    ok = macController.Authenticate(message, secretKey, givenMac);
                }
                else if (rdoMacFileToBeHashed.Checked)
                {
                    fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    ok = macController.Authenticate(fileStream, secretKey, givenMac);
                }
                else
                {
                    throw new Exception("hash input not set!");
                }

                txtMacAuthentication.Text = ok.ToString();
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
