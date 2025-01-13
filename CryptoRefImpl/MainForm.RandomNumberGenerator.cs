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
using System.Windows.Forms;
using CryptoLibrary.Controller;

namespace CryptoSamples.View
{
    partial class MainForm
    {
        private void PopulateRandomNumberGeneratorControls()
        {
            // cboRngAlgorithm
            foreach (string rngAlgorithm in RandomNumberController.cRandomNumberGeneratorAlgorithms) cboRngAlgorithm.Items.Add(rngAlgorithm);
            if (cboRngAlgorithm.Items.Count > 0) cboRngAlgorithm.SelectedIndex = 0;
        }

        private void ClearRandomNumberGeneratorOutputFields()
        {
            txtRngGeneratedBytes.Text = String.Empty;
        }

        private void cboRngAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRandomNumberGeneratorOutputFields();
        }

        private void txtRngCountBytes_TextChanged(object sender, EventArgs e)
        {
            ClearRandomNumberGeneratorOutputFields();
        }

        private bool ValidateRandomNumberGeneratorControls()
        {
            if ((cboRngAlgorithm.SelectedIndex < 0) || (cboRngAlgorithm.SelectedIndex >= cboRngAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select a random number generator algorithm first!", "Warning", MessageBoxButtons.OK);
                cboRngAlgorithm.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtRngCountBytes.Text))
            {
                MessageBox.Show("Please enter a number of bytes to be generated!", "Warning", MessageBoxButtons.OK);
                txtRngCountBytes.Focus();
                return false;
            }

            int numBytes = 0;

            try
            {
                numBytes = int.Parse(txtRngCountBytes.Text, NumberStyles.Integer);
                if (numBytes <= 0) throw new FormatException("invalid number of bytes");
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid number of bytes!", "Warning", MessageBoxButtons.OK);
                txtRngCountBytes.Focus();
                return false;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Please enter a valid number of bytes!", "Warning", MessageBoxButtons.OK);
                txtRngCountBytes.Focus();
                return false;
            }

            return true;
        }

        private void btnRngGenerateBytes_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateRandomNumberGeneratorControls()) return;

                string algorithmName = (string)cboRngAlgorithm.SelectedItem;
                string numBytes = txtRngCountBytes.Text;
                int count = int.Parse(txtRngCountBytes.Text, NumberStyles.Integer);

                // random number generation
                byte[] bytes = RandomNumberController.GenerateBytes(count);
                DisplayBytes(bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void DisplayBytes(byte[] bytes)
        {
            string hexBytes = Formatter.BinaryToHex(bytes);
            txtRngGeneratedBytes.Text = hexBytes;
        }

    }
}
