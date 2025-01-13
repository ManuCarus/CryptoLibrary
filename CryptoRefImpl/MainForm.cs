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
using System.Windows.Forms;

namespace CryptoSamples.View
{
    public partial class MainForm : Form
    {
        private const string cKeySizeFormat = "bits (minimum: {0} bits, maximum: {1} bits, skip interval: {2} bits).";
        private const string cBlockSizeFormat = "bits (minimum: {0} bits, maximum: {1} bits, skip interval: {2} bits).";

        public MainForm()
        {
            InitializeComponent();

            // hashing
            PopulateHashingControls();
            ClearHashingOutputFields();

            // salted hashing
            PopulateSaltedHashingControls();
            ClearSaltedHashingOutputFields();

            // symmetric encryption
            PopulateSymmetricEncryptionControls();
            ClearSymmetricEncryptionOutputFields();

            // asymmetric encryption
            PopulateAsymmetricEncryptionControls();
            ClearAsymmetricEncryptionOutputFields();

            // digital signature
            PopulateSignatureControls();
            ClearSignatureOutputFields();

            // hybrid encryption
            PopulateHybridControls();
            ClearHybridOutputFields();

            // random number generator
            PopulateRandomNumberGeneratorControls();
            ClearRandomNumberGeneratorOutputFields();

            // message authentication code
            PopulateMessageAuthenticationCodeControls();
            ClearMessageAuthenticationCodeOutputFields();

            // in-memory protection
            PopulateInMemoryProtectionControls();
            ClearInMemoryProtectionOutputFields();
        }

   }
}
