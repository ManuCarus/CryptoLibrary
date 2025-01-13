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
using System.Windows.Forms;
using System.Text;
using CryptoLibrary.Controller;

namespace CryptoSamples.View
{
    partial class MainForm
    {
        private void PopulateSaltedHashingControls()
        {
            // cboSaltedHashAlgorithm
            foreach (string hashAlgorithm in SaltedHashController.cHashAlgorithms) cboSaltedHashAlgorithm.Items.Add(hashAlgorithm);
            if (cboSaltedHashAlgorithm.Items.Count > 0) cboSaltedHashAlgorithm.SelectedIndex = 0;

            // cboSaltedHashEncoding
            cboSaltedHashEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboSaltedHashEncoding.Items.Add(encoding.WebName);
            }
            cboSaltedHashEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void ClearSaltedHashingOutputFields()
        {
            txtUnsaltedHash.Text = String.Empty;
            txtRandomSalt.Text = String.Empty;
            txtSaltedHash.Text = String.Empty;
            txtSaltedMessageDigest.Text = String.Empty;
            txtSaltedDigestSize.Text = String.Empty;
        }

        private void btnChooseFileToBeSaltedHashed_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rdoHashingFileToBeHashed.Checked = true;
                txtFileToBeSaltedHashed.Text = dlg.FileName;
                ClearSaltedHashingOutputFields();
            }
        }

        private void cboSaltedHashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSaltedHashingOutputFields();
        }

        private void cboSaltedHashEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSaltedHashingOutputFields();
        }

        private void txtTextToBeSaltedHashed_TextChanged(object sender, EventArgs e)
        {
            ClearSaltedHashingOutputFields();
            rdoTextToBeSaltedHashed.Checked = true;
        }

        private void txtFileToBeSaltedHashed_TextChanged(object sender, EventArgs e)
        {
            ClearSaltedHashingOutputFields();
            rdoFileToBeSaltedHashed.Checked = true;
        }

        private bool ValidateSaltedHashControls()
        {
            if ((cboSaltedHashAlgorithm.SelectedIndex < 0) || (cboSaltedHashAlgorithm.SelectedIndex >= cboSaltedHashAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a hash algorithm first!", "Warning", MessageBoxButtons.OK);
                cboSaltedHashAlgorithm.Focus();
                return false;
            }

            if ((cboSaltedHashEncoding.SelectedIndex < 0) || (cboSaltedHashEncoding.SelectedIndex >= cboSaltedHashEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding first!", "Warning", MessageBoxButtons.OK);
                cboSaltedHashEncoding.Focus();
                return false;
            }

            if (rdoTextToBeSaltedHashed.Checked)
            {
                if (String.IsNullOrEmpty(txtTextToBeSaltedHashed.Text))
                {
                    MessageBox.Show("Please enter a text to be hashed!", "Warning", MessageBoxButtons.OK);
                    txtTextToBeSaltedHashed.Focus();
                    return false;
                }
            }
            else if (rdoFileToBeSaltedHashed.Checked)
            {
                if (String.IsNullOrEmpty(txtFileToBeSaltedHashed.Text))
                {
                    MessageBox.Show("Please select a file to be hashed!", "Warning", MessageBoxButtons.OK);
                    txtFileToBeSaltedHashed.Focus();
                    return false;
                }

                if (!File.Exists(txtFileToBeSaltedHashed.Text))
                {
                    MessageBox.Show("The file does not exist!", "Warning", MessageBoxButtons.OK);
                    txtFileToBeSaltedHashed.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please check what to hash!", "Warning", MessageBoxButtons.OK);
                rdoTextToBeSaltedHashed.Focus();
                return false;
            }

            return true;
        }


        private void btnSaltedHashInput_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;

            try
            {
                // validation
                if (!ValidateSaltedHashControls()) return;

                string algorithmName = (string)cboSaltedHashAlgorithm.SelectedItem;
                string encodingName = (string)cboSaltedHashEncoding.SelectedItem;
                string textToBeSaltedHashed = txtTextToBeSaltedHashed.Text;
                string filename = txtFileToBeSaltedHashed.Text;

                SaltedHashController saltedHashController = new SaltedHashController(algorithmName, encodingName);

                if (!saltedHashController.IsKnownAlgorithm)
                {
                    MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                    cboSaltedHashAlgorithm.Focus();
                    return;
                }

                // salted hashing
                byte[] unsaltedHash = null;
                byte[] salt = null;
                byte[] saltedHash = null;
                byte[] saltedHashAndSalt;

                if (rdoTextToBeSaltedHashed.Checked)
                {
                    saltedHashAndSalt = saltedHashController.Hash(textToBeSaltedHashed, out unsaltedHash, out salt, out saltedHash);
                }
                else if (rdoFileToBeSaltedHashed.Checked)
                {
                    fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    saltedHashAndSalt = saltedHashController.Hash(fileStream, out unsaltedHash, out salt, out saltedHash);
                }
                else
                {
                    throw new Exception("salted hash input not set");
                }

                DisplaySaltedHash(unsaltedHash, salt, saltedHash);
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

        private void DisplaySaltedHash(byte[] unsaltedHash, byte[] salt, byte[] saltedHash)
        {
            string unsaltedHashHex = Formatter.BinaryToHex(unsaltedHash);
            string saltHex = Formatter.BinaryToHex(salt);
            string saltedHashHex = Formatter.BinaryToHex(saltedHash);

            byte[] saltedHashAndSalt = new byte[saltedHash.Length + salt.Length];
            saltedHash.CopyTo(saltedHashAndSalt, 0);
            salt.CopyTo(saltedHashAndSalt, saltedHash.Length);

            string saltedHashAndSaltHex = Formatter.BinaryToHex(saltedHashAndSalt);

            int saltedMessageDigestLength = saltedHashAndSalt.Length * 8; // bits

            txtUnsaltedHash.Text = unsaltedHashHex;
            txtRandomSalt.Text = saltHex;
            txtSaltedHash.Text = saltedHashHex;
            txtSaltedMessageDigest.Text = saltedHashAndSaltHex;
            txtSaltedDigestSize.Text = saltedMessageDigestLength.ToString();
        }


    }
}
