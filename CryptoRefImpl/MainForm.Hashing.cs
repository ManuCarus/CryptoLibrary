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
        private void PopulateHashingControls()
        {
            // cboHashAlgorithm
            foreach (string hashAlgorithm in HashController.cHashAlgorithms) cboHashAlgorithm.Items.Add(hashAlgorithm);
            if (cboHashAlgorithm.Items.Count > 0) cboHashAlgorithm.SelectedIndex = 0;

            // cboHashEncoding
            cboHashEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboHashEncoding.Items.Add(encoding.WebName);
            }
            cboHashEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void ClearHashingOutputFields()
        {
            txtMessageDigest.Text = String.Empty;
            txtDigestSize.Text = String.Empty;
        }

        private void btnChooseFileToBeHashed_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rdoHashingFileToBeHashed.Checked = true;
                txtFileToBeHashed.Text = dlg.FileName;
                ClearHashingOutputFields();
            }
        }

        private void cboHashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearHashingOutputFields();
        }

        private void cboHashEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearHashingOutputFields();
        }

        private void txtInputToBeHashed_TextChanged(object sender, EventArgs e)
        {
            ClearHashingOutputFields();
            rdoHashingTextToBeHashed.Checked = true;
        }

        private void txtFileToBeHashed_TextChanged(object sender, EventArgs e)
        {
            ClearHashingOutputFields();
            rdoHashingFileToBeHashed.Checked = true;
        }

        private bool ValidateHashControls()
        {
            if ((cboHashAlgorithm.SelectedIndex < 0) || (cboHashAlgorithm.SelectedIndex >= cboHashAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a hash algorithm first!", "Warning", MessageBoxButtons.OK);
                cboHashAlgorithm.Focus();
                return false;
            }

            if ((cboHashEncoding.SelectedIndex < 0) || (cboHashEncoding.SelectedIndex >= cboHashEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding first!", "Warning", MessageBoxButtons.OK);
                cboHashEncoding.Focus();
                return false;
            }

            if (rdoHashingTextToBeHashed.Checked)
            {
                if (String.IsNullOrEmpty(txtTextToBeHashed.Text))
                {
                    MessageBox.Show("Please enter a text to be hashed!", "Warning", MessageBoxButtons.OK);
                    txtTextToBeHashed.Focus();
                    return false;
                }
            }
            else if (rdoHashingFileToBeHashed.Checked)
            {
                if (String.IsNullOrEmpty(txtFileToBeHashed.Text))
                {
                    MessageBox.Show("Please select a file to be hashed!", "Warning", MessageBoxButtons.OK);
                    txtFileToBeHashed.Focus();
                    return false;
                }

                if (!File.Exists(txtFileToBeHashed.Text))
                {
                    MessageBox.Show("The file does not exist!", "Warning", MessageBoxButtons.OK);
                    txtFileToBeHashed.Focus();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Please check what to hash!", "Warning", MessageBoxButtons.OK);
                rdoHashingTextToBeHashed.Focus();
                return false;
            }

            return true;
        }

        private void btnHashInput_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;

            try
            {
                // validation
                if (!ValidateHashControls()) return;

                string algorithmName = (string)cboHashAlgorithm.SelectedItem;
                string encodingName = (string)cboHashEncoding.SelectedItem;
                string textToBeHashed = txtTextToBeHashed.Text;
                string filename = txtFileToBeHashed.Text;

                HashController hashController = new HashController(algorithmName, encodingName);

                if (!hashController.IsKnownAlgorithm)
                {
                    MessageBox.Show("Please select a hash algorithm!", "Warning", MessageBoxButtons.OK);
                    cboHashAlgorithm.Focus();
                    return;
                }

                // hashing
                byte[] digest;

                if (rdoHashingTextToBeHashed.Checked)
                {
                    digest = hashController.Hash(textToBeHashed);
                }
                else if (rdoHashingFileToBeHashed.Checked)
                {
                    fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    digest = hashController.Hash(fileStream);
                }
                else
                {
                    throw new Exception("hash input not set");
                }
                
                DisplayDigest(digest);
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

        private void DisplayDigest(byte[] digest)
        {
            string messageDigest = Formatter.BinaryToHex(digest);
            int digestLength = digest.Length * 8; // bits

            txtMessageDigest.Text = messageDigest;
            txtDigestSize.Text = digestLength.ToString();
        }

    }
}
