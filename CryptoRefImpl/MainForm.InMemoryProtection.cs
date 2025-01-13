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
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CryptoLibrary.Controller;

namespace CryptoSamples.View
{
    partial class MainForm
    {
        // private members
        private InMemoryController inMemoryController = null;

        // in-memory controller creator
        private InMemoryController GetInMemoryController(string inMemoryAlgorithmName)
        {
            if (inMemoryController == null) inMemoryController = new InMemoryController(inMemoryAlgorithmName);
            else if (!inMemoryController.Algorithm.Equals(inMemoryAlgorithmName)) inMemoryController = new InMemoryController(inMemoryAlgorithmName);

            return inMemoryController;
        }

        private void PopulateInMemoryProtectionControls()
        {
            // cboProtectionAlgorithm
            foreach (string algorithm in InMemoryController.cInMemoryAlgorithms) cboProtectionAlgorithm.Items.Add(algorithm);
            if (cboProtectionAlgorithm.Items.Count > 0) cboProtectionAlgorithm.SelectedIndex = 0;

            // cboProtectionScope
            PopulateProtectionScope();

            // cboProtectionEncoding
            cboProtectionEncoding.Items.Add(EncodingController.cDefaultEncoding);
            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                Encoding encoding = encodingInfo.GetEncoding();
                cboProtectionEncoding.Items.Add(encoding.WebName);
            }
            cboProtectionEncoding.SelectedItem = EncodingController.cDefaultEncoding;
        }

        private void PopulateProtectionScope()
        {
            cboProtectionScope.Items.Clear();

            if (cboProtectionAlgorithm.SelectedItem != null)
            {
                string protectionAlgorithm = (string)cboProtectionAlgorithm.SelectedItem;
                string[] scopeNames;

                if (protectionAlgorithm.Equals(InMemoryController.cProtectedMemory)) scopeNames = Enum.GetNames(typeof(MemoryProtectionScope));
                else if (protectionAlgorithm.Equals(InMemoryController.cProtectedData)) scopeNames = Enum.GetNames(typeof(DataProtectionScope));
                else throw new Exception("invalid protection scope");

                foreach (string scopeName in scopeNames) cboProtectionScope.Items.Add(scopeName);
                if (cboProtectionScope.Items.Count > 0) cboProtectionScope.SelectedIndex = 0;
            }
        }

        private void ClearInMemoryProtectionOutputFields()
        {
            txtProtectionRawData.Text = String.Empty;
            txtProtectedData.Text = String.Empty;
            txtUnprotectedData.Text = String.Empty;
        }


        private void cboProtectionAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeInMemoryProtectionAlgorithm();
        }

        private void ChangeInMemoryProtectionAlgorithm()
        {
            // clear output fields
            ClearInMemoryProtectionOutputFields();

            // validation
            if ((cboProtectionAlgorithm.SelectedIndex < 0) || (cboProtectionAlgorithm.SelectedIndex >= cboProtectionAlgorithm.Items.Count))
            {
                MessageBox.Show("Please select an in-memory protection algorithm!", "Warning", MessageBoxButtons.OK);
                cboProtectionAlgorithm.Focus();
                return;
            }

            // create controller with new algorithm
            string algorithmName = (string)cboProtectionAlgorithm.SelectedItem;
            InMemoryController inMemoryController = GetInMemoryController(algorithmName);

            if (!inMemoryController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select an in-memory protection algorithm!", "Warning", MessageBoxButtons.OK);
                cboProtectionAlgorithm.Focus();
                return;
            }

            PopulateProtectionScope();
        }


        private void cboProtectionScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInMemoryProtectionOutputFields();
        }

        private void cboProtectionEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInMemoryProtectionOutputFields();
        }

        private void txtTextToBeProtected_TextChanged(object sender, EventArgs e)
        {
            ClearInMemoryProtectionOutputFields();
        }

        private bool ValidateInMemoryProtectionControls()
        {
            string algorithmName = (string)cboProtectionAlgorithm.SelectedItem;
            InMemoryController inMemoryController = GetInMemoryController(algorithmName);

            if (!inMemoryController.IsKnownAlgorithm)
            {
                MessageBox.Show("Please select a protection algorithm!", "Warning", MessageBoxButtons.OK);
                cboProtectionAlgorithm.Focus();
                return false;
            }

            if ((cboProtectionScope.SelectedIndex < 0) || (cboProtectionScope.SelectedIndex >= cboProtectionScope.Items.Count))
            {
                MessageBox.Show("Please select a protection scope!", "Warning", MessageBoxButtons.OK);
                cboProtectionScope.Focus();
                return false;
            }

            if ((cboProtectionEncoding.SelectedIndex < 0) || (cboProtectionEncoding.SelectedIndex >= cboProtectionEncoding.Items.Count))
            {
                MessageBox.Show("Please select an encoding!", "Warning", MessageBoxButtons.OK);
                cboProtectionEncoding.Focus();
                return false;
            }

            return true;
        }


        private void btnProtect_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateInMemoryProtectionControls()) return;

                if (String.IsNullOrEmpty(txtTextToBeProtected.Text))
                {
                    MessageBox.Show("Please enter a text to be protected!", "Warning", MessageBoxButtons.OK);
                    txtTextToBeProtected.Focus();
                    return;
                }

                // protection
                string scopeName = (string)cboProtectionScope.SelectedItem;
                string encodingName = (string)cboProtectionEncoding.SelectedItem;
                string textToBeProtected = txtTextToBeProtected.Text;

                string algorithmName = (string)cboProtectionAlgorithm.SelectedItem;
                InMemoryController inMemoryController = GetInMemoryController(algorithmName);

                byte[] rawData;
                byte[] protectedData = inMemoryController.Protect(scopeName, encodingName, textToBeProtected, out rawData);

                // display results
                string rawDataText = Formatter.BinaryToHex(rawData);
                string protectedText = Formatter.BinaryToHex(protectedData);

                txtProtectionRawData.Text = rawDataText;
                txtProtectedData.Text = protectedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnUnprotect_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (!ValidateInMemoryProtectionControls()) return;

                if (String.IsNullOrEmpty(txtProtectedData.Text))
                {
                    MessageBox.Show("Please protect first!", "Warning", MessageBoxButtons.OK);
                    btnProtect.Focus();
                    return;
                }

                // protection
                string scopeName = (string)cboProtectionScope.SelectedItem;
                string encodingName = (string)cboProtectionEncoding.SelectedItem;
                string protectedText = txtProtectedData.Text;

                string algorithmName = (string)cboProtectionAlgorithm.SelectedItem;
                InMemoryController inMemoryController = GetInMemoryController(algorithmName);

                byte[] protectedData = Formatter.HexToBinary(protectedText);
                string unprotectedData = inMemoryController.Unprotect(scopeName, encodingName, protectedData);

                // display results
                txtUnprotectedData.Text = unprotectedData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    
    }
}
