/*
   CryptoRefImpl - demonstrates the use of safe cryptographic algorithms within the CryptoLibrary
   Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de)

   This program is free software; you can redistribute it and/or modify it under the terms of 
   the GNU General Public License as published by the Free Software Foundation; 
   either version 3 of the License, or (at your option) any later version.

   This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
   without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
   See the GNU General Public License for more details.

   You should have received a copy of the GNU General Public License along with this program; 
   if not, see <http://www.gnu.org/licenses/>.
*/

namespace CryptoSamples.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRandomNumberGenerator = new System.Windows.Forms.TabPage();
            this.btnRngGenerateBytes = new System.Windows.Forms.Button();
            this.txtRngGeneratedBytes = new System.Windows.Forms.TextBox();
            this.lblRngGeneratedBytes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRngCountBytes = new System.Windows.Forms.TextBox();
            this.lblRngCountBytes = new System.Windows.Forms.Label();
            this.cboRngAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblRngAlgorithm = new System.Windows.Forms.Label();
            this.tabHashing = new System.Windows.Forms.TabPage();
            this.rdoHashingFileToBeHashed = new System.Windows.Forms.RadioButton();
            this.rdoHashingTextToBeHashed = new System.Windows.Forms.RadioButton();
            this.cboHashEncoding = new System.Windows.Forms.ComboBox();
            this.lblHashEncoding = new System.Windows.Forms.Label();
            this.lblHashSizeBits = new System.Windows.Forms.Label();
            this.txtDigestSize = new System.Windows.Forms.TextBox();
            this.lblDigestSize = new System.Windows.Forms.Label();
            this.txtMessageDigest = new System.Windows.Forms.TextBox();
            this.btnHashInput = new System.Windows.Forms.Button();
            this.lblMessageDigest = new System.Windows.Forms.Label();
            this.cboHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblHashAlgorithm = new System.Windows.Forms.Label();
            this.btnChooseFileToBeHashed = new System.Windows.Forms.Button();
            this.txtFileToBeHashed = new System.Windows.Forms.TextBox();
            this.txtTextToBeHashed = new System.Windows.Forms.TextBox();
            this.tabSaltedHashing = new System.Windows.Forms.TabPage();
            this.rdoFileToBeSaltedHashed = new System.Windows.Forms.RadioButton();
            this.rdoTextToBeSaltedHashed = new System.Windows.Forms.RadioButton();
            this.btnChooseFileToBeSaltedHashed = new System.Windows.Forms.Button();
            this.txtSaltedMessageDigest = new System.Windows.Forms.TextBox();
            this.lblSaltedMessageDigest = new System.Windows.Forms.Label();
            this.txtSaltedHash = new System.Windows.Forms.TextBox();
            this.lblSaltedHash = new System.Windows.Forms.Label();
            this.txtRandomSalt = new System.Windows.Forms.TextBox();
            this.lblRandomSalt = new System.Windows.Forms.Label();
            this.btnSaltedHashInput = new System.Windows.Forms.Button();
            this.cboSaltedHashEncoding = new System.Windows.Forms.ComboBox();
            this.lblSaltedHashEncoding = new System.Windows.Forms.Label();
            this.lblSaltedDigestSizeBits = new System.Windows.Forms.Label();
            this.txtSaltedDigestSize = new System.Windows.Forms.TextBox();
            this.lblSaltedDigestSize = new System.Windows.Forms.Label();
            this.txtUnsaltedHash = new System.Windows.Forms.TextBox();
            this.lblUnsaltedHash = new System.Windows.Forms.Label();
            this.cboSaltedHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblSaltedHashAlgorithm = new System.Windows.Forms.Label();
            this.txtFileToBeSaltedHashed = new System.Windows.Forms.TextBox();
            this.txtTextToBeSaltedHashed = new System.Windows.Forms.TextBox();
            this.tabMessageAuthenticationCode = new System.Windows.Forms.TabPage();
            this.rdoMacFileToBeHashed = new System.Windows.Forms.RadioButton();
            this.rdoMacTextToBeHashed = new System.Windows.Forms.RadioButton();
            this.txtMacAuthentication = new System.Windows.Forms.TextBox();
            this.lblMacAuthentication = new System.Windows.Forms.Label();
            this.btnMacAuthenticateText = new System.Windows.Forms.Button();
            this.txtMacSecretKey = new System.Windows.Forms.TextBox();
            this.lblMacSecretKey = new System.Windows.Forms.Label();
            this.btnMacHashText = new System.Windows.Forms.Button();
            this.cboMacEncoding = new System.Windows.Forms.ComboBox();
            this.lblMacEncoding = new System.Windows.Forms.Label();
            this.lblMacDigestSizeBits = new System.Windows.Forms.Label();
            this.txtMacDigestSize = new System.Windows.Forms.TextBox();
            this.lblMacDigestSize = new System.Windows.Forms.Label();
            this.txtMacMessageDigest = new System.Windows.Forms.TextBox();
            this.lblMacMessageDigest = new System.Windows.Forms.Label();
            this.cboMacAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblMacAlgorithm = new System.Windows.Forms.Label();
            this.btnMacChooseFile = new System.Windows.Forms.Button();
            this.txtMacFileToBeHashed = new System.Windows.Forms.TextBox();
            this.txtMacTextToBeHashed = new System.Windows.Forms.TextBox();
            this.tabSymmetricEncryption = new System.Windows.Forms.TabPage();
            this.btnDeriveSymmetricKeyFromPassphrase = new System.Windows.Forms.Button();
            this.txtSymmetricEncryptionPassphrase = new System.Windows.Forms.TextBox();
            this.lblSymmetricEncryptionPassphrase = new System.Windows.Forms.Label();
            this.txtSymmetricBlockSize = new System.Windows.Forms.TextBox();
            this.txtSymmetricKeySize = new System.Windows.Forms.TextBox();
            this.cboSymmetricEncoding = new System.Windows.Forms.ComboBox();
            this.lblSymmetricEncoding = new System.Windows.Forms.Label();
            this.txtSymmetricallyDecryptedValue = new System.Windows.Forms.TextBox();
            this.lblSymmetricallyDecryptedValue = new System.Windows.Forms.Label();
            this.btnDecryptSymmetrically = new System.Windows.Forms.Button();
            this.cboSymmetricPaddingMode = new System.Windows.Forms.ComboBox();
            this.lblSymmetricPaddingMode = new System.Windows.Forms.Label();
            this.cboSymmetricCipherMode = new System.Windows.Forms.ComboBox();
            this.lblSymmetricCipherMode = new System.Windows.Forms.Label();
            this.btnCreateInitializationVector = new System.Windows.Forms.Button();
            this.lblSymmetricBlockSizeBits = new System.Windows.Forms.Label();
            this.lblSymmetricKeySizeBits = new System.Windows.Forms.Label();
            this.lblSymmetricBlockSize = new System.Windows.Forms.Label();
            this.lblSymmetricKeySize = new System.Windows.Forms.Label();
            this.cboSymmetricAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblSymmetricAlgorithm = new System.Windows.Forms.Label();
            this.txtSymmetricEncryptionInitializationVector = new System.Windows.Forms.TextBox();
            this.lblEncryptedValueSizeBytes = new System.Windows.Forms.Label();
            this.txtEncryptedValueSize = new System.Windows.Forms.TextBox();
            this.lblEncryptedValueSize = new System.Windows.Forms.Label();
            this.txtSymmetricallyEncryptedValue = new System.Windows.Forms.TextBox();
            this.btnEncryptSymmetrically = new System.Windows.Forms.Button();
            this.lblSymmetricallyEncryptedValue = new System.Windows.Forms.Label();
            this.lblSymmetricEncryptionInitializationVector = new System.Windows.Forms.Label();
            this.btnCreateSymmetricKey = new System.Windows.Forms.Button();
            this.txtSymmetricKey = new System.Windows.Forms.TextBox();
            this.lblSymmetricKey = new System.Windows.Forms.Label();
            this.txtInputToBeSymmetricallyEncrypted = new System.Windows.Forms.TextBox();
            this.lblTextToBeSymmetricallyEncrypted = new System.Windows.Forms.Label();
            this.tabAsymmetricAlgorithm = new System.Windows.Forms.TabPage();
            this.cboAsymmetricEncryptionPaddingMode = new System.Windows.Forms.ComboBox();
            this.lblAsymmetricEncryptionPaddingMode = new System.Windows.Forms.Label();
            this.txtAsymmetricallyEncryptedValueSizeBytes = new System.Windows.Forms.Label();
            this.cboAsymmetricEncoding = new System.Windows.Forms.ComboBox();
            this.lblAsymmetricEncoding = new System.Windows.Forms.Label();
            this.txtAsymmetricallyDecryptedValue = new System.Windows.Forms.TextBox();
            this.lblAsymmetricallyDecryptedValue = new System.Windows.Forms.Label();
            this.btnAsymmetricallyDecrypt = new System.Windows.Forms.Button();
            this.txtAsymmetricallyEncryptedValueSize = new System.Windows.Forms.TextBox();
            this.lblAsymmetricallyEncryptedValueSize = new System.Windows.Forms.Label();
            this.txtAsymmetricallyEncryptedValue = new System.Windows.Forms.TextBox();
            this.btnEncryptAsymmetrically = new System.Windows.Forms.Button();
            this.lblAsymmetricallyEncryptedValue = new System.Windows.Forms.Label();
            this.txtAsymmetricTextToBeEncrypted = new System.Windows.Forms.TextBox();
            this.lblAsymmetricTextToBeEncrypted = new System.Windows.Forms.Label();
            this.btnCreateAsymmetricKey = new System.Windows.Forms.Button();
            this.txtPublicPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPublicPrivateKey = new System.Windows.Forms.Label();
            this.txtAsymmetricKeyExchangeAlgorithm = new System.Windows.Forms.TextBox();
            this.lblAsymmetricKeyExchangeAlgorithm = new System.Windows.Forms.Label();
            this.txtAsymmetricKeySize = new System.Windows.Forms.TextBox();
            this.lblAsymmetricKeySizeBits = new System.Windows.Forms.Label();
            this.lblAsymmetricKeySize = new System.Windows.Forms.Label();
            this.cboAsymmetricAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHybridEncryption = new System.Windows.Forms.TabPage();
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits = new System.Windows.Forms.Label();
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize = new System.Windows.Forms.Label();
            this.txtHybridEncryptionDecryptedIV = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionDecryptedIV = new System.Windows.Forms.Label();
            this.txtHybridEncryptionEncryptedIV = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionEncryptedIV = new System.Windows.Forms.Label();
            this.txtHybridEncryptionDecryptedText = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionDecryptedText = new System.Windows.Forms.Label();
            this.txtHybridEncryptionDecryptedSessionKey = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionDecryptedSessionKey = new System.Windows.Forms.Label();
            this.btnHybridEncryptionDecrypt = new System.Windows.Forms.Button();
            this.txtHybridEncryptionEncryptedSessionKey = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionEncryptedSessionKey = new System.Windows.Forms.Label();
            this.txtHybridEncryptionEncryptedText = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionEncryptedText = new System.Windows.Forms.Label();
            this.txtHybridEncryptionTextToBeEncrypted = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionTextToBeEncrypted = new System.Windows.Forms.Label();
            this.txtHybridEncryptionSymmetricAlgorithmKeySize = new System.Windows.Forms.TextBox();
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode = new System.Windows.Forms.ComboBox();
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode = new System.Windows.Forms.Label();
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode = new System.Windows.Forms.ComboBox();
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode = new System.Windows.Forms.Label();
            this.btnHybridEncryptionCreateIv = new System.Windows.Forms.Button();
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits = new System.Windows.Forms.Label();
            this.lblHybridEncryptionSymmetricAlgorithmKeySize = new System.Windows.Forms.Label();
            this.cboHybridEncryptionSymmetricAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblHybridEncryptionSymmetricAlgorithm = new System.Windows.Forms.Label();
            this.txtHybridEncryptionIv = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionIv = new System.Windows.Forms.Label();
            this.btnHybridEncryptionCreateSymmetricKey = new System.Windows.Forms.Button();
            this.txtHybridEncryptionSymmetricKey = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionSymmetricKey = new System.Windows.Forms.Label();
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode = new System.Windows.Forms.ComboBox();
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode = new System.Windows.Forms.Label();
            this.cboHybridEncryptionEncoding = new System.Windows.Forms.ComboBox();
            this.lblHybridEncryptionEncoding = new System.Windows.Forms.Label();
            this.btnHybridEncryptionEncrypt = new System.Windows.Forms.Button();
            this.btnHybridEncryptionCreateAsymmetricKey = new System.Windows.Forms.Button();
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml = new System.Windows.Forms.Label();
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize = new System.Windows.Forms.TextBox();
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits = new System.Windows.Forms.Label();
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize = new System.Windows.Forms.Label();
            this.cboHybridEncryptionAsymmetricAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblHybridEncryptionAsymmetricAlgorithm = new System.Windows.Forms.Label();
            this.tabDigitalSignature = new System.Windows.Forms.TabPage();
            this.rdoDigitalSignatureFileToBeSigned = new System.Windows.Forms.RadioButton();
            this.rdoDigitalSignatureTextToBeSigned = new System.Windows.Forms.RadioButton();
            this.txtDigitalSignatureVerification = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureVerification = new System.Windows.Forms.Label();
            this.lblDigitalSignatureSizeBits = new System.Windows.Forms.Label();
            this.txtDigitalSignatureSize = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureSize = new System.Windows.Forms.Label();
            this.txtDigitalSignatureResult = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureResult = new System.Windows.Forms.Label();
            this.btnDigitalSignatureChooseFile = new System.Windows.Forms.Button();
            this.txtDigitalSignatureFileToBeSigned = new System.Windows.Forms.TextBox();
            this.cboDigitalSignatureHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblDigitalSignatureHashAlgorithm = new System.Windows.Forms.Label();
            this.txtDigitalSignatureSignatureAlgorithm = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureSignatureAlgorithm = new System.Windows.Forms.Label();
            this.cboDigitalSignatureEncoding = new System.Windows.Forms.ComboBox();
            this.lblDigitalSignatureEncoding = new System.Windows.Forms.Label();
            this.btnDigitalSignatureVerifyText = new System.Windows.Forms.Button();
            this.btnDigitalSignatureSignText = new System.Windows.Forms.Button();
            this.txtDigitalSignatureTextToBeSigned = new System.Windows.Forms.TextBox();
            this.btnDigitalSignatureCreateKey = new System.Windows.Forms.Button();
            this.txtDigitalSignatureKeyXml = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureKeyXml = new System.Windows.Forms.Label();
            this.txtDigitalSignatureKeyExchangeAlgorithm = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureKeyExchangeAlgorithm = new System.Windows.Forms.Label();
            this.txtDigitalSignatureKeySize = new System.Windows.Forms.TextBox();
            this.lblDigitalSignatureKeySizeBits = new System.Windows.Forms.Label();
            this.lblDigitalSignatureKeySize = new System.Windows.Forms.Label();
            this.cboDigitalSignatureAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblDigitalSignatureAlgorithm = new System.Windows.Forms.Label();
            this.tabInMemoryEncryption = new System.Windows.Forms.TabPage();
            this.cboProtectionScope = new System.Windows.Forms.ComboBox();
            this.lblProtectionScope = new System.Windows.Forms.Label();
            this.txtUnprotectedData = new System.Windows.Forms.TextBox();
            this.lblUnprotectedData = new System.Windows.Forms.Label();
            this.txtProtectedData = new System.Windows.Forms.TextBox();
            this.lblProtectedData = new System.Windows.Forms.Label();
            this.btnProtect = new System.Windows.Forms.Button();
            this.cboProtectionEncoding = new System.Windows.Forms.ComboBox();
            this.lblProtectionEncoding = new System.Windows.Forms.Label();
            this.txtProtectionRawData = new System.Windows.Forms.TextBox();
            this.btnUnprotect = new System.Windows.Forms.Button();
            this.lblProtectionRawData = new System.Windows.Forms.Label();
            this.cboProtectionAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblProtectionAlgorithm = new System.Windows.Forms.Label();
            this.txtTextToBeProtected = new System.Windows.Forms.TextBox();
            this.lblTextToBeProtected = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabRandomNumberGenerator.SuspendLayout();
            this.tabHashing.SuspendLayout();
            this.tabSaltedHashing.SuspendLayout();
            this.tabMessageAuthenticationCode.SuspendLayout();
            this.tabSymmetricEncryption.SuspendLayout();
            this.tabAsymmetricAlgorithm.SuspendLayout();
            this.tabHybridEncryption.SuspendLayout();
            this.tabDigitalSignature.SuspendLayout();
            this.tabInMemoryEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRandomNumberGenerator);
            this.tabControl.Controls.Add(this.tabHashing);
            this.tabControl.Controls.Add(this.tabSaltedHashing);
            this.tabControl.Controls.Add(this.tabMessageAuthenticationCode);
            this.tabControl.Controls.Add(this.tabSymmetricEncryption);
            this.tabControl.Controls.Add(this.tabAsymmetricAlgorithm);
            this.tabControl.Controls.Add(this.tabHybridEncryption);
            this.tabControl.Controls.Add(this.tabDigitalSignature);
            this.tabControl.Controls.Add(this.tabInMemoryEncryption);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(989, 976);
            this.tabControl.TabIndex = 1;
            // 
            // tabRandomNumberGenerator
            // 
            this.tabRandomNumberGenerator.Controls.Add(this.btnRngGenerateBytes);
            this.tabRandomNumberGenerator.Controls.Add(this.txtRngGeneratedBytes);
            this.tabRandomNumberGenerator.Controls.Add(this.lblRngGeneratedBytes);
            this.tabRandomNumberGenerator.Controls.Add(this.label2);
            this.tabRandomNumberGenerator.Controls.Add(this.txtRngCountBytes);
            this.tabRandomNumberGenerator.Controls.Add(this.lblRngCountBytes);
            this.tabRandomNumberGenerator.Controls.Add(this.cboRngAlgorithm);
            this.tabRandomNumberGenerator.Controls.Add(this.lblRngAlgorithm);
            this.tabRandomNumberGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabRandomNumberGenerator.Name = "tabRandomNumberGenerator";
            this.tabRandomNumberGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandomNumberGenerator.Size = new System.Drawing.Size(981, 950);
            this.tabRandomNumberGenerator.TabIndex = 6;
            this.tabRandomNumberGenerator.Text = "Random Number Generator";
            this.tabRandomNumberGenerator.UseVisualStyleBackColor = true;
            // 
            // btnRngGenerateBytes
            // 
            this.btnRngGenerateBytes.Location = new System.Drawing.Point(138, 69);
            this.btnRngGenerateBytes.Name = "btnRngGenerateBytes";
            this.btnRngGenerateBytes.Size = new System.Drawing.Size(159, 23);
            this.btnRngGenerateBytes.TabIndex = 50;
            this.btnRngGenerateBytes.Text = "Generate Bytes";
            this.btnRngGenerateBytes.UseVisualStyleBackColor = true;
            this.btnRngGenerateBytes.Click += new System.EventHandler(this.btnRngGenerateBytes_Click);
            // 
            // txtRngGeneratedBytes
            // 
            this.txtRngGeneratedBytes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRngGeneratedBytes.Location = new System.Drawing.Point(138, 98);
            this.txtRngGeneratedBytes.Multiline = true;
            this.txtRngGeneratedBytes.Name = "txtRngGeneratedBytes";
            this.txtRngGeneratedBytes.ReadOnly = true;
            this.txtRngGeneratedBytes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRngGeneratedBytes.Size = new System.Drawing.Size(837, 170);
            this.txtRngGeneratedBytes.TabIndex = 49;
            // 
            // lblRngGeneratedBytes
            // 
            this.lblRngGeneratedBytes.AutoSize = true;
            this.lblRngGeneratedBytes.Location = new System.Drawing.Point(7, 101);
            this.lblRngGeneratedBytes.Name = "lblRngGeneratedBytes";
            this.lblRngGeneratedBytes.Size = new System.Drawing.Size(102, 13);
            this.lblRngGeneratedBytes.TabIndex = 48;
            this.lblRngGeneratedBytes.Text = "Random Sequence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "bytes";
            // 
            // txtRngCountBytes
            // 
            this.txtRngCountBytes.Location = new System.Drawing.Point(138, 43);
            this.txtRngCountBytes.MaxLength = 4;
            this.txtRngCountBytes.Name = "txtRngCountBytes";
            this.txtRngCountBytes.Size = new System.Drawing.Size(159, 20);
            this.txtRngCountBytes.TabIndex = 46;
            this.txtRngCountBytes.Text = "256";
            this.txtRngCountBytes.TextChanged += new System.EventHandler(this.txtRngCountBytes_TextChanged);
            // 
            // lblRngCountBytes
            // 
            this.lblRngCountBytes.AutoSize = true;
            this.lblRngCountBytes.Location = new System.Drawing.Point(7, 46);
            this.lblRngCountBytes.Name = "lblRngCountBytes";
            this.lblRngCountBytes.Size = new System.Drawing.Size(87, 13);
            this.lblRngCountBytes.TabIndex = 45;
            this.lblRngCountBytes.Text = "Amount of Bytes:";
            // 
            // cboRngAlgorithm
            // 
            this.cboRngAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRngAlgorithm.FormattingEnabled = true;
            this.cboRngAlgorithm.Location = new System.Drawing.Point(138, 16);
            this.cboRngAlgorithm.Name = "cboRngAlgorithm";
            this.cboRngAlgorithm.Size = new System.Drawing.Size(159, 21);
            this.cboRngAlgorithm.TabIndex = 44;
            this.cboRngAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboRngAlgorithm_SelectedIndexChanged);
            // 
            // lblRngAlgorithm
            // 
            this.lblRngAlgorithm.AutoSize = true;
            this.lblRngAlgorithm.Location = new System.Drawing.Point(7, 19);
            this.lblRngAlgorithm.Name = "lblRngAlgorithm";
            this.lblRngAlgorithm.Size = new System.Drawing.Size(80, 13);
            this.lblRngAlgorithm.TabIndex = 43;
            this.lblRngAlgorithm.Text = "RNG Algorithm:";
            // 
            // tabHashing
            // 
            this.tabHashing.Controls.Add(this.rdoHashingFileToBeHashed);
            this.tabHashing.Controls.Add(this.rdoHashingTextToBeHashed);
            this.tabHashing.Controls.Add(this.cboHashEncoding);
            this.tabHashing.Controls.Add(this.lblHashEncoding);
            this.tabHashing.Controls.Add(this.lblHashSizeBits);
            this.tabHashing.Controls.Add(this.txtDigestSize);
            this.tabHashing.Controls.Add(this.lblDigestSize);
            this.tabHashing.Controls.Add(this.txtMessageDigest);
            this.tabHashing.Controls.Add(this.btnHashInput);
            this.tabHashing.Controls.Add(this.lblMessageDigest);
            this.tabHashing.Controls.Add(this.cboHashAlgorithm);
            this.tabHashing.Controls.Add(this.lblHashAlgorithm);
            this.tabHashing.Controls.Add(this.btnChooseFileToBeHashed);
            this.tabHashing.Controls.Add(this.txtFileToBeHashed);
            this.tabHashing.Controls.Add(this.txtTextToBeHashed);
            this.tabHashing.Location = new System.Drawing.Point(4, 22);
            this.tabHashing.Name = "tabHashing";
            this.tabHashing.Padding = new System.Windows.Forms.Padding(3);
            this.tabHashing.Size = new System.Drawing.Size(981, 950);
            this.tabHashing.TabIndex = 0;
            this.tabHashing.Text = "Hashing";
            this.tabHashing.UseVisualStyleBackColor = true;
            // 
            // rdoHashingFileToBeHashed
            // 
            this.rdoHashingFileToBeHashed.AutoSize = true;
            this.rdoHashingFileToBeHashed.Location = new System.Drawing.Point(9, 247);
            this.rdoHashingFileToBeHashed.Name = "rdoHashingFileToBeHashed";
            this.rdoHashingFileToBeHashed.Size = new System.Drawing.Size(109, 17);
            this.rdoHashingFileToBeHashed.TabIndex = 23;
            this.rdoHashingFileToBeHashed.Text = "File to be hashed:";
            this.rdoHashingFileToBeHashed.UseVisualStyleBackColor = true;
            // 
            // rdoHashingTextToBeHashed
            // 
            this.rdoHashingTextToBeHashed.AutoSize = true;
            this.rdoHashingTextToBeHashed.Checked = true;
            this.rdoHashingTextToBeHashed.Location = new System.Drawing.Point(9, 71);
            this.rdoHashingTextToBeHashed.Name = "rdoHashingTextToBeHashed";
            this.rdoHashingTextToBeHashed.Size = new System.Drawing.Size(114, 17);
            this.rdoHashingTextToBeHashed.TabIndex = 22;
            this.rdoHashingTextToBeHashed.TabStop = true;
            this.rdoHashingTextToBeHashed.Text = "Text to be hashed:";
            this.rdoHashingTextToBeHashed.UseVisualStyleBackColor = true;
            // 
            // cboHashEncoding
            // 
            this.cboHashEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHashEncoding.FormattingEnabled = true;
            this.cboHashEncoding.Location = new System.Drawing.Point(125, 43);
            this.cboHashEncoding.Name = "cboHashEncoding";
            this.cboHashEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboHashEncoding.Sorted = true;
            this.cboHashEncoding.TabIndex = 20;
            this.cboHashEncoding.SelectedIndexChanged += new System.EventHandler(this.cboHashEncoding_SelectedIndexChanged);
            // 
            // lblHashEncoding
            // 
            this.lblHashEncoding.AutoSize = true;
            this.lblHashEncoding.Location = new System.Drawing.Point(6, 46);
            this.lblHashEncoding.Name = "lblHashEncoding";
            this.lblHashEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblHashEncoding.TabIndex = 19;
            this.lblHashEncoding.Text = "Encoding:";
            // 
            // lblHashSizeBits
            // 
            this.lblHashSizeBits.AutoSize = true;
            this.lblHashSizeBits.Location = new System.Drawing.Point(252, 330);
            this.lblHashSizeBits.Name = "lblHashSizeBits";
            this.lblHashSizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblHashSizeBits.TabIndex = 15;
            this.lblHashSizeBits.Text = "bits";
            // 
            // txtDigestSize
            // 
            this.txtDigestSize.Location = new System.Drawing.Point(125, 327);
            this.txtDigestSize.Name = "txtDigestSize";
            this.txtDigestSize.ReadOnly = true;
            this.txtDigestSize.Size = new System.Drawing.Size(121, 20);
            this.txtDigestSize.TabIndex = 14;
            // 
            // lblDigestSize
            // 
            this.lblDigestSize.AutoSize = true;
            this.lblDigestSize.Location = new System.Drawing.Point(6, 330);
            this.lblDigestSize.Name = "lblDigestSize";
            this.lblDigestSize.Size = new System.Drawing.Size(63, 13);
            this.lblDigestSize.TabIndex = 13;
            this.lblDigestSize.Text = "Digest Size:";
            // 
            // txtMessageDigest
            // 
            this.txtMessageDigest.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtMessageDigest.Location = new System.Drawing.Point(125, 301);
            this.txtMessageDigest.Name = "txtMessageDigest";
            this.txtMessageDigest.ReadOnly = true;
            this.txtMessageDigest.Size = new System.Drawing.Size(850, 20);
            this.txtMessageDigest.TabIndex = 9;
            // 
            // btnHashInput
            // 
            this.btnHashInput.Location = new System.Drawing.Point(125, 272);
            this.btnHashInput.Name = "btnHashInput";
            this.btnHashInput.Size = new System.Drawing.Size(75, 23);
            this.btnHashInput.TabIndex = 24;
            this.btnHashInput.Text = "Hash";
            this.btnHashInput.Click += new System.EventHandler(this.btnHashInput_Click);
            // 
            // lblMessageDigest
            // 
            this.lblMessageDigest.AutoSize = true;
            this.lblMessageDigest.Location = new System.Drawing.Point(6, 304);
            this.lblMessageDigest.Name = "lblMessageDigest";
            this.lblMessageDigest.Size = new System.Drawing.Size(86, 13);
            this.lblMessageDigest.TabIndex = 7;
            this.lblMessageDigest.Text = "Message Digest:";
            // 
            // cboHashAlgorithm
            // 
            this.cboHashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHashAlgorithm.FormattingEnabled = true;
            this.cboHashAlgorithm.Location = new System.Drawing.Point(125, 16);
            this.cboHashAlgorithm.Name = "cboHashAlgorithm";
            this.cboHashAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboHashAlgorithm.TabIndex = 6;
            this.cboHashAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboHashAlgorithm_SelectedIndexChanged);
            // 
            // lblHashAlgorithm
            // 
            this.lblHashAlgorithm.AutoSize = true;
            this.lblHashAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.lblHashAlgorithm.Name = "lblHashAlgorithm";
            this.lblHashAlgorithm.Size = new System.Drawing.Size(81, 13);
            this.lblHashAlgorithm.TabIndex = 5;
            this.lblHashAlgorithm.Text = "Hash Algorithm:";
            // 
            // btnChooseFileToBeHashed
            // 
            this.btnChooseFileToBeHashed.Location = new System.Drawing.Point(938, 244);
            this.btnChooseFileToBeHashed.Name = "btnChooseFileToBeHashed";
            this.btnChooseFileToBeHashed.Size = new System.Drawing.Size(37, 23);
            this.btnChooseFileToBeHashed.TabIndex = 4;
            this.btnChooseFileToBeHashed.Text = "...";
            this.btnChooseFileToBeHashed.UseVisualStyleBackColor = true;
            this.btnChooseFileToBeHashed.Click += new System.EventHandler(this.btnChooseFileToBeHashed_Click);
            // 
            // txtFileToBeHashed
            // 
            this.txtFileToBeHashed.Location = new System.Drawing.Point(125, 246);
            this.txtFileToBeHashed.MaxLength = 255;
            this.txtFileToBeHashed.Name = "txtFileToBeHashed";
            this.txtFileToBeHashed.Size = new System.Drawing.Size(807, 20);
            this.txtFileToBeHashed.TabIndex = 3;
            this.txtFileToBeHashed.TextChanged += new System.EventHandler(this.txtFileToBeHashed_TextChanged);
            // 
            // txtTextToBeHashed
            // 
            this.txtTextToBeHashed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTextToBeHashed.Location = new System.Drawing.Point(125, 70);
            this.txtTextToBeHashed.Multiline = true;
            this.txtTextToBeHashed.Name = "txtTextToBeHashed";
            this.txtTextToBeHashed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextToBeHashed.Size = new System.Drawing.Size(850, 170);
            this.txtTextToBeHashed.TabIndex = 1;
            this.txtTextToBeHashed.Text = resources.GetString("txtTextToBeHashed.Text");
            this.txtTextToBeHashed.TextChanged += new System.EventHandler(this.txtInputToBeHashed_TextChanged);
            // 
            // tabSaltedHashing
            // 
            this.tabSaltedHashing.Controls.Add(this.rdoFileToBeSaltedHashed);
            this.tabSaltedHashing.Controls.Add(this.rdoTextToBeSaltedHashed);
            this.tabSaltedHashing.Controls.Add(this.btnChooseFileToBeSaltedHashed);
            this.tabSaltedHashing.Controls.Add(this.txtSaltedMessageDigest);
            this.tabSaltedHashing.Controls.Add(this.lblSaltedMessageDigest);
            this.tabSaltedHashing.Controls.Add(this.txtSaltedHash);
            this.tabSaltedHashing.Controls.Add(this.lblSaltedHash);
            this.tabSaltedHashing.Controls.Add(this.txtRandomSalt);
            this.tabSaltedHashing.Controls.Add(this.lblRandomSalt);
            this.tabSaltedHashing.Controls.Add(this.btnSaltedHashInput);
            this.tabSaltedHashing.Controls.Add(this.cboSaltedHashEncoding);
            this.tabSaltedHashing.Controls.Add(this.lblSaltedHashEncoding);
            this.tabSaltedHashing.Controls.Add(this.lblSaltedDigestSizeBits);
            this.tabSaltedHashing.Controls.Add(this.txtSaltedDigestSize);
            this.tabSaltedHashing.Controls.Add(this.lblSaltedDigestSize);
            this.tabSaltedHashing.Controls.Add(this.txtUnsaltedHash);
            this.tabSaltedHashing.Controls.Add(this.lblUnsaltedHash);
            this.tabSaltedHashing.Controls.Add(this.cboSaltedHashAlgorithm);
            this.tabSaltedHashing.Controls.Add(this.lblSaltedHashAlgorithm);
            this.tabSaltedHashing.Controls.Add(this.txtFileToBeSaltedHashed);
            this.tabSaltedHashing.Controls.Add(this.txtTextToBeSaltedHashed);
            this.tabSaltedHashing.Location = new System.Drawing.Point(4, 22);
            this.tabSaltedHashing.Name = "tabSaltedHashing";
            this.tabSaltedHashing.Padding = new System.Windows.Forms.Padding(3);
            this.tabSaltedHashing.Size = new System.Drawing.Size(981, 950);
            this.tabSaltedHashing.TabIndex = 5;
            this.tabSaltedHashing.Text = "Salted Hashing";
            this.tabSaltedHashing.UseVisualStyleBackColor = true;
            // 
            // rdoFileToBeSaltedHashed
            // 
            this.rdoFileToBeSaltedHashed.AutoSize = true;
            this.rdoFileToBeSaltedHashed.Location = new System.Drawing.Point(9, 97);
            this.rdoFileToBeSaltedHashed.Name = "rdoFileToBeSaltedHashed";
            this.rdoFileToBeSaltedHashed.Size = new System.Drawing.Size(109, 17);
            this.rdoFileToBeSaltedHashed.TabIndex = 45;
            this.rdoFileToBeSaltedHashed.Text = "File to be hashed:";
            this.rdoFileToBeSaltedHashed.UseVisualStyleBackColor = true;
            // 
            // rdoTextToBeSaltedHashed
            // 
            this.rdoTextToBeSaltedHashed.AutoSize = true;
            this.rdoTextToBeSaltedHashed.Checked = true;
            this.rdoTextToBeSaltedHashed.Location = new System.Drawing.Point(9, 71);
            this.rdoTextToBeSaltedHashed.Name = "rdoTextToBeSaltedHashed";
            this.rdoTextToBeSaltedHashed.Size = new System.Drawing.Size(114, 17);
            this.rdoTextToBeSaltedHashed.TabIndex = 44;
            this.rdoTextToBeSaltedHashed.TabStop = true;
            this.rdoTextToBeSaltedHashed.Text = "Text to be hashed:";
            this.rdoTextToBeSaltedHashed.UseVisualStyleBackColor = true;
            // 
            // btnChooseFileToBeSaltedHashed
            // 
            this.btnChooseFileToBeSaltedHashed.Location = new System.Drawing.Point(938, 94);
            this.btnChooseFileToBeSaltedHashed.Name = "btnChooseFileToBeSaltedHashed";
            this.btnChooseFileToBeSaltedHashed.Size = new System.Drawing.Size(37, 23);
            this.btnChooseFileToBeSaltedHashed.TabIndex = 43;
            this.btnChooseFileToBeSaltedHashed.Text = "...";
            this.btnChooseFileToBeSaltedHashed.UseVisualStyleBackColor = true;
            this.btnChooseFileToBeSaltedHashed.Click += new System.EventHandler(this.btnChooseFileToBeSaltedHashed_Click);
            // 
            // txtSaltedMessageDigest
            // 
            this.txtSaltedMessageDigest.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtSaltedMessageDigest.Location = new System.Drawing.Point(125, 229);
            this.txtSaltedMessageDigest.Name = "txtSaltedMessageDigest";
            this.txtSaltedMessageDigest.ReadOnly = true;
            this.txtSaltedMessageDigest.Size = new System.Drawing.Size(850, 20);
            this.txtSaltedMessageDigest.TabIndex = 42;
            // 
            // lblSaltedMessageDigest
            // 
            this.lblSaltedMessageDigest.AutoSize = true;
            this.lblSaltedMessageDigest.Location = new System.Drawing.Point(6, 232);
            this.lblSaltedMessageDigest.Name = "lblSaltedMessageDigest";
            this.lblSaltedMessageDigest.Size = new System.Drawing.Size(119, 13);
            this.lblSaltedMessageDigest.TabIndex = 41;
            this.lblSaltedMessageDigest.Text = "Salted Message Digest:";
            // 
            // txtSaltedHash
            // 
            this.txtSaltedHash.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtSaltedHash.Location = new System.Drawing.Point(125, 203);
            this.txtSaltedHash.Name = "txtSaltedHash";
            this.txtSaltedHash.ReadOnly = true;
            this.txtSaltedHash.Size = new System.Drawing.Size(850, 20);
            this.txtSaltedHash.TabIndex = 40;
            // 
            // lblSaltedHash
            // 
            this.lblSaltedHash.AutoSize = true;
            this.lblSaltedHash.Location = new System.Drawing.Point(6, 206);
            this.lblSaltedHash.Name = "lblSaltedHash";
            this.lblSaltedHash.Size = new System.Drawing.Size(68, 13);
            this.lblSaltedHash.TabIndex = 39;
            this.lblSaltedHash.Text = "Salted Hash:";
            // 
            // txtRandomSalt
            // 
            this.txtRandomSalt.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtRandomSalt.Location = new System.Drawing.Point(125, 177);
            this.txtRandomSalt.Name = "txtRandomSalt";
            this.txtRandomSalt.ReadOnly = true;
            this.txtRandomSalt.Size = new System.Drawing.Size(850, 20);
            this.txtRandomSalt.TabIndex = 38;
            // 
            // lblRandomSalt
            // 
            this.lblRandomSalt.AutoSize = true;
            this.lblRandomSalt.Location = new System.Drawing.Point(6, 180);
            this.lblRandomSalt.Name = "lblRandomSalt";
            this.lblRandomSalt.Size = new System.Drawing.Size(71, 13);
            this.lblRandomSalt.TabIndex = 37;
            this.lblRandomSalt.Text = "Random Salt:";
            // 
            // btnSaltedHashInput
            // 
            this.btnSaltedHashInput.Location = new System.Drawing.Point(125, 122);
            this.btnSaltedHashInput.Name = "btnSaltedHashInput";
            this.btnSaltedHashInput.Size = new System.Drawing.Size(121, 23);
            this.btnSaltedHashInput.TabIndex = 36;
            this.btnSaltedHashInput.Text = "Salted Hash";
            this.btnSaltedHashInput.UseVisualStyleBackColor = true;
            this.btnSaltedHashInput.Click += new System.EventHandler(this.btnSaltedHashInput_Click);
            // 
            // cboSaltedHashEncoding
            // 
            this.cboSaltedHashEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaltedHashEncoding.FormattingEnabled = true;
            this.cboSaltedHashEncoding.Location = new System.Drawing.Point(125, 43);
            this.cboSaltedHashEncoding.Name = "cboSaltedHashEncoding";
            this.cboSaltedHashEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboSaltedHashEncoding.Sorted = true;
            this.cboSaltedHashEncoding.TabIndex = 35;
            this.cboSaltedHashEncoding.SelectedIndexChanged += new System.EventHandler(this.cboSaltedHashEncoding_SelectedIndexChanged);
            // 
            // lblSaltedHashEncoding
            // 
            this.lblSaltedHashEncoding.AutoSize = true;
            this.lblSaltedHashEncoding.Location = new System.Drawing.Point(6, 46);
            this.lblSaltedHashEncoding.Name = "lblSaltedHashEncoding";
            this.lblSaltedHashEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblSaltedHashEncoding.TabIndex = 34;
            this.lblSaltedHashEncoding.Text = "Encoding:";
            // 
            // lblSaltedDigestSizeBits
            // 
            this.lblSaltedDigestSizeBits.AutoSize = true;
            this.lblSaltedDigestSizeBits.Location = new System.Drawing.Point(252, 258);
            this.lblSaltedDigestSizeBits.Name = "lblSaltedDigestSizeBits";
            this.lblSaltedDigestSizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblSaltedDigestSizeBits.TabIndex = 33;
            this.lblSaltedDigestSizeBits.Text = "bits";
            // 
            // txtSaltedDigestSize
            // 
            this.txtSaltedDigestSize.Location = new System.Drawing.Point(125, 255);
            this.txtSaltedDigestSize.Name = "txtSaltedDigestSize";
            this.txtSaltedDigestSize.ReadOnly = true;
            this.txtSaltedDigestSize.Size = new System.Drawing.Size(121, 20);
            this.txtSaltedDigestSize.TabIndex = 32;
            // 
            // lblSaltedDigestSize
            // 
            this.lblSaltedDigestSize.AutoSize = true;
            this.lblSaltedDigestSize.Location = new System.Drawing.Point(6, 258);
            this.lblSaltedDigestSize.Name = "lblSaltedDigestSize";
            this.lblSaltedDigestSize.Size = new System.Drawing.Size(63, 13);
            this.lblSaltedDigestSize.TabIndex = 31;
            this.lblSaltedDigestSize.Text = "Digest Size:";
            // 
            // txtUnsaltedHash
            // 
            this.txtUnsaltedHash.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtUnsaltedHash.Location = new System.Drawing.Point(125, 151);
            this.txtUnsaltedHash.Name = "txtUnsaltedHash";
            this.txtUnsaltedHash.ReadOnly = true;
            this.txtUnsaltedHash.Size = new System.Drawing.Size(850, 20);
            this.txtUnsaltedHash.TabIndex = 30;
            // 
            // lblUnsaltedHash
            // 
            this.lblUnsaltedHash.AutoSize = true;
            this.lblUnsaltedHash.Location = new System.Drawing.Point(6, 154);
            this.lblUnsaltedHash.Name = "lblUnsaltedHash";
            this.lblUnsaltedHash.Size = new System.Drawing.Size(80, 13);
            this.lblUnsaltedHash.TabIndex = 28;
            this.lblUnsaltedHash.Text = "Unsalted Hash:";
            // 
            // cboSaltedHashAlgorithm
            // 
            this.cboSaltedHashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaltedHashAlgorithm.FormattingEnabled = true;
            this.cboSaltedHashAlgorithm.Location = new System.Drawing.Point(125, 16);
            this.cboSaltedHashAlgorithm.Name = "cboSaltedHashAlgorithm";
            this.cboSaltedHashAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboSaltedHashAlgorithm.TabIndex = 27;
            this.cboSaltedHashAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboSaltedHashAlgorithm_SelectedIndexChanged);
            // 
            // lblSaltedHashAlgorithm
            // 
            this.lblSaltedHashAlgorithm.AutoSize = true;
            this.lblSaltedHashAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.lblSaltedHashAlgorithm.Name = "lblSaltedHashAlgorithm";
            this.lblSaltedHashAlgorithm.Size = new System.Drawing.Size(81, 13);
            this.lblSaltedHashAlgorithm.TabIndex = 26;
            this.lblSaltedHashAlgorithm.Text = "Hash Algorithm:";
            // 
            // txtFileToBeSaltedHashed
            // 
            this.txtFileToBeSaltedHashed.Location = new System.Drawing.Point(125, 96);
            this.txtFileToBeSaltedHashed.MaxLength = 255;
            this.txtFileToBeSaltedHashed.Name = "txtFileToBeSaltedHashed";
            this.txtFileToBeSaltedHashed.Size = new System.Drawing.Size(807, 20);
            this.txtFileToBeSaltedHashed.TabIndex = 25;
            this.txtFileToBeSaltedHashed.TextChanged += new System.EventHandler(this.txtFileToBeSaltedHashed_TextChanged);
            // 
            // txtTextToBeSaltedHashed
            // 
            this.txtTextToBeSaltedHashed.Location = new System.Drawing.Point(125, 70);
            this.txtTextToBeSaltedHashed.Name = "txtTextToBeSaltedHashed";
            this.txtTextToBeSaltedHashed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextToBeSaltedHashed.Size = new System.Drawing.Size(850, 20);
            this.txtTextToBeSaltedHashed.TabIndex = 23;
            this.txtTextToBeSaltedHashed.Text = "Lorem ipsum dolor sit amet.";
            this.txtTextToBeSaltedHashed.TextChanged += new System.EventHandler(this.txtTextToBeSaltedHashed_TextChanged);
            // 
            // tabMessageAuthenticationCode
            // 
            this.tabMessageAuthenticationCode.Controls.Add(this.rdoMacFileToBeHashed);
            this.tabMessageAuthenticationCode.Controls.Add(this.rdoMacTextToBeHashed);
            this.tabMessageAuthenticationCode.Controls.Add(this.txtMacAuthentication);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacAuthentication);
            this.tabMessageAuthenticationCode.Controls.Add(this.btnMacAuthenticateText);
            this.tabMessageAuthenticationCode.Controls.Add(this.txtMacSecretKey);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacSecretKey);
            this.tabMessageAuthenticationCode.Controls.Add(this.btnMacHashText);
            this.tabMessageAuthenticationCode.Controls.Add(this.cboMacEncoding);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacEncoding);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacDigestSizeBits);
            this.tabMessageAuthenticationCode.Controls.Add(this.txtMacDigestSize);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacDigestSize);
            this.tabMessageAuthenticationCode.Controls.Add(this.txtMacMessageDigest);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacMessageDigest);
            this.tabMessageAuthenticationCode.Controls.Add(this.cboMacAlgorithm);
            this.tabMessageAuthenticationCode.Controls.Add(this.lblMacAlgorithm);
            this.tabMessageAuthenticationCode.Controls.Add(this.btnMacChooseFile);
            this.tabMessageAuthenticationCode.Controls.Add(this.txtMacFileToBeHashed);
            this.tabMessageAuthenticationCode.Controls.Add(this.txtMacTextToBeHashed);
            this.tabMessageAuthenticationCode.Location = new System.Drawing.Point(4, 22);
            this.tabMessageAuthenticationCode.Name = "tabMessageAuthenticationCode";
            this.tabMessageAuthenticationCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessageAuthenticationCode.Size = new System.Drawing.Size(981, 950);
            this.tabMessageAuthenticationCode.TabIndex = 7;
            this.tabMessageAuthenticationCode.Text = "Message Authentication Code";
            this.tabMessageAuthenticationCode.UseVisualStyleBackColor = true;
            // 
            // rdoMacFileToBeHashed
            // 
            this.rdoMacFileToBeHashed.AutoSize = true;
            this.rdoMacFileToBeHashed.Location = new System.Drawing.Point(9, 273);
            this.rdoMacFileToBeHashed.Name = "rdoMacFileToBeHashed";
            this.rdoMacFileToBeHashed.Size = new System.Drawing.Size(109, 17);
            this.rdoMacFileToBeHashed.TabIndex = 68;
            this.rdoMacFileToBeHashed.Text = "File to be hashed:";
            this.rdoMacFileToBeHashed.UseVisualStyleBackColor = true;
            // 
            // rdoMacTextToBeHashed
            // 
            this.rdoMacTextToBeHashed.AutoSize = true;
            this.rdoMacTextToBeHashed.Checked = true;
            this.rdoMacTextToBeHashed.Location = new System.Drawing.Point(9, 97);
            this.rdoMacTextToBeHashed.Name = "rdoMacTextToBeHashed";
            this.rdoMacTextToBeHashed.Size = new System.Drawing.Size(114, 17);
            this.rdoMacTextToBeHashed.TabIndex = 67;
            this.rdoMacTextToBeHashed.TabStop = true;
            this.rdoMacTextToBeHashed.Text = "Text to be hashed:";
            this.rdoMacTextToBeHashed.UseVisualStyleBackColor = true;
            // 
            // txtMacAuthentication
            // 
            this.txtMacAuthentication.Location = new System.Drawing.Point(125, 379);
            this.txtMacAuthentication.Name = "txtMacAuthentication";
            this.txtMacAuthentication.ReadOnly = true;
            this.txtMacAuthentication.Size = new System.Drawing.Size(850, 20);
            this.txtMacAuthentication.TabIndex = 65;
            // 
            // lblMacAuthentication
            // 
            this.lblMacAuthentication.AutoSize = true;
            this.lblMacAuthentication.Location = new System.Drawing.Point(6, 382);
            this.lblMacAuthentication.Name = "lblMacAuthentication";
            this.lblMacAuthentication.Size = new System.Drawing.Size(78, 13);
            this.lblMacAuthentication.TabIndex = 64;
            this.lblMacAuthentication.Text = "Authentication:";
            // 
            // btnMacAuthenticateText
            // 
            this.btnMacAuthenticateText.Location = new System.Drawing.Point(252, 298);
            this.btnMacAuthenticateText.Name = "btnMacAuthenticateText";
            this.btnMacAuthenticateText.Size = new System.Drawing.Size(121, 23);
            this.btnMacAuthenticateText.TabIndex = 63;
            this.btnMacAuthenticateText.Text = "Authenticate";
            this.btnMacAuthenticateText.UseVisualStyleBackColor = true;
            this.btnMacAuthenticateText.Click += new System.EventHandler(this.btnMacAuthenticateText_Click);
            // 
            // txtMacSecretKey
            // 
            this.txtMacSecretKey.Location = new System.Drawing.Point(125, 70);
            this.txtMacSecretKey.MaxLength = 255;
            this.txtMacSecretKey.Name = "txtMacSecretKey";
            this.txtMacSecretKey.PasswordChar = '*';
            this.txtMacSecretKey.Size = new System.Drawing.Size(850, 20);
            this.txtMacSecretKey.TabIndex = 62;
            this.txtMacSecretKey.Text = "2b|n2b,tiht?";
            this.txtMacSecretKey.TextChanged += new System.EventHandler(this.txtMacSecretKey_TextChanged);
            // 
            // lblMacSecretKey
            // 
            this.lblMacSecretKey.AutoSize = true;
            this.lblMacSecretKey.Location = new System.Drawing.Point(6, 73);
            this.lblMacSecretKey.Name = "lblMacSecretKey";
            this.lblMacSecretKey.Size = new System.Drawing.Size(65, 13);
            this.lblMacSecretKey.TabIndex = 61;
            this.lblMacSecretKey.Text = "Passphrase:";
            // 
            // btnMacHashText
            // 
            this.btnMacHashText.Location = new System.Drawing.Point(125, 298);
            this.btnMacHashText.Name = "btnMacHashText";
            this.btnMacHashText.Size = new System.Drawing.Size(121, 23);
            this.btnMacHashText.TabIndex = 37;
            this.btnMacHashText.Text = "Hash";
            this.btnMacHashText.UseVisualStyleBackColor = true;
            this.btnMacHashText.Click += new System.EventHandler(this.btnMacHashText_Click);
            // 
            // cboMacEncoding
            // 
            this.cboMacEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMacEncoding.FormattingEnabled = true;
            this.cboMacEncoding.Location = new System.Drawing.Point(125, 43);
            this.cboMacEncoding.Name = "cboMacEncoding";
            this.cboMacEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboMacEncoding.Sorted = true;
            this.cboMacEncoding.TabIndex = 36;
            this.cboMacEncoding.SelectedIndexChanged += new System.EventHandler(this.cboMacEncoding_SelectedIndexChanged);
            // 
            // lblMacEncoding
            // 
            this.lblMacEncoding.AutoSize = true;
            this.lblMacEncoding.Location = new System.Drawing.Point(6, 46);
            this.lblMacEncoding.Name = "lblMacEncoding";
            this.lblMacEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblMacEncoding.TabIndex = 35;
            this.lblMacEncoding.Text = "Encoding:";
            // 
            // lblMacDigestSizeBits
            // 
            this.lblMacDigestSizeBits.AutoSize = true;
            this.lblMacDigestSizeBits.Location = new System.Drawing.Point(252, 356);
            this.lblMacDigestSizeBits.Name = "lblMacDigestSizeBits";
            this.lblMacDigestSizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblMacDigestSizeBits.TabIndex = 34;
            this.lblMacDigestSizeBits.Text = "bits";
            // 
            // txtMacDigestSize
            // 
            this.txtMacDigestSize.Location = new System.Drawing.Point(125, 353);
            this.txtMacDigestSize.Name = "txtMacDigestSize";
            this.txtMacDigestSize.ReadOnly = true;
            this.txtMacDigestSize.Size = new System.Drawing.Size(121, 20);
            this.txtMacDigestSize.TabIndex = 33;
            // 
            // lblMacDigestSize
            // 
            this.lblMacDigestSize.AutoSize = true;
            this.lblMacDigestSize.Location = new System.Drawing.Point(6, 356);
            this.lblMacDigestSize.Name = "lblMacDigestSize";
            this.lblMacDigestSize.Size = new System.Drawing.Size(63, 13);
            this.lblMacDigestSize.TabIndex = 32;
            this.lblMacDigestSize.Text = "Digest Size:";
            // 
            // txtMacMessageDigest
            // 
            this.txtMacMessageDigest.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtMacMessageDigest.Location = new System.Drawing.Point(125, 327);
            this.txtMacMessageDigest.Name = "txtMacMessageDigest";
            this.txtMacMessageDigest.ReadOnly = true;
            this.txtMacMessageDigest.Size = new System.Drawing.Size(850, 20);
            this.txtMacMessageDigest.TabIndex = 31;
            // 
            // lblMacMessageDigest
            // 
            this.lblMacMessageDigest.AutoSize = true;
            this.lblMacMessageDigest.Location = new System.Drawing.Point(6, 330);
            this.lblMacMessageDigest.Name = "lblMacMessageDigest";
            this.lblMacMessageDigest.Size = new System.Drawing.Size(86, 13);
            this.lblMacMessageDigest.TabIndex = 29;
            this.lblMacMessageDigest.Text = "Message Digest:";
            // 
            // cboMacAlgorithm
            // 
            this.cboMacAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMacAlgorithm.FormattingEnabled = true;
            this.cboMacAlgorithm.Location = new System.Drawing.Point(125, 16);
            this.cboMacAlgorithm.Name = "cboMacAlgorithm";
            this.cboMacAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboMacAlgorithm.TabIndex = 28;
            this.cboMacAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboMacAlgorithm_SelectedIndexChanged);
            // 
            // lblMacAlgorithm
            // 
            this.lblMacAlgorithm.AutoSize = true;
            this.lblMacAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.lblMacAlgorithm.Name = "lblMacAlgorithm";
            this.lblMacAlgorithm.Size = new System.Drawing.Size(79, 13);
            this.lblMacAlgorithm.TabIndex = 27;
            this.lblMacAlgorithm.Text = "MAC Algorithm:";
            // 
            // btnMacChooseFile
            // 
            this.btnMacChooseFile.Location = new System.Drawing.Point(938, 270);
            this.btnMacChooseFile.Name = "btnMacChooseFile";
            this.btnMacChooseFile.Size = new System.Drawing.Size(37, 23);
            this.btnMacChooseFile.TabIndex = 26;
            this.btnMacChooseFile.Text = "...";
            this.btnMacChooseFile.UseVisualStyleBackColor = true;
            this.btnMacChooseFile.Click += new System.EventHandler(this.btnMacChooseFile_Click);
            // 
            // txtMacFileToBeHashed
            // 
            this.txtMacFileToBeHashed.Location = new System.Drawing.Point(125, 272);
            this.txtMacFileToBeHashed.MaxLength = 255;
            this.txtMacFileToBeHashed.Name = "txtMacFileToBeHashed";
            this.txtMacFileToBeHashed.Size = new System.Drawing.Size(807, 20);
            this.txtMacFileToBeHashed.TabIndex = 25;
            this.txtMacFileToBeHashed.TextChanged += new System.EventHandler(this.txtMacFileToBeHashed_TextChanged);
            // 
            // txtMacTextToBeHashed
            // 
            this.txtMacTextToBeHashed.Location = new System.Drawing.Point(125, 96);
            this.txtMacTextToBeHashed.Multiline = true;
            this.txtMacTextToBeHashed.Name = "txtMacTextToBeHashed";
            this.txtMacTextToBeHashed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMacTextToBeHashed.Size = new System.Drawing.Size(850, 170);
            this.txtMacTextToBeHashed.TabIndex = 23;
            this.txtMacTextToBeHashed.Text = resources.GetString("txtMacTextToBeHashed.Text");
            this.txtMacTextToBeHashed.TextChanged += new System.EventHandler(this.txtMacTextToBeHashed_TextChanged);
            // 
            // tabSymmetricEncryption
            // 
            this.tabSymmetricEncryption.Controls.Add(this.btnDeriveSymmetricKeyFromPassphrase);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricEncryptionPassphrase);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricEncryptionPassphrase);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricBlockSize);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricKeySize);
            this.tabSymmetricEncryption.Controls.Add(this.cboSymmetricEncoding);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricEncoding);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricallyDecryptedValue);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricallyDecryptedValue);
            this.tabSymmetricEncryption.Controls.Add(this.btnDecryptSymmetrically);
            this.tabSymmetricEncryption.Controls.Add(this.cboSymmetricPaddingMode);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricPaddingMode);
            this.tabSymmetricEncryption.Controls.Add(this.cboSymmetricCipherMode);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricCipherMode);
            this.tabSymmetricEncryption.Controls.Add(this.btnCreateInitializationVector);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricBlockSizeBits);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricKeySizeBits);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricBlockSize);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricKeySize);
            this.tabSymmetricEncryption.Controls.Add(this.cboSymmetricAlgorithm);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricAlgorithm);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricEncryptionInitializationVector);
            this.tabSymmetricEncryption.Controls.Add(this.lblEncryptedValueSizeBytes);
            this.tabSymmetricEncryption.Controls.Add(this.txtEncryptedValueSize);
            this.tabSymmetricEncryption.Controls.Add(this.lblEncryptedValueSize);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricallyEncryptedValue);
            this.tabSymmetricEncryption.Controls.Add(this.btnEncryptSymmetrically);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricallyEncryptedValue);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricEncryptionInitializationVector);
            this.tabSymmetricEncryption.Controls.Add(this.btnCreateSymmetricKey);
            this.tabSymmetricEncryption.Controls.Add(this.txtSymmetricKey);
            this.tabSymmetricEncryption.Controls.Add(this.lblSymmetricKey);
            this.tabSymmetricEncryption.Controls.Add(this.txtInputToBeSymmetricallyEncrypted);
            this.tabSymmetricEncryption.Controls.Add(this.lblTextToBeSymmetricallyEncrypted);
            this.tabSymmetricEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabSymmetricEncryption.Name = "tabSymmetricEncryption";
            this.tabSymmetricEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabSymmetricEncryption.Size = new System.Drawing.Size(981, 950);
            this.tabSymmetricEncryption.TabIndex = 1;
            this.tabSymmetricEncryption.Text = "Symmetric Encryption";
            this.tabSymmetricEncryption.UseVisualStyleBackColor = true;
            // 
            // btnDeriveSymmetricKeyFromPassphrase
            // 
            this.btnDeriveSymmetricKeyFromPassphrase.Location = new System.Drawing.Point(821, 146);
            this.btnDeriveSymmetricKeyFromPassphrase.Name = "btnDeriveSymmetricKeyFromPassphrase";
            this.btnDeriveSymmetricKeyFromPassphrase.Size = new System.Drawing.Size(154, 23);
            this.btnDeriveSymmetricKeyFromPassphrase.TabIndex = 61;
            this.btnDeriveSymmetricKeyFromPassphrase.Text = "Derive Key and  IV";
            this.btnDeriveSymmetricKeyFromPassphrase.UseVisualStyleBackColor = true;
            this.btnDeriveSymmetricKeyFromPassphrase.Click += new System.EventHandler(this.btnDeriveSymmetricKeyFromPassphrase_Click);
            // 
            // txtSymmetricEncryptionPassphrase
            // 
            this.txtSymmetricEncryptionPassphrase.Location = new System.Drawing.Point(138, 149);
            this.txtSymmetricEncryptionPassphrase.MaxLength = 255;
            this.txtSymmetricEncryptionPassphrase.Name = "txtSymmetricEncryptionPassphrase";
            this.txtSymmetricEncryptionPassphrase.PasswordChar = '*';
            this.txtSymmetricEncryptionPassphrase.Size = new System.Drawing.Size(677, 20);
            this.txtSymmetricEncryptionPassphrase.TabIndex = 60;
            this.txtSymmetricEncryptionPassphrase.Text = "2b|n2b,tiht?";
            // 
            // lblSymmetricEncryptionPassphrase
            // 
            this.lblSymmetricEncryptionPassphrase.AutoSize = true;
            this.lblSymmetricEncryptionPassphrase.Location = new System.Drawing.Point(7, 152);
            this.lblSymmetricEncryptionPassphrase.Name = "lblSymmetricEncryptionPassphrase";
            this.lblSymmetricEncryptionPassphrase.Size = new System.Drawing.Size(65, 13);
            this.lblSymmetricEncryptionPassphrase.TabIndex = 59;
            this.lblSymmetricEncryptionPassphrase.Text = "Passphrase:";
            // 
            // txtSymmetricBlockSize
            // 
            this.txtSymmetricBlockSize.Location = new System.Drawing.Point(138, 69);
            this.txtSymmetricBlockSize.MaxLength = 4;
            this.txtSymmetricBlockSize.Name = "txtSymmetricBlockSize";
            this.txtSymmetricBlockSize.Size = new System.Drawing.Size(119, 20);
            this.txtSymmetricBlockSize.TabIndex = 58;
            this.txtSymmetricBlockSize.TextChanged += new System.EventHandler(this.txtSymmetricBlockSize_TextChanged);
            // 
            // txtSymmetricKeySize
            // 
            this.txtSymmetricKeySize.Location = new System.Drawing.Point(138, 43);
            this.txtSymmetricKeySize.MaxLength = 4;
            this.txtSymmetricKeySize.Name = "txtSymmetricKeySize";
            this.txtSymmetricKeySize.Size = new System.Drawing.Size(119, 20);
            this.txtSymmetricKeySize.TabIndex = 57;
            this.txtSymmetricKeySize.TextChanged += new System.EventHandler(this.txtSymmetricKeySize_TextChanged);
            // 
            // cboSymmetricEncoding
            // 
            this.cboSymmetricEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymmetricEncoding.FormattingEnabled = true;
            this.cboSymmetricEncoding.Location = new System.Drawing.Point(138, 226);
            this.cboSymmetricEncoding.Name = "cboSymmetricEncoding";
            this.cboSymmetricEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboSymmetricEncoding.Sorted = true;
            this.cboSymmetricEncoding.TabIndex = 56;
            this.cboSymmetricEncoding.SelectedIndexChanged += new System.EventHandler(this.cboSymmetricEncoding_SelectedIndexChanged);
            // 
            // lblSymmetricEncoding
            // 
            this.lblSymmetricEncoding.AutoSize = true;
            this.lblSymmetricEncoding.Location = new System.Drawing.Point(7, 229);
            this.lblSymmetricEncoding.Name = "lblSymmetricEncoding";
            this.lblSymmetricEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblSymmetricEncoding.TabIndex = 55;
            this.lblSymmetricEncoding.Text = "Encoding:";
            // 
            // txtSymmetricallyDecryptedValue
            // 
            this.txtSymmetricallyDecryptedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSymmetricallyDecryptedValue.Location = new System.Drawing.Point(138, 549);
            this.txtSymmetricallyDecryptedValue.Multiline = true;
            this.txtSymmetricallyDecryptedValue.Name = "txtSymmetricallyDecryptedValue";
            this.txtSymmetricallyDecryptedValue.ReadOnly = true;
            this.txtSymmetricallyDecryptedValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSymmetricallyDecryptedValue.Size = new System.Drawing.Size(839, 100);
            this.txtSymmetricallyDecryptedValue.TabIndex = 54;
            // 
            // lblSymmetricallyDecryptedValue
            // 
            this.lblSymmetricallyDecryptedValue.AutoSize = true;
            this.lblSymmetricallyDecryptedValue.Location = new System.Drawing.Point(7, 552);
            this.lblSymmetricallyDecryptedValue.Name = "lblSymmetricallyDecryptedValue";
            this.lblSymmetricallyDecryptedValue.Size = new System.Drawing.Size(85, 13);
            this.lblSymmetricallyDecryptedValue.TabIndex = 53;
            this.lblSymmetricallyDecryptedValue.Text = "Decrypted Data:";
            // 
            // btnDecryptSymmetrically
            // 
            this.btnDecryptSymmetrically.Location = new System.Drawing.Point(138, 520);
            this.btnDecryptSymmetrically.Name = "btnDecryptSymmetrically";
            this.btnDecryptSymmetrically.Size = new System.Drawing.Size(121, 23);
            this.btnDecryptSymmetrically.TabIndex = 52;
            this.btnDecryptSymmetrically.Text = "Decrypt";
            this.btnDecryptSymmetrically.UseVisualStyleBackColor = true;
            this.btnDecryptSymmetrically.Click += new System.EventHandler(this.btnDecryptSymmetrically_Click);
            // 
            // cboSymmetricPaddingMode
            // 
            this.cboSymmetricPaddingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymmetricPaddingMode.FormattingEnabled = true;
            this.cboSymmetricPaddingMode.Location = new System.Drawing.Point(138, 122);
            this.cboSymmetricPaddingMode.Name = "cboSymmetricPaddingMode";
            this.cboSymmetricPaddingMode.Size = new System.Drawing.Size(119, 21);
            this.cboSymmetricPaddingMode.TabIndex = 51;
            this.cboSymmetricPaddingMode.SelectedIndexChanged += new System.EventHandler(this.cboSymmetricPaddingMode_SelectedIndexChanged);
            // 
            // lblSymmetricPaddingMode
            // 
            this.lblSymmetricPaddingMode.AutoSize = true;
            this.lblSymmetricPaddingMode.Location = new System.Drawing.Point(7, 125);
            this.lblSymmetricPaddingMode.Name = "lblSymmetricPaddingMode";
            this.lblSymmetricPaddingMode.Size = new System.Drawing.Size(79, 13);
            this.lblSymmetricPaddingMode.TabIndex = 50;
            this.lblSymmetricPaddingMode.Text = "Padding Mode:";
            // 
            // cboSymmetricCipherMode
            // 
            this.cboSymmetricCipherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymmetricCipherMode.FormattingEnabled = true;
            this.cboSymmetricCipherMode.Location = new System.Drawing.Point(138, 95);
            this.cboSymmetricCipherMode.Name = "cboSymmetricCipherMode";
            this.cboSymmetricCipherMode.Size = new System.Drawing.Size(119, 21);
            this.cboSymmetricCipherMode.TabIndex = 49;
            this.cboSymmetricCipherMode.SelectedIndexChanged += new System.EventHandler(this.cboSymmetricCipherMode_SelectedIndexChanged);
            // 
            // lblSymmetricCipherMode
            // 
            this.lblSymmetricCipherMode.AutoSize = true;
            this.lblSymmetricCipherMode.Location = new System.Drawing.Point(7, 98);
            this.lblSymmetricCipherMode.Name = "lblSymmetricCipherMode";
            this.lblSymmetricCipherMode.Size = new System.Drawing.Size(70, 13);
            this.lblSymmetricCipherMode.TabIndex = 48;
            this.lblSymmetricCipherMode.Text = "Cipher Mode:";
            // 
            // btnCreateInitializationVector
            // 
            this.btnCreateInitializationVector.Location = new System.Drawing.Point(821, 198);
            this.btnCreateInitializationVector.Name = "btnCreateInitializationVector";
            this.btnCreateInitializationVector.Size = new System.Drawing.Size(154, 23);
            this.btnCreateInitializationVector.TabIndex = 47;
            this.btnCreateInitializationVector.Text = "Create Initialization Vector";
            this.btnCreateInitializationVector.UseVisualStyleBackColor = true;
            this.btnCreateInitializationVector.Click += new System.EventHandler(this.btnCreateInitializationVector_Click);
            // 
            // lblSymmetricBlockSizeBits
            // 
            this.lblSymmetricBlockSizeBits.AutoSize = true;
            this.lblSymmetricBlockSizeBits.Location = new System.Drawing.Point(263, 72);
            this.lblSymmetricBlockSizeBits.Name = "lblSymmetricBlockSizeBits";
            this.lblSymmetricBlockSizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblSymmetricBlockSizeBits.TabIndex = 46;
            this.lblSymmetricBlockSizeBits.Text = "bits";
            // 
            // lblSymmetricKeySizeBits
            // 
            this.lblSymmetricKeySizeBits.AutoSize = true;
            this.lblSymmetricKeySizeBits.Location = new System.Drawing.Point(263, 46);
            this.lblSymmetricKeySizeBits.Name = "lblSymmetricKeySizeBits";
            this.lblSymmetricKeySizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblSymmetricKeySizeBits.TabIndex = 45;
            this.lblSymmetricKeySizeBits.Text = "bits";
            // 
            // lblSymmetricBlockSize
            // 
            this.lblSymmetricBlockSize.AutoSize = true;
            this.lblSymmetricBlockSize.Location = new System.Drawing.Point(7, 72);
            this.lblSymmetricBlockSize.Name = "lblSymmetricBlockSize";
            this.lblSymmetricBlockSize.Size = new System.Drawing.Size(60, 13);
            this.lblSymmetricBlockSize.TabIndex = 43;
            this.lblSymmetricBlockSize.Text = "Block Size:";
            // 
            // lblSymmetricKeySize
            // 
            this.lblSymmetricKeySize.AutoSize = true;
            this.lblSymmetricKeySize.Location = new System.Drawing.Point(7, 46);
            this.lblSymmetricKeySize.Name = "lblSymmetricKeySize";
            this.lblSymmetricKeySize.Size = new System.Drawing.Size(51, 13);
            this.lblSymmetricKeySize.TabIndex = 41;
            this.lblSymmetricKeySize.Text = "Key Size:";
            // 
            // cboSymmetricAlgorithm
            // 
            this.cboSymmetricAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymmetricAlgorithm.FormattingEnabled = true;
            this.cboSymmetricAlgorithm.Location = new System.Drawing.Point(138, 16);
            this.cboSymmetricAlgorithm.Name = "cboSymmetricAlgorithm";
            this.cboSymmetricAlgorithm.Size = new System.Drawing.Size(119, 21);
            this.cboSymmetricAlgorithm.TabIndex = 40;
            this.cboSymmetricAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboSymmetricAlgorithm_SelectedIndexChanged);
            // 
            // lblSymmetricAlgorithm
            // 
            this.lblSymmetricAlgorithm.AutoSize = true;
            this.lblSymmetricAlgorithm.Location = new System.Drawing.Point(7, 19);
            this.lblSymmetricAlgorithm.Name = "lblSymmetricAlgorithm";
            this.lblSymmetricAlgorithm.Size = new System.Drawing.Size(104, 13);
            this.lblSymmetricAlgorithm.TabIndex = 39;
            this.lblSymmetricAlgorithm.Text = "Symmetric Algorithm:";
            // 
            // txtSymmetricEncryptionInitializationVector
            // 
            this.txtSymmetricEncryptionInitializationVector.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtSymmetricEncryptionInitializationVector.Location = new System.Drawing.Point(138, 200);
            this.txtSymmetricEncryptionInitializationVector.Name = "txtSymmetricEncryptionInitializationVector";
            this.txtSymmetricEncryptionInitializationVector.ReadOnly = true;
            this.txtSymmetricEncryptionInitializationVector.Size = new System.Drawing.Size(677, 20);
            this.txtSymmetricEncryptionInitializationVector.TabIndex = 38;
            this.txtSymmetricEncryptionInitializationVector.TextChanged += new System.EventHandler(this.txtSymmetricEncryptionInitializationVector_TextChanged);
            // 
            // lblEncryptedValueSizeBytes
            // 
            this.lblEncryptedValueSizeBytes.AutoSize = true;
            this.lblEncryptedValueSizeBytes.Location = new System.Drawing.Point(261, 497);
            this.lblEncryptedValueSizeBytes.Name = "lblEncryptedValueSizeBytes";
            this.lblEncryptedValueSizeBytes.Size = new System.Drawing.Size(32, 13);
            this.lblEncryptedValueSizeBytes.TabIndex = 34;
            this.lblEncryptedValueSizeBytes.Text = "bytes";
            // 
            // txtEncryptedValueSize
            // 
            this.txtEncryptedValueSize.Location = new System.Drawing.Point(138, 494);
            this.txtEncryptedValueSize.Name = "txtEncryptedValueSize";
            this.txtEncryptedValueSize.ReadOnly = true;
            this.txtEncryptedValueSize.Size = new System.Drawing.Size(121, 20);
            this.txtEncryptedValueSize.TabIndex = 33;
            // 
            // lblEncryptedValueSize
            // 
            this.lblEncryptedValueSize.AutoSize = true;
            this.lblEncryptedValueSize.Location = new System.Drawing.Point(7, 497);
            this.lblEncryptedValueSize.Name = "lblEncryptedValueSize";
            this.lblEncryptedValueSize.Size = new System.Drawing.Size(83, 13);
            this.lblEncryptedValueSize.TabIndex = 32;
            this.lblEncryptedValueSize.Text = "Encryption Size:";
            // 
            // txtSymmetricallyEncryptedValue
            // 
            this.txtSymmetricallyEncryptedValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtSymmetricallyEncryptedValue.Location = new System.Drawing.Point(138, 388);
            this.txtSymmetricallyEncryptedValue.Multiline = true;
            this.txtSymmetricallyEncryptedValue.Name = "txtSymmetricallyEncryptedValue";
            this.txtSymmetricallyEncryptedValue.ReadOnly = true;
            this.txtSymmetricallyEncryptedValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSymmetricallyEncryptedValue.Size = new System.Drawing.Size(837, 100);
            this.txtSymmetricallyEncryptedValue.TabIndex = 28;
            // 
            // btnEncryptSymmetrically
            // 
            this.btnEncryptSymmetrically.Location = new System.Drawing.Point(138, 359);
            this.btnEncryptSymmetrically.Name = "btnEncryptSymmetrically";
            this.btnEncryptSymmetrically.Size = new System.Drawing.Size(121, 23);
            this.btnEncryptSymmetrically.TabIndex = 27;
            this.btnEncryptSymmetrically.Text = "Encrypt";
            this.btnEncryptSymmetrically.UseVisualStyleBackColor = true;
            this.btnEncryptSymmetrically.Click += new System.EventHandler(this.btnEncryptSymmetrically_Click);
            // 
            // lblSymmetricallyEncryptedValue
            // 
            this.lblSymmetricallyEncryptedValue.AutoSize = true;
            this.lblSymmetricallyEncryptedValue.Location = new System.Drawing.Point(7, 391);
            this.lblSymmetricallyEncryptedValue.Name = "lblSymmetricallyEncryptedValue";
            this.lblSymmetricallyEncryptedValue.Size = new System.Drawing.Size(84, 13);
            this.lblSymmetricallyEncryptedValue.TabIndex = 26;
            this.lblSymmetricallyEncryptedValue.Text = "Encrypted Data:";
            // 
            // lblSymmetricEncryptionInitializationVector
            // 
            this.lblSymmetricEncryptionInitializationVector.AutoSize = true;
            this.lblSymmetricEncryptionInitializationVector.Location = new System.Drawing.Point(7, 203);
            this.lblSymmetricEncryptionInitializationVector.Name = "lblSymmetricEncryptionInitializationVector";
            this.lblSymmetricEncryptionInitializationVector.Size = new System.Drawing.Size(98, 13);
            this.lblSymmetricEncryptionInitializationVector.TabIndex = 24;
            this.lblSymmetricEncryptionInitializationVector.Text = "Initialization Vector:";
            // 
            // btnCreateSymmetricKey
            // 
            this.btnCreateSymmetricKey.Location = new System.Drawing.Point(821, 172);
            this.btnCreateSymmetricKey.Name = "btnCreateSymmetricKey";
            this.btnCreateSymmetricKey.Size = new System.Drawing.Size(154, 23);
            this.btnCreateSymmetricKey.TabIndex = 23;
            this.btnCreateSymmetricKey.Text = "Create Key";
            this.btnCreateSymmetricKey.UseVisualStyleBackColor = true;
            this.btnCreateSymmetricKey.Click += new System.EventHandler(this.btnCreateSymmetricKey_Click);
            // 
            // txtSymmetricKey
            // 
            this.txtSymmetricKey.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtSymmetricKey.Location = new System.Drawing.Point(138, 174);
            this.txtSymmetricKey.Name = "txtSymmetricKey";
            this.txtSymmetricKey.ReadOnly = true;
            this.txtSymmetricKey.Size = new System.Drawing.Size(677, 20);
            this.txtSymmetricKey.TabIndex = 22;
            this.txtSymmetricKey.TextChanged += new System.EventHandler(this.txtSymmetricKey_TextChanged);
            // 
            // lblSymmetricKey
            // 
            this.lblSymmetricKey.AutoSize = true;
            this.lblSymmetricKey.Location = new System.Drawing.Point(7, 177);
            this.lblSymmetricKey.Name = "lblSymmetricKey";
            this.lblSymmetricKey.Size = new System.Drawing.Size(28, 13);
            this.lblSymmetricKey.TabIndex = 21;
            this.lblSymmetricKey.Text = "Key:";
            // 
            // txtInputToBeSymmetricallyEncrypted
            // 
            this.txtInputToBeSymmetricallyEncrypted.Location = new System.Drawing.Point(138, 253);
            this.txtInputToBeSymmetricallyEncrypted.Multiline = true;
            this.txtInputToBeSymmetricallyEncrypted.Name = "txtInputToBeSymmetricallyEncrypted";
            this.txtInputToBeSymmetricallyEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInputToBeSymmetricallyEncrypted.Size = new System.Drawing.Size(837, 100);
            this.txtInputToBeSymmetricallyEncrypted.TabIndex = 20;
            this.txtInputToBeSymmetricallyEncrypted.Text = resources.GetString("txtInputToBeSymmetricallyEncrypted.Text");
            this.txtInputToBeSymmetricallyEncrypted.TextChanged += new System.EventHandler(this.txtInputToBeSymmetricallyEncrypted_TextChanged);
            // 
            // lblTextToBeSymmetricallyEncrypted
            // 
            this.lblTextToBeSymmetricallyEncrypted.AutoSize = true;
            this.lblTextToBeSymmetricallyEncrypted.Location = new System.Drawing.Point(7, 256);
            this.lblTextToBeSymmetricallyEncrypted.Name = "lblTextToBeSymmetricallyEncrypted";
            this.lblTextToBeSymmetricallyEncrypted.Size = new System.Drawing.Size(108, 13);
            this.lblTextToBeSymmetricallyEncrypted.TabIndex = 19;
            this.lblTextToBeSymmetricallyEncrypted.Text = "Text to be encrypted:";
            // 
            // tabAsymmetricAlgorithm
            // 
            this.tabAsymmetricAlgorithm.Controls.Add(this.cboAsymmetricEncryptionPaddingMode);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricEncryptionPaddingMode);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricallyEncryptedValueSizeBytes);
            this.tabAsymmetricAlgorithm.Controls.Add(this.cboAsymmetricEncoding);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricEncoding);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricallyDecryptedValue);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricallyDecryptedValue);
            this.tabAsymmetricAlgorithm.Controls.Add(this.btnAsymmetricallyDecrypt);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricallyEncryptedValueSize);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricallyEncryptedValueSize);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricallyEncryptedValue);
            this.tabAsymmetricAlgorithm.Controls.Add(this.btnEncryptAsymmetrically);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricallyEncryptedValue);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricTextToBeEncrypted);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricTextToBeEncrypted);
            this.tabAsymmetricAlgorithm.Controls.Add(this.btnCreateAsymmetricKey);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtPublicPrivateKey);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblPublicPrivateKey);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricKeyExchangeAlgorithm);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricKeyExchangeAlgorithm);
            this.tabAsymmetricAlgorithm.Controls.Add(this.txtAsymmetricKeySize);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricKeySizeBits);
            this.tabAsymmetricAlgorithm.Controls.Add(this.lblAsymmetricKeySize);
            this.tabAsymmetricAlgorithm.Controls.Add(this.cboAsymmetricAlgorithm);
            this.tabAsymmetricAlgorithm.Controls.Add(this.label1);
            this.tabAsymmetricAlgorithm.Location = new System.Drawing.Point(4, 22);
            this.tabAsymmetricAlgorithm.Name = "tabAsymmetricAlgorithm";
            this.tabAsymmetricAlgorithm.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsymmetricAlgorithm.Size = new System.Drawing.Size(981, 950);
            this.tabAsymmetricAlgorithm.TabIndex = 2;
            this.tabAsymmetricAlgorithm.Text = "Asymmetric Encryption";
            this.tabAsymmetricAlgorithm.UseVisualStyleBackColor = true;
            // 
            // cboAsymmetricEncryptionPaddingMode
            // 
            this.cboAsymmetricEncryptionPaddingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsymmetricEncryptionPaddingMode.FormattingEnabled = true;
            this.cboAsymmetricEncryptionPaddingMode.Location = new System.Drawing.Point(138, 69);
            this.cboAsymmetricEncryptionPaddingMode.Name = "cboAsymmetricEncryptionPaddingMode";
            this.cboAsymmetricEncryptionPaddingMode.Size = new System.Drawing.Size(837, 21);
            this.cboAsymmetricEncryptionPaddingMode.TabIndex = 82;
            this.cboAsymmetricEncryptionPaddingMode.SelectedIndexChanged += new System.EventHandler(this.cboAsymmetricEncryptionPaddingMode_SelectedIndexChanged);
            // 
            // lblAsymmetricEncryptionPaddingMode
            // 
            this.lblAsymmetricEncryptionPaddingMode.AutoSize = true;
            this.lblAsymmetricEncryptionPaddingMode.Location = new System.Drawing.Point(7, 74);
            this.lblAsymmetricEncryptionPaddingMode.Name = "lblAsymmetricEncryptionPaddingMode";
            this.lblAsymmetricEncryptionPaddingMode.Size = new System.Drawing.Size(79, 13);
            this.lblAsymmetricEncryptionPaddingMode.TabIndex = 81;
            this.lblAsymmetricEncryptionPaddingMode.Text = "Padding Mode:";
            // 
            // txtAsymmetricallyEncryptedValueSizeBytes
            // 
            this.txtAsymmetricallyEncryptedValueSizeBytes.AutoSize = true;
            this.txtAsymmetricallyEncryptedValueSizeBytes.Location = new System.Drawing.Point(265, 494);
            this.txtAsymmetricallyEncryptedValueSizeBytes.Name = "txtAsymmetricallyEncryptedValueSizeBytes";
            this.txtAsymmetricallyEncryptedValueSizeBytes.Size = new System.Drawing.Size(32, 13);
            this.txtAsymmetricallyEncryptedValueSizeBytes.TabIndex = 80;
            this.txtAsymmetricallyEncryptedValueSizeBytes.Text = "bytes";
            // 
            // cboAsymmetricEncoding
            // 
            this.cboAsymmetricEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsymmetricEncoding.FormattingEnabled = true;
            this.cboAsymmetricEncoding.Location = new System.Drawing.Point(138, 303);
            this.cboAsymmetricEncoding.Name = "cboAsymmetricEncoding";
            this.cboAsymmetricEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboAsymmetricEncoding.Sorted = true;
            this.cboAsymmetricEncoding.TabIndex = 79;
            this.cboAsymmetricEncoding.SelectedIndexChanged += new System.EventHandler(this.cboAsymmetricEncoding_SelectedIndexChanged);
            // 
            // lblAsymmetricEncoding
            // 
            this.lblAsymmetricEncoding.AutoSize = true;
            this.lblAsymmetricEncoding.Location = new System.Drawing.Point(7, 308);
            this.lblAsymmetricEncoding.Name = "lblAsymmetricEncoding";
            this.lblAsymmetricEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblAsymmetricEncoding.TabIndex = 78;
            this.lblAsymmetricEncoding.Text = "Encoding:";
            // 
            // txtAsymmetricallyDecryptedValue
            // 
            this.txtAsymmetricallyDecryptedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAsymmetricallyDecryptedValue.Location = new System.Drawing.Point(138, 546);
            this.txtAsymmetricallyDecryptedValue.Multiline = true;
            this.txtAsymmetricallyDecryptedValue.Name = "txtAsymmetricallyDecryptedValue";
            this.txtAsymmetricallyDecryptedValue.ReadOnly = true;
            this.txtAsymmetricallyDecryptedValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAsymmetricallyDecryptedValue.Size = new System.Drawing.Size(850, 100);
            this.txtAsymmetricallyDecryptedValue.TabIndex = 77;
            // 
            // lblAsymmetricallyDecryptedValue
            // 
            this.lblAsymmetricallyDecryptedValue.AutoSize = true;
            this.lblAsymmetricallyDecryptedValue.Location = new System.Drawing.Point(7, 551);
            this.lblAsymmetricallyDecryptedValue.Name = "lblAsymmetricallyDecryptedValue";
            this.lblAsymmetricallyDecryptedValue.Size = new System.Drawing.Size(85, 13);
            this.lblAsymmetricallyDecryptedValue.TabIndex = 76;
            this.lblAsymmetricallyDecryptedValue.Text = "Decrypted Data:";
            // 
            // btnAsymmetricallyDecrypt
            // 
            this.btnAsymmetricallyDecrypt.Location = new System.Drawing.Point(138, 517);
            this.btnAsymmetricallyDecrypt.Name = "btnAsymmetricallyDecrypt";
            this.btnAsymmetricallyDecrypt.Size = new System.Drawing.Size(121, 23);
            this.btnAsymmetricallyDecrypt.TabIndex = 75;
            this.btnAsymmetricallyDecrypt.Text = "Decrypt";
            this.btnAsymmetricallyDecrypt.UseVisualStyleBackColor = true;
            this.btnAsymmetricallyDecrypt.Click += new System.EventHandler(this.btnAsymmetricallyDecrypt_Click);
            // 
            // txtAsymmetricallyEncryptedValueSize
            // 
            this.txtAsymmetricallyEncryptedValueSize.Location = new System.Drawing.Point(138, 491);
            this.txtAsymmetricallyEncryptedValueSize.Name = "txtAsymmetricallyEncryptedValueSize";
            this.txtAsymmetricallyEncryptedValueSize.ReadOnly = true;
            this.txtAsymmetricallyEncryptedValueSize.Size = new System.Drawing.Size(121, 20);
            this.txtAsymmetricallyEncryptedValueSize.TabIndex = 74;
            // 
            // lblAsymmetricallyEncryptedValueSize
            // 
            this.lblAsymmetricallyEncryptedValueSize.AutoSize = true;
            this.lblAsymmetricallyEncryptedValueSize.Location = new System.Drawing.Point(7, 494);
            this.lblAsymmetricallyEncryptedValueSize.Name = "lblAsymmetricallyEncryptedValueSize";
            this.lblAsymmetricallyEncryptedValueSize.Size = new System.Drawing.Size(83, 13);
            this.lblAsymmetricallyEncryptedValueSize.TabIndex = 73;
            this.lblAsymmetricallyEncryptedValueSize.Text = "Encryption Size:";
            // 
            // txtAsymmetricallyEncryptedValue
            // 
            this.txtAsymmetricallyEncryptedValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtAsymmetricallyEncryptedValue.Location = new System.Drawing.Point(138, 385);
            this.txtAsymmetricallyEncryptedValue.Multiline = true;
            this.txtAsymmetricallyEncryptedValue.Name = "txtAsymmetricallyEncryptedValue";
            this.txtAsymmetricallyEncryptedValue.ReadOnly = true;
            this.txtAsymmetricallyEncryptedValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAsymmetricallyEncryptedValue.Size = new System.Drawing.Size(850, 100);
            this.txtAsymmetricallyEncryptedValue.TabIndex = 72;
            // 
            // btnEncryptAsymmetrically
            // 
            this.btnEncryptAsymmetrically.Location = new System.Drawing.Point(138, 356);
            this.btnEncryptAsymmetrically.Name = "btnEncryptAsymmetrically";
            this.btnEncryptAsymmetrically.Size = new System.Drawing.Size(121, 23);
            this.btnEncryptAsymmetrically.TabIndex = 71;
            this.btnEncryptAsymmetrically.Text = "Encrypt";
            this.btnEncryptAsymmetrically.UseVisualStyleBackColor = true;
            this.btnEncryptAsymmetrically.Click += new System.EventHandler(this.btnEncryptAsymmetrically_Click);
            // 
            // lblAsymmetricallyEncryptedValue
            // 
            this.lblAsymmetricallyEncryptedValue.AutoSize = true;
            this.lblAsymmetricallyEncryptedValue.Location = new System.Drawing.Point(7, 390);
            this.lblAsymmetricallyEncryptedValue.Name = "lblAsymmetricallyEncryptedValue";
            this.lblAsymmetricallyEncryptedValue.Size = new System.Drawing.Size(84, 13);
            this.lblAsymmetricallyEncryptedValue.TabIndex = 70;
            this.lblAsymmetricallyEncryptedValue.Text = "Encrypted Data:";
            // 
            // txtAsymmetricTextToBeEncrypted
            // 
            this.txtAsymmetricTextToBeEncrypted.Location = new System.Drawing.Point(138, 330);
            this.txtAsymmetricTextToBeEncrypted.Name = "txtAsymmetricTextToBeEncrypted";
            this.txtAsymmetricTextToBeEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAsymmetricTextToBeEncrypted.Size = new System.Drawing.Size(837, 20);
            this.txtAsymmetricTextToBeEncrypted.TabIndex = 69;
            this.txtAsymmetricTextToBeEncrypted.Text = "Lorem ipsum dolor sit amet.";
            this.txtAsymmetricTextToBeEncrypted.TextChanged += new System.EventHandler(this.txtAsymmetricTextToBeEncrypted_TextChanged);
            // 
            // lblAsymmetricTextToBeEncrypted
            // 
            this.lblAsymmetricTextToBeEncrypted.AutoSize = true;
            this.lblAsymmetricTextToBeEncrypted.Location = new System.Drawing.Point(7, 333);
            this.lblAsymmetricTextToBeEncrypted.Name = "lblAsymmetricTextToBeEncrypted";
            this.lblAsymmetricTextToBeEncrypted.Size = new System.Drawing.Size(108, 13);
            this.lblAsymmetricTextToBeEncrypted.TabIndex = 68;
            this.lblAsymmetricTextToBeEncrypted.Text = "Text to be encrypted:";
            // 
            // btnCreateAsymmetricKey
            // 
            this.btnCreateAsymmetricKey.Location = new System.Drawing.Point(846, 125);
            this.btnCreateAsymmetricKey.Name = "btnCreateAsymmetricKey";
            this.btnCreateAsymmetricKey.Size = new System.Drawing.Size(129, 23);
            this.btnCreateAsymmetricKey.TabIndex = 67;
            this.btnCreateAsymmetricKey.Text = "Create Asymmetric Key";
            this.btnCreateAsymmetricKey.UseVisualStyleBackColor = true;
            this.btnCreateAsymmetricKey.Click += new System.EventHandler(this.btnCreateAsymmetricKey_Click);
            // 
            // txtPublicPrivateKey
            // 
            this.txtPublicPrivateKey.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtPublicPrivateKey.Location = new System.Drawing.Point(138, 127);
            this.txtPublicPrivateKey.Multiline = true;
            this.txtPublicPrivateKey.Name = "txtPublicPrivateKey";
            this.txtPublicPrivateKey.ReadOnly = true;
            this.txtPublicPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPublicPrivateKey.Size = new System.Drawing.Size(702, 170);
            this.txtPublicPrivateKey.TabIndex = 66;
            // 
            // lblPublicPrivateKey
            // 
            this.lblPublicPrivateKey.AutoSize = true;
            this.lblPublicPrivateKey.Location = new System.Drawing.Point(7, 130);
            this.lblPublicPrivateKey.Name = "lblPublicPrivateKey";
            this.lblPublicPrivateKey.Size = new System.Drawing.Size(49, 13);
            this.lblPublicPrivateKey.TabIndex = 65;
            this.lblPublicPrivateKey.Text = "Key Pair:";
            // 
            // txtAsymmetricKeyExchangeAlgorithm
            // 
            this.txtAsymmetricKeyExchangeAlgorithm.Location = new System.Drawing.Point(138, 99);
            this.txtAsymmetricKeyExchangeAlgorithm.Name = "txtAsymmetricKeyExchangeAlgorithm";
            this.txtAsymmetricKeyExchangeAlgorithm.ReadOnly = true;
            this.txtAsymmetricKeyExchangeAlgorithm.Size = new System.Drawing.Size(837, 20);
            this.txtAsymmetricKeyExchangeAlgorithm.TabIndex = 62;
            // 
            // lblAsymmetricKeyExchangeAlgorithm
            // 
            this.lblAsymmetricKeyExchangeAlgorithm.AutoSize = true;
            this.lblAsymmetricKeyExchangeAlgorithm.Location = new System.Drawing.Point(7, 102);
            this.lblAsymmetricKeyExchangeAlgorithm.Name = "lblAsymmetricKeyExchangeAlgorithm";
            this.lblAsymmetricKeyExchangeAlgorithm.Size = new System.Drawing.Size(125, 13);
            this.lblAsymmetricKeyExchangeAlgorithm.TabIndex = 61;
            this.lblAsymmetricKeyExchangeAlgorithm.Text = "Key Exchange Algorithm:";
            // 
            // txtAsymmetricKeySize
            // 
            this.txtAsymmetricKeySize.Location = new System.Drawing.Point(138, 43);
            this.txtAsymmetricKeySize.MaxLength = 5;
            this.txtAsymmetricKeySize.Name = "txtAsymmetricKeySize";
            this.txtAsymmetricKeySize.Size = new System.Drawing.Size(121, 20);
            this.txtAsymmetricKeySize.TabIndex = 60;
            this.txtAsymmetricKeySize.TextChanged += new System.EventHandler(this.txtAsymmetricKeySize_TextChanged);
            // 
            // lblAsymmetricKeySizeBits
            // 
            this.lblAsymmetricKeySizeBits.AutoSize = true;
            this.lblAsymmetricKeySizeBits.Location = new System.Drawing.Point(263, 46);
            this.lblAsymmetricKeySizeBits.Name = "lblAsymmetricKeySizeBits";
            this.lblAsymmetricKeySizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblAsymmetricKeySizeBits.TabIndex = 59;
            this.lblAsymmetricKeySizeBits.Text = "bits";
            // 
            // lblAsymmetricKeySize
            // 
            this.lblAsymmetricKeySize.AutoSize = true;
            this.lblAsymmetricKeySize.Location = new System.Drawing.Point(7, 46);
            this.lblAsymmetricKeySize.Name = "lblAsymmetricKeySize";
            this.lblAsymmetricKeySize.Size = new System.Drawing.Size(51, 13);
            this.lblAsymmetricKeySize.TabIndex = 58;
            this.lblAsymmetricKeySize.Text = "Key Size:";
            // 
            // cboAsymmetricAlgorithm
            // 
            this.cboAsymmetricAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsymmetricAlgorithm.FormattingEnabled = true;
            this.cboAsymmetricAlgorithm.Location = new System.Drawing.Point(138, 16);
            this.cboAsymmetricAlgorithm.Name = "cboAsymmetricAlgorithm";
            this.cboAsymmetricAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboAsymmetricAlgorithm.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Asymmetric Algorithm:";
            // 
            // tabHybridEncryption
            // 
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionSymmetricAlgorithmBlockSize);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithmBlockSize);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionDecryptedIV);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionDecryptedIV);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionEncryptedIV);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionEncryptedIV);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionDecryptedText);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionDecryptedText);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionDecryptedSessionKey);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionDecryptedSessionKey);
            this.tabHybridEncryption.Controls.Add(this.btnHybridEncryptionDecrypt);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionEncryptedSessionKey);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionEncryptedSessionKey);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionEncryptedText);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionEncryptedText);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionTextToBeEncrypted);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionTextToBeEncrypted);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionSymmetricAlgorithmKeySize);
            this.tabHybridEncryption.Controls.Add(this.cboHybridEncryptionSymmetricAlgorithmPaddingMode);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithmPaddingMode);
            this.tabHybridEncryption.Controls.Add(this.cboHybridEncryptionSymmetricAlgorithmCipherMode);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithmCipherMode);
            this.tabHybridEncryption.Controls.Add(this.btnHybridEncryptionCreateIv);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithmKeySize);
            this.tabHybridEncryption.Controls.Add(this.cboHybridEncryptionSymmetricAlgorithm);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricAlgorithm);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionIv);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionIv);
            this.tabHybridEncryption.Controls.Add(this.btnHybridEncryptionCreateSymmetricKey);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionSymmetricKey);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionSymmetricKey);
            this.tabHybridEncryption.Controls.Add(this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode);
            this.tabHybridEncryption.Controls.Add(this.cboHybridEncryptionEncoding);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionEncoding);
            this.tabHybridEncryption.Controls.Add(this.btnHybridEncryptionEncrypt);
            this.tabHybridEncryption.Controls.Add(this.btnHybridEncryptionCreateAsymmetricKey);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionAsymmetricAlgorithmKeyXml);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionAsymmetricAlgorithmKeyXml);
            this.tabHybridEncryption.Controls.Add(this.txtHybridEncryptionAsymmetricAlgorithmKeySize);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionAsymmetricAlgorithmKeySize);
            this.tabHybridEncryption.Controls.Add(this.cboHybridEncryptionAsymmetricAlgorithm);
            this.tabHybridEncryption.Controls.Add(this.lblHybridEncryptionAsymmetricAlgorithm);
            this.tabHybridEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabHybridEncryption.Name = "tabHybridEncryption";
            this.tabHybridEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabHybridEncryption.Size = new System.Drawing.Size(981, 950);
            this.tabHybridEncryption.TabIndex = 4;
            this.tabHybridEncryption.Text = "Hybrid Encryption";
            this.tabHybridEncryption.UseVisualStyleBackColor = true;
            // 
            // txtHybridEncryptionSymmetricAlgorithmBlockSize
            // 
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize.Location = new System.Drawing.Point(137, 325);
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize.MaxLength = 4;
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize.Name = "txtHybridEncryptionSymmetricAlgorithmBlockSize";
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize.Size = new System.Drawing.Size(119, 20);
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize.TabIndex = 138;
            this.txtHybridEncryptionSymmetricAlgorithmBlockSize.TextChanged += new System.EventHandler(this.txtHybridEncryptionSymmetricAlgorithmBlockSize_TextChanged);
            // 
            // lblHybridEncryptionSymmetricAlgorithmBlockSizeBits
            // 
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.Location = new System.Drawing.Point(262, 328);
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.Name = "lblHybridEncryptionSymmetricAlgorithmBlockSizeBits";
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.TabIndex = 137;
            this.lblHybridEncryptionSymmetricAlgorithmBlockSizeBits.Text = "bits";
            // 
            // lblHybridEncryptionSymmetricAlgorithmBlockSize
            // 
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize.Location = new System.Drawing.Point(7, 328);
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize.Name = "lblHybridEncryptionSymmetricAlgorithmBlockSize";
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize.Size = new System.Drawing.Size(60, 13);
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize.TabIndex = 136;
            this.lblHybridEncryptionSymmetricAlgorithmBlockSize.Text = "Block Size:";
            // 
            // txtHybridEncryptionDecryptedIV
            // 
            this.txtHybridEncryptionDecryptedIV.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionDecryptedIV.Location = new System.Drawing.Point(139, 818);
            this.txtHybridEncryptionDecryptedIV.Name = "txtHybridEncryptionDecryptedIV";
            this.txtHybridEncryptionDecryptedIV.ReadOnly = true;
            this.txtHybridEncryptionDecryptedIV.Size = new System.Drawing.Size(835, 20);
            this.txtHybridEncryptionDecryptedIV.TabIndex = 135;
            // 
            // lblHybridEncryptionDecryptedIV
            // 
            this.lblHybridEncryptionDecryptedIV.AutoSize = true;
            this.lblHybridEncryptionDecryptedIV.Location = new System.Drawing.Point(9, 821);
            this.lblHybridEncryptionDecryptedIV.Name = "lblHybridEncryptionDecryptedIV";
            this.lblHybridEncryptionDecryptedIV.Size = new System.Drawing.Size(72, 13);
            this.lblHybridEncryptionDecryptedIV.TabIndex = 134;
            this.lblHybridEncryptionDecryptedIV.Text = "Decrypted IV:";
            // 
            // txtHybridEncryptionEncryptedIV
            // 
            this.txtHybridEncryptionEncryptedIV.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionEncryptedIV.Location = new System.Drawing.Point(139, 638);
            this.txtHybridEncryptionEncryptedIV.Name = "txtHybridEncryptionEncryptedIV";
            this.txtHybridEncryptionEncryptedIV.ReadOnly = true;
            this.txtHybridEncryptionEncryptedIV.Size = new System.Drawing.Size(835, 20);
            this.txtHybridEncryptionEncryptedIV.TabIndex = 133;
            // 
            // lblHybridEncryptionEncryptedIV
            // 
            this.lblHybridEncryptionEncryptedIV.AutoSize = true;
            this.lblHybridEncryptionEncryptedIV.Location = new System.Drawing.Point(8, 641);
            this.lblHybridEncryptionEncryptedIV.Name = "lblHybridEncryptionEncryptedIV";
            this.lblHybridEncryptionEncryptedIV.Size = new System.Drawing.Size(71, 13);
            this.lblHybridEncryptionEncryptedIV.TabIndex = 132;
            this.lblHybridEncryptionEncryptedIV.Text = "Encrypted IV:";
            // 
            // txtHybridEncryptionDecryptedText
            // 
            this.txtHybridEncryptionDecryptedText.Location = new System.Drawing.Point(137, 844);
            this.txtHybridEncryptionDecryptedText.Multiline = true;
            this.txtHybridEncryptionDecryptedText.Name = "txtHybridEncryptionDecryptedText";
            this.txtHybridEncryptionDecryptedText.ReadOnly = true;
            this.txtHybridEncryptionDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHybridEncryptionDecryptedText.Size = new System.Drawing.Size(836, 93);
            this.txtHybridEncryptionDecryptedText.TabIndex = 131;
            // 
            // lblHybridEncryptionDecryptedText
            // 
            this.lblHybridEncryptionDecryptedText.AutoSize = true;
            this.lblHybridEncryptionDecryptedText.Location = new System.Drawing.Point(9, 847);
            this.lblHybridEncryptionDecryptedText.Name = "lblHybridEncryptionDecryptedText";
            this.lblHybridEncryptionDecryptedText.Size = new System.Drawing.Size(85, 13);
            this.lblHybridEncryptionDecryptedText.TabIndex = 130;
            this.lblHybridEncryptionDecryptedText.Text = "Decrypted Data:";
            // 
            // txtHybridEncryptionDecryptedSessionKey
            // 
            this.txtHybridEncryptionDecryptedSessionKey.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionDecryptedSessionKey.Location = new System.Drawing.Point(138, 792);
            this.txtHybridEncryptionDecryptedSessionKey.Name = "txtHybridEncryptionDecryptedSessionKey";
            this.txtHybridEncryptionDecryptedSessionKey.ReadOnly = true;
            this.txtHybridEncryptionDecryptedSessionKey.Size = new System.Drawing.Size(835, 20);
            this.txtHybridEncryptionDecryptedSessionKey.TabIndex = 129;
            // 
            // lblHybridEncryptionDecryptedSessionKey
            // 
            this.lblHybridEncryptionDecryptedSessionKey.AutoSize = true;
            this.lblHybridEncryptionDecryptedSessionKey.Location = new System.Drawing.Point(8, 795);
            this.lblHybridEncryptionDecryptedSessionKey.Name = "lblHybridEncryptionDecryptedSessionKey";
            this.lblHybridEncryptionDecryptedSessionKey.Size = new System.Drawing.Size(120, 13);
            this.lblHybridEncryptionDecryptedSessionKey.TabIndex = 128;
            this.lblHybridEncryptionDecryptedSessionKey.Text = "Decrypted Session Key:";
            // 
            // btnHybridEncryptionDecrypt
            // 
            this.btnHybridEncryptionDecrypt.Location = new System.Drawing.Point(139, 763);
            this.btnHybridEncryptionDecrypt.Name = "btnHybridEncryptionDecrypt";
            this.btnHybridEncryptionDecrypt.Size = new System.Drawing.Size(121, 23);
            this.btnHybridEncryptionDecrypt.TabIndex = 127;
            this.btnHybridEncryptionDecrypt.Text = "Decrypt";
            this.btnHybridEncryptionDecrypt.UseVisualStyleBackColor = true;
            this.btnHybridEncryptionDecrypt.Click += new System.EventHandler(this.btnHybridEncryptionDecrypt_Click);
            // 
            // txtHybridEncryptionEncryptedSessionKey
            // 
            this.txtHybridEncryptionEncryptedSessionKey.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionEncryptedSessionKey.Location = new System.Drawing.Point(138, 612);
            this.txtHybridEncryptionEncryptedSessionKey.Name = "txtHybridEncryptionEncryptedSessionKey";
            this.txtHybridEncryptionEncryptedSessionKey.ReadOnly = true;
            this.txtHybridEncryptionEncryptedSessionKey.Size = new System.Drawing.Size(835, 20);
            this.txtHybridEncryptionEncryptedSessionKey.TabIndex = 126;
            // 
            // lblHybridEncryptionEncryptedSessionKey
            // 
            this.lblHybridEncryptionEncryptedSessionKey.AutoSize = true;
            this.lblHybridEncryptionEncryptedSessionKey.Location = new System.Drawing.Point(8, 615);
            this.lblHybridEncryptionEncryptedSessionKey.Name = "lblHybridEncryptionEncryptedSessionKey";
            this.lblHybridEncryptionEncryptedSessionKey.Size = new System.Drawing.Size(119, 13);
            this.lblHybridEncryptionEncryptedSessionKey.TabIndex = 125;
            this.lblHybridEncryptionEncryptedSessionKey.Text = "Encrypted Session Key:";
            // 
            // txtHybridEncryptionEncryptedText
            // 
            this.txtHybridEncryptionEncryptedText.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionEncryptedText.Location = new System.Drawing.Point(138, 664);
            this.txtHybridEncryptionEncryptedText.Multiline = true;
            this.txtHybridEncryptionEncryptedText.Name = "txtHybridEncryptionEncryptedText";
            this.txtHybridEncryptionEncryptedText.ReadOnly = true;
            this.txtHybridEncryptionEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHybridEncryptionEncryptedText.Size = new System.Drawing.Size(836, 93);
            this.txtHybridEncryptionEncryptedText.TabIndex = 124;
            // 
            // lblHybridEncryptionEncryptedText
            // 
            this.lblHybridEncryptionEncryptedText.AutoSize = true;
            this.lblHybridEncryptionEncryptedText.Location = new System.Drawing.Point(8, 667);
            this.lblHybridEncryptionEncryptedText.Name = "lblHybridEncryptionEncryptedText";
            this.lblHybridEncryptionEncryptedText.Size = new System.Drawing.Size(84, 13);
            this.lblHybridEncryptionEncryptedText.TabIndex = 123;
            this.lblHybridEncryptionEncryptedText.Text = "Encrypted Data:";
            // 
            // txtHybridEncryptionTextToBeEncrypted
            // 
            this.txtHybridEncryptionTextToBeEncrypted.Location = new System.Drawing.Point(138, 484);
            this.txtHybridEncryptionTextToBeEncrypted.Multiline = true;
            this.txtHybridEncryptionTextToBeEncrypted.Name = "txtHybridEncryptionTextToBeEncrypted";
            this.txtHybridEncryptionTextToBeEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHybridEncryptionTextToBeEncrypted.Size = new System.Drawing.Size(836, 93);
            this.txtHybridEncryptionTextToBeEncrypted.TabIndex = 122;
            this.txtHybridEncryptionTextToBeEncrypted.Text = resources.GetString("txtHybridEncryptionTextToBeEncrypted.Text");
            this.txtHybridEncryptionTextToBeEncrypted.TextChanged += new System.EventHandler(this.txtHybridEncryptionTextToBeEncrypted_TextChanged);
            // 
            // lblHybridEncryptionTextToBeEncrypted
            // 
            this.lblHybridEncryptionTextToBeEncrypted.AutoSize = true;
            this.lblHybridEncryptionTextToBeEncrypted.Location = new System.Drawing.Point(6, 487);
            this.lblHybridEncryptionTextToBeEncrypted.Name = "lblHybridEncryptionTextToBeEncrypted";
            this.lblHybridEncryptionTextToBeEncrypted.Size = new System.Drawing.Size(108, 13);
            this.lblHybridEncryptionTextToBeEncrypted.TabIndex = 121;
            this.lblHybridEncryptionTextToBeEncrypted.Text = "Text to be encrypted:";
            // 
            // txtHybridEncryptionSymmetricAlgorithmKeySize
            // 
            this.txtHybridEncryptionSymmetricAlgorithmKeySize.Location = new System.Drawing.Point(137, 299);
            this.txtHybridEncryptionSymmetricAlgorithmKeySize.MaxLength = 4;
            this.txtHybridEncryptionSymmetricAlgorithmKeySize.Name = "txtHybridEncryptionSymmetricAlgorithmKeySize";
            this.txtHybridEncryptionSymmetricAlgorithmKeySize.Size = new System.Drawing.Size(119, 20);
            this.txtHybridEncryptionSymmetricAlgorithmKeySize.TabIndex = 116;
            this.txtHybridEncryptionSymmetricAlgorithmKeySize.TextChanged += new System.EventHandler(this.txtHybridEncryptionSymmetricAlgorithmKeySize_TextChanged);
            // 
            // cboHybridEncryptionSymmetricAlgorithmPaddingMode
            // 
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.FormattingEnabled = true;
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.Location = new System.Drawing.Point(138, 378);
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.Name = "cboHybridEncryptionSymmetricAlgorithmPaddingMode";
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.Size = new System.Drawing.Size(119, 21);
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.TabIndex = 115;
            this.cboHybridEncryptionSymmetricAlgorithmPaddingMode.SelectedIndexChanged += new System.EventHandler(this.cboHybridEncryptionSymmetricAlgorithmPaddingMode_SelectedIndexChanged);
            // 
            // lblHybridEncryptionSymmetricAlgorithmPaddingMode
            // 
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode.Location = new System.Drawing.Point(8, 381);
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode.Name = "lblHybridEncryptionSymmetricAlgorithmPaddingMode";
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode.Size = new System.Drawing.Size(79, 13);
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode.TabIndex = 114;
            this.lblHybridEncryptionSymmetricAlgorithmPaddingMode.Text = "Padding Mode:";
            // 
            // cboHybridEncryptionSymmetricAlgorithmCipherMode
            // 
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.FormattingEnabled = true;
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.Location = new System.Drawing.Point(138, 351);
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.Name = "cboHybridEncryptionSymmetricAlgorithmCipherMode";
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.Size = new System.Drawing.Size(119, 21);
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.TabIndex = 113;
            this.cboHybridEncryptionSymmetricAlgorithmCipherMode.SelectedIndexChanged += new System.EventHandler(this.cboHybridEncryptionSymmetricAlgorithmCipherMode_SelectedIndexChanged);
            // 
            // lblHybridEncryptionSymmetricAlgorithmCipherMode
            // 
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode.Location = new System.Drawing.Point(8, 354);
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode.Name = "lblHybridEncryptionSymmetricAlgorithmCipherMode";
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode.Size = new System.Drawing.Size(70, 13);
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode.TabIndex = 112;
            this.lblHybridEncryptionSymmetricAlgorithmCipherMode.Text = "Cipher Mode:";
            // 
            // btnHybridEncryptionCreateIv
            // 
            this.btnHybridEncryptionCreateIv.Location = new System.Drawing.Point(821, 429);
            this.btnHybridEncryptionCreateIv.Name = "btnHybridEncryptionCreateIv";
            this.btnHybridEncryptionCreateIv.Size = new System.Drawing.Size(154, 23);
            this.btnHybridEncryptionCreateIv.TabIndex = 111;
            this.btnHybridEncryptionCreateIv.Text = "Create Initialization Vector";
            this.btnHybridEncryptionCreateIv.UseVisualStyleBackColor = true;
            this.btnHybridEncryptionCreateIv.Click += new System.EventHandler(this.btnHybridEncryptionCreateIv_Click);
            // 
            // lblHybridEncryptionSymmetricAlgorithmKeySizeBits
            // 
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits.Location = new System.Drawing.Point(262, 302);
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits.Name = "lblHybridEncryptionSymmetricAlgorithmKeySizeBits";
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits.TabIndex = 109;
            this.lblHybridEncryptionSymmetricAlgorithmKeySizeBits.Text = "bits";
            // 
            // lblHybridEncryptionSymmetricAlgorithmKeySize
            // 
            this.lblHybridEncryptionSymmetricAlgorithmKeySize.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithmKeySize.Location = new System.Drawing.Point(7, 302);
            this.lblHybridEncryptionSymmetricAlgorithmKeySize.Name = "lblHybridEncryptionSymmetricAlgorithmKeySize";
            this.lblHybridEncryptionSymmetricAlgorithmKeySize.Size = new System.Drawing.Size(51, 13);
            this.lblHybridEncryptionSymmetricAlgorithmKeySize.TabIndex = 107;
            this.lblHybridEncryptionSymmetricAlgorithmKeySize.Text = "Key Size:";
            // 
            // cboHybridEncryptionSymmetricAlgorithm
            // 
            this.cboHybridEncryptionSymmetricAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHybridEncryptionSymmetricAlgorithm.FormattingEnabled = true;
            this.cboHybridEncryptionSymmetricAlgorithm.Location = new System.Drawing.Point(138, 272);
            this.cboHybridEncryptionSymmetricAlgorithm.Name = "cboHybridEncryptionSymmetricAlgorithm";
            this.cboHybridEncryptionSymmetricAlgorithm.Size = new System.Drawing.Size(119, 21);
            this.cboHybridEncryptionSymmetricAlgorithm.TabIndex = 106;
            this.cboHybridEncryptionSymmetricAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboHybridEncryptionSymmetricAlgorithm_SelectedIndexChanged);
            // 
            // lblHybridEncryptionSymmetricAlgorithm
            // 
            this.lblHybridEncryptionSymmetricAlgorithm.AutoSize = true;
            this.lblHybridEncryptionSymmetricAlgorithm.Location = new System.Drawing.Point(7, 275);
            this.lblHybridEncryptionSymmetricAlgorithm.Name = "lblHybridEncryptionSymmetricAlgorithm";
            this.lblHybridEncryptionSymmetricAlgorithm.Size = new System.Drawing.Size(104, 13);
            this.lblHybridEncryptionSymmetricAlgorithm.TabIndex = 105;
            this.lblHybridEncryptionSymmetricAlgorithm.Text = "Symmetric Algorithm:";
            // 
            // txtHybridEncryptionIv
            // 
            this.txtHybridEncryptionIv.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionIv.Location = new System.Drawing.Point(139, 431);
            this.txtHybridEncryptionIv.Name = "txtHybridEncryptionIv";
            this.txtHybridEncryptionIv.ReadOnly = true;
            this.txtHybridEncryptionIv.Size = new System.Drawing.Size(677, 20);
            this.txtHybridEncryptionIv.TabIndex = 104;
            // 
            // lblHybridEncryptionIv
            // 
            this.lblHybridEncryptionIv.AutoSize = true;
            this.lblHybridEncryptionIv.Location = new System.Drawing.Point(8, 434);
            this.lblHybridEncryptionIv.Name = "lblHybridEncryptionIv";
            this.lblHybridEncryptionIv.Size = new System.Drawing.Size(98, 13);
            this.lblHybridEncryptionIv.TabIndex = 103;
            this.lblHybridEncryptionIv.Text = "Initialization Vector:";
            // 
            // btnHybridEncryptionCreateSymmetricKey
            // 
            this.btnHybridEncryptionCreateSymmetricKey.Location = new System.Drawing.Point(822, 403);
            this.btnHybridEncryptionCreateSymmetricKey.Name = "btnHybridEncryptionCreateSymmetricKey";
            this.btnHybridEncryptionCreateSymmetricKey.Size = new System.Drawing.Size(154, 23);
            this.btnHybridEncryptionCreateSymmetricKey.TabIndex = 102;
            this.btnHybridEncryptionCreateSymmetricKey.Text = "Create Session Key";
            this.btnHybridEncryptionCreateSymmetricKey.UseVisualStyleBackColor = true;
            this.btnHybridEncryptionCreateSymmetricKey.Click += new System.EventHandler(this.btnHybridEncryptionCreateSymmetricKey_Click);
            // 
            // txtHybridEncryptionSymmetricKey
            // 
            this.txtHybridEncryptionSymmetricKey.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionSymmetricKey.Location = new System.Drawing.Point(138, 405);
            this.txtHybridEncryptionSymmetricKey.Name = "txtHybridEncryptionSymmetricKey";
            this.txtHybridEncryptionSymmetricKey.ReadOnly = true;
            this.txtHybridEncryptionSymmetricKey.Size = new System.Drawing.Size(677, 20);
            this.txtHybridEncryptionSymmetricKey.TabIndex = 101;
            // 
            // lblHybridEncryptionSymmetricKey
            // 
            this.lblHybridEncryptionSymmetricKey.AutoSize = true;
            this.lblHybridEncryptionSymmetricKey.Location = new System.Drawing.Point(8, 408);
            this.lblHybridEncryptionSymmetricKey.Name = "lblHybridEncryptionSymmetricKey";
            this.lblHybridEncryptionSymmetricKey.Size = new System.Drawing.Size(68, 13);
            this.lblHybridEncryptionSymmetricKey.TabIndex = 100;
            this.lblHybridEncryptionSymmetricKey.Text = "Session Key:";
            // 
            // cboHybridEncryptionAsymmetricAlgorithmPaddingMode
            // 
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.FormattingEnabled = true;
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Location = new System.Drawing.Point(138, 69);
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Name = "cboHybridEncryptionAsymmetricAlgorithmPaddingMode";
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.Size = new System.Drawing.Size(837, 21);
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.TabIndex = 99;
            this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode.SelectedIndexChanged += new System.EventHandler(this.cboHybridEncryptionAsymmetricAlgorithmPaddingMode_SelectedIndexChanged);
            // 
            // lblHybridEncryptionAsymmetricAlgorithmPaddingMode
            // 
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode.AutoSize = true;
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode.Location = new System.Drawing.Point(7, 74);
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode.Name = "lblHybridEncryptionAsymmetricAlgorithmPaddingMode";
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode.Size = new System.Drawing.Size(79, 13);
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode.TabIndex = 98;
            this.lblHybridEncryptionAsymmetricAlgorithmPaddingMode.Text = "Padding Mode:";
            // 
            // cboHybridEncryptionEncoding
            // 
            this.cboHybridEncryptionEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHybridEncryptionEncoding.FormattingEnabled = true;
            this.cboHybridEncryptionEncoding.Location = new System.Drawing.Point(138, 457);
            this.cboHybridEncryptionEncoding.Name = "cboHybridEncryptionEncoding";
            this.cboHybridEncryptionEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboHybridEncryptionEncoding.Sorted = true;
            this.cboHybridEncryptionEncoding.TabIndex = 97;
            this.cboHybridEncryptionEncoding.SelectedIndexChanged += new System.EventHandler(this.cboHybridEncryptionEncoding_SelectedIndexChanged);
            // 
            // lblHybridEncryptionEncoding
            // 
            this.lblHybridEncryptionEncoding.AutoSize = true;
            this.lblHybridEncryptionEncoding.Location = new System.Drawing.Point(7, 465);
            this.lblHybridEncryptionEncoding.Name = "lblHybridEncryptionEncoding";
            this.lblHybridEncryptionEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblHybridEncryptionEncoding.TabIndex = 96;
            this.lblHybridEncryptionEncoding.Text = "Encoding:";
            // 
            // btnHybridEncryptionEncrypt
            // 
            this.btnHybridEncryptionEncrypt.Location = new System.Drawing.Point(138, 583);
            this.btnHybridEncryptionEncrypt.Name = "btnHybridEncryptionEncrypt";
            this.btnHybridEncryptionEncrypt.Size = new System.Drawing.Size(121, 23);
            this.btnHybridEncryptionEncrypt.TabIndex = 95;
            this.btnHybridEncryptionEncrypt.Text = "Encrypt";
            this.btnHybridEncryptionEncrypt.UseVisualStyleBackColor = true;
            this.btnHybridEncryptionEncrypt.Click += new System.EventHandler(this.btnHybridEncryptionEncrypt_Click);
            // 
            // btnHybridEncryptionCreateAsymmetricKey
            // 
            this.btnHybridEncryptionCreateAsymmetricKey.Location = new System.Drawing.Point(821, 94);
            this.btnHybridEncryptionCreateAsymmetricKey.Name = "btnHybridEncryptionCreateAsymmetricKey";
            this.btnHybridEncryptionCreateAsymmetricKey.Size = new System.Drawing.Size(153, 23);
            this.btnHybridEncryptionCreateAsymmetricKey.TabIndex = 92;
            this.btnHybridEncryptionCreateAsymmetricKey.Text = "Create Asymmetric Key";
            this.btnHybridEncryptionCreateAsymmetricKey.UseVisualStyleBackColor = true;
            this.btnHybridEncryptionCreateAsymmetricKey.Click += new System.EventHandler(this.btnHybridEncryptionCreateAsymmetricKey_Click);
            // 
            // txtHybridEncryptionAsymmetricAlgorithmKeyXml
            // 
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.Location = new System.Drawing.Point(137, 96);
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.Multiline = true;
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.Name = "txtHybridEncryptionAsymmetricAlgorithmKeyXml";
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.ReadOnly = true;
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.Size = new System.Drawing.Size(677, 170);
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.TabIndex = 91;
            this.txtHybridEncryptionAsymmetricAlgorithmKeyXml.TextChanged += new System.EventHandler(this.txtHybridEncryptionAsymmetricAlgorithmKeyXml_TextChanged);
            // 
            // lblHybridEncryptionAsymmetricAlgorithmKeyXml
            // 
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml.AutoSize = true;
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml.Location = new System.Drawing.Point(7, 99);
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml.Name = "lblHybridEncryptionAsymmetricAlgorithmKeyXml";
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml.Size = new System.Drawing.Size(49, 13);
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml.TabIndex = 90;
            this.lblHybridEncryptionAsymmetricAlgorithmKeyXml.Text = "Key Pair:";
            // 
            // txtHybridEncryptionAsymmetricAlgorithmKeySize
            // 
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize.Location = new System.Drawing.Point(138, 43);
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize.MaxLength = 5;
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize.Name = "txtHybridEncryptionAsymmetricAlgorithmKeySize";
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize.Size = new System.Drawing.Size(121, 20);
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize.TabIndex = 87;
            this.txtHybridEncryptionAsymmetricAlgorithmKeySize.TextChanged += new System.EventHandler(this.txtHybridEncryptionAsymmetricAlgorithmKeySize_TextChanged);
            // 
            // lblHybridEncryptionAsymmetricAlgorithmKeySizeBits
            // 
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.AutoSize = true;
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.Location = new System.Drawing.Point(265, 46);
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.Name = "lblHybridEncryptionAsymmetricAlgorithmKeySizeBits";
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.TabIndex = 86;
            this.lblHybridEncryptionAsymmetricAlgorithmKeySizeBits.Text = "bits";
            // 
            // lblHybridEncryptionAsymmetricAlgorithmKeySize
            // 
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize.AutoSize = true;
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize.Location = new System.Drawing.Point(7, 46);
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize.Name = "lblHybridEncryptionAsymmetricAlgorithmKeySize";
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize.Size = new System.Drawing.Size(51, 13);
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize.TabIndex = 85;
            this.lblHybridEncryptionAsymmetricAlgorithmKeySize.Text = "Key Size:";
            // 
            // cboHybridEncryptionAsymmetricAlgorithm
            // 
            this.cboHybridEncryptionAsymmetricAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHybridEncryptionAsymmetricAlgorithm.FormattingEnabled = true;
            this.cboHybridEncryptionAsymmetricAlgorithm.Location = new System.Drawing.Point(138, 16);
            this.cboHybridEncryptionAsymmetricAlgorithm.Name = "cboHybridEncryptionAsymmetricAlgorithm";
            this.cboHybridEncryptionAsymmetricAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboHybridEncryptionAsymmetricAlgorithm.TabIndex = 84;
            this.cboHybridEncryptionAsymmetricAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboHybridEncryptionAsymmetricAlgorithm_SelectedIndexChanged);
            // 
            // lblHybridEncryptionAsymmetricAlgorithm
            // 
            this.lblHybridEncryptionAsymmetricAlgorithm.AutoSize = true;
            this.lblHybridEncryptionAsymmetricAlgorithm.Location = new System.Drawing.Point(7, 19);
            this.lblHybridEncryptionAsymmetricAlgorithm.Name = "lblHybridEncryptionAsymmetricAlgorithm";
            this.lblHybridEncryptionAsymmetricAlgorithm.Size = new System.Drawing.Size(109, 13);
            this.lblHybridEncryptionAsymmetricAlgorithm.TabIndex = 83;
            this.lblHybridEncryptionAsymmetricAlgorithm.Text = "Asymmetric Algorithm:";
            // 
            // tabDigitalSignature
            // 
            this.tabDigitalSignature.Controls.Add(this.rdoDigitalSignatureFileToBeSigned);
            this.tabDigitalSignature.Controls.Add(this.rdoDigitalSignatureTextToBeSigned);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureVerification);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureVerification);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureSizeBits);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureSize);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureSize);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureResult);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureResult);
            this.tabDigitalSignature.Controls.Add(this.btnDigitalSignatureChooseFile);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureFileToBeSigned);
            this.tabDigitalSignature.Controls.Add(this.cboDigitalSignatureHashAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureHashAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureSignatureAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureSignatureAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.cboDigitalSignatureEncoding);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureEncoding);
            this.tabDigitalSignature.Controls.Add(this.btnDigitalSignatureVerifyText);
            this.tabDigitalSignature.Controls.Add(this.btnDigitalSignatureSignText);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureTextToBeSigned);
            this.tabDigitalSignature.Controls.Add(this.btnDigitalSignatureCreateKey);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureKeyXml);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureKeyXml);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureKeyExchangeAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureKeyExchangeAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.txtDigitalSignatureKeySize);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureKeySizeBits);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureKeySize);
            this.tabDigitalSignature.Controls.Add(this.cboDigitalSignatureAlgorithm);
            this.tabDigitalSignature.Controls.Add(this.lblDigitalSignatureAlgorithm);
            this.tabDigitalSignature.Location = new System.Drawing.Point(4, 22);
            this.tabDigitalSignature.Name = "tabDigitalSignature";
            this.tabDigitalSignature.Padding = new System.Windows.Forms.Padding(3);
            this.tabDigitalSignature.Size = new System.Drawing.Size(981, 950);
            this.tabDigitalSignature.TabIndex = 3;
            this.tabDigitalSignature.Text = "Digital Signature";
            this.tabDigitalSignature.UseVisualStyleBackColor = true;
            // 
            // rdoDigitalSignatureFileToBeSigned
            // 
            this.rdoDigitalSignatureFileToBeSigned.AutoSize = true;
            this.rdoDigitalSignatureFileToBeSigned.Location = new System.Drawing.Point(10, 386);
            this.rdoDigitalSignatureFileToBeSigned.Name = "rdoDigitalSignatureFileToBeSigned";
            this.rdoDigitalSignatureFileToBeSigned.Size = new System.Drawing.Size(105, 17);
            this.rdoDigitalSignatureFileToBeSigned.TabIndex = 123;
            this.rdoDigitalSignatureFileToBeSigned.Text = "File to be signed:";
            this.rdoDigitalSignatureFileToBeSigned.UseVisualStyleBackColor = true;
            // 
            // rdoDigitalSignatureTextToBeSigned
            // 
            this.rdoDigitalSignatureTextToBeSigned.AutoSize = true;
            this.rdoDigitalSignatureTextToBeSigned.Checked = true;
            this.rdoDigitalSignatureTextToBeSigned.Location = new System.Drawing.Point(10, 358);
            this.rdoDigitalSignatureTextToBeSigned.Name = "rdoDigitalSignatureTextToBeSigned";
            this.rdoDigitalSignatureTextToBeSigned.Size = new System.Drawing.Size(110, 17);
            this.rdoDigitalSignatureTextToBeSigned.TabIndex = 122;
            this.rdoDigitalSignatureTextToBeSigned.TabStop = true;
            this.rdoDigitalSignatureTextToBeSigned.Text = "Text to be signed:";
            this.rdoDigitalSignatureTextToBeSigned.UseVisualStyleBackColor = true;
            // 
            // txtDigitalSignatureVerification
            // 
            this.txtDigitalSignatureVerification.Location = new System.Drawing.Point(138, 493);
            this.txtDigitalSignatureVerification.Name = "txtDigitalSignatureVerification";
            this.txtDigitalSignatureVerification.ReadOnly = true;
            this.txtDigitalSignatureVerification.Size = new System.Drawing.Size(837, 20);
            this.txtDigitalSignatureVerification.TabIndex = 120;
            // 
            // lblDigitalSignatureVerification
            // 
            this.lblDigitalSignatureVerification.AutoSize = true;
            this.lblDigitalSignatureVerification.Location = new System.Drawing.Point(7, 496);
            this.lblDigitalSignatureVerification.Name = "lblDigitalSignatureVerification";
            this.lblDigitalSignatureVerification.Size = new System.Drawing.Size(62, 13);
            this.lblDigitalSignatureVerification.TabIndex = 119;
            this.lblDigitalSignatureVerification.Text = "Verification:";
            // 
            // lblDigitalSignatureSizeBits
            // 
            this.lblDigitalSignatureSizeBits.AutoSize = true;
            this.lblDigitalSignatureSizeBits.Location = new System.Drawing.Point(265, 470);
            this.lblDigitalSignatureSizeBits.Name = "lblDigitalSignatureSizeBits";
            this.lblDigitalSignatureSizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblDigitalSignatureSizeBits.TabIndex = 118;
            this.lblDigitalSignatureSizeBits.Text = "bits";
            // 
            // txtDigitalSignatureSize
            // 
            this.txtDigitalSignatureSize.Location = new System.Drawing.Point(138, 467);
            this.txtDigitalSignatureSize.Name = "txtDigitalSignatureSize";
            this.txtDigitalSignatureSize.ReadOnly = true;
            this.txtDigitalSignatureSize.Size = new System.Drawing.Size(121, 20);
            this.txtDigitalSignatureSize.TabIndex = 117;
            // 
            // lblDigitalSignatureSize
            // 
            this.lblDigitalSignatureSize.AutoSize = true;
            this.lblDigitalSignatureSize.Location = new System.Drawing.Point(7, 470);
            this.lblDigitalSignatureSize.Name = "lblDigitalSignatureSize";
            this.lblDigitalSignatureSize.Size = new System.Drawing.Size(78, 13);
            this.lblDigitalSignatureSize.TabIndex = 116;
            this.lblDigitalSignatureSize.Text = "Signature Size:";
            // 
            // txtDigitalSignatureResult
            // 
            this.txtDigitalSignatureResult.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtDigitalSignatureResult.Location = new System.Drawing.Point(138, 441);
            this.txtDigitalSignatureResult.Name = "txtDigitalSignatureResult";
            this.txtDigitalSignatureResult.ReadOnly = true;
            this.txtDigitalSignatureResult.Size = new System.Drawing.Size(837, 20);
            this.txtDigitalSignatureResult.TabIndex = 115;
            // 
            // lblDigitalSignatureResult
            // 
            this.lblDigitalSignatureResult.AutoSize = true;
            this.lblDigitalSignatureResult.Location = new System.Drawing.Point(7, 444);
            this.lblDigitalSignatureResult.Name = "lblDigitalSignatureResult";
            this.lblDigitalSignatureResult.Size = new System.Drawing.Size(55, 13);
            this.lblDigitalSignatureResult.TabIndex = 114;
            this.lblDigitalSignatureResult.Text = "Signature:";
            // 
            // btnDigitalSignatureChooseFile
            // 
            this.btnDigitalSignatureChooseFile.Location = new System.Drawing.Point(938, 383);
            this.btnDigitalSignatureChooseFile.Name = "btnDigitalSignatureChooseFile";
            this.btnDigitalSignatureChooseFile.Size = new System.Drawing.Size(37, 23);
            this.btnDigitalSignatureChooseFile.TabIndex = 112;
            this.btnDigitalSignatureChooseFile.Text = "...";
            this.btnDigitalSignatureChooseFile.UseVisualStyleBackColor = true;
            this.btnDigitalSignatureChooseFile.Click += new System.EventHandler(this.btnDigitalSignatureChooseFile_Click);
            // 
            // txtDigitalSignatureFileToBeSigned
            // 
            this.txtDigitalSignatureFileToBeSigned.Location = new System.Drawing.Point(138, 385);
            this.txtDigitalSignatureFileToBeSigned.MaxLength = 255;
            this.txtDigitalSignatureFileToBeSigned.Name = "txtDigitalSignatureFileToBeSigned";
            this.txtDigitalSignatureFileToBeSigned.Size = new System.Drawing.Size(794, 20);
            this.txtDigitalSignatureFileToBeSigned.TabIndex = 111;
            // 
            // cboDigitalSignatureHashAlgorithm
            // 
            this.cboDigitalSignatureHashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDigitalSignatureHashAlgorithm.FormattingEnabled = true;
            this.cboDigitalSignatureHashAlgorithm.Location = new System.Drawing.Point(138, 43);
            this.cboDigitalSignatureHashAlgorithm.Name = "cboDigitalSignatureHashAlgorithm";
            this.cboDigitalSignatureHashAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboDigitalSignatureHashAlgorithm.TabIndex = 109;
            this.cboDigitalSignatureHashAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboDigitalSignatureHashAlgorithm_SelectedIndexChanged);
            // 
            // lblDigitalSignatureHashAlgorithm
            // 
            this.lblDigitalSignatureHashAlgorithm.AutoSize = true;
            this.lblDigitalSignatureHashAlgorithm.Location = new System.Drawing.Point(7, 46);
            this.lblDigitalSignatureHashAlgorithm.Name = "lblDigitalSignatureHashAlgorithm";
            this.lblDigitalSignatureHashAlgorithm.Size = new System.Drawing.Size(81, 13);
            this.lblDigitalSignatureHashAlgorithm.TabIndex = 108;
            this.lblDigitalSignatureHashAlgorithm.Text = "Hash Algorithm:";
            // 
            // txtDigitalSignatureSignatureAlgorithm
            // 
            this.txtDigitalSignatureSignatureAlgorithm.Location = new System.Drawing.Point(138, 122);
            this.txtDigitalSignatureSignatureAlgorithm.Name = "txtDigitalSignatureSignatureAlgorithm";
            this.txtDigitalSignatureSignatureAlgorithm.ReadOnly = true;
            this.txtDigitalSignatureSignatureAlgorithm.Size = new System.Drawing.Size(837, 20);
            this.txtDigitalSignatureSignatureAlgorithm.TabIndex = 107;
            // 
            // lblDigitalSignatureSignatureAlgorithm
            // 
            this.lblDigitalSignatureSignatureAlgorithm.AutoSize = true;
            this.lblDigitalSignatureSignatureAlgorithm.Location = new System.Drawing.Point(7, 125);
            this.lblDigitalSignatureSignatureAlgorithm.Name = "lblDigitalSignatureSignatureAlgorithm";
            this.lblDigitalSignatureSignatureAlgorithm.Size = new System.Drawing.Size(101, 13);
            this.lblDigitalSignatureSignatureAlgorithm.TabIndex = 106;
            this.lblDigitalSignatureSignatureAlgorithm.Text = "Signature Algorithm:";
            // 
            // cboDigitalSignatureEncoding
            // 
            this.cboDigitalSignatureEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDigitalSignatureEncoding.FormattingEnabled = true;
            this.cboDigitalSignatureEncoding.Location = new System.Drawing.Point(138, 330);
            this.cboDigitalSignatureEncoding.Name = "cboDigitalSignatureEncoding";
            this.cboDigitalSignatureEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboDigitalSignatureEncoding.Sorted = true;
            this.cboDigitalSignatureEncoding.TabIndex = 104;
            this.cboDigitalSignatureEncoding.SelectedIndexChanged += new System.EventHandler(this.cboDigitalSignatureEncoding_SelectedIndexChanged);
            // 
            // lblDigitalSignatureEncoding
            // 
            this.lblDigitalSignatureEncoding.AutoSize = true;
            this.lblDigitalSignatureEncoding.Location = new System.Drawing.Point(7, 335);
            this.lblDigitalSignatureEncoding.Name = "lblDigitalSignatureEncoding";
            this.lblDigitalSignatureEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblDigitalSignatureEncoding.TabIndex = 103;
            this.lblDigitalSignatureEncoding.Text = "Encoding:";
            // 
            // btnDigitalSignatureVerifyText
            // 
            this.btnDigitalSignatureVerifyText.Location = new System.Drawing.Point(266, 412);
            this.btnDigitalSignatureVerifyText.Name = "btnDigitalSignatureVerifyText";
            this.btnDigitalSignatureVerifyText.Size = new System.Drawing.Size(121, 23);
            this.btnDigitalSignatureVerifyText.TabIndex = 100;
            this.btnDigitalSignatureVerifyText.Text = "Verify";
            this.btnDigitalSignatureVerifyText.UseVisualStyleBackColor = true;
            this.btnDigitalSignatureVerifyText.Click += new System.EventHandler(this.btnDigitalSignatureVerifyText_Click);
            // 
            // btnDigitalSignatureSignText
            // 
            this.btnDigitalSignatureSignText.Location = new System.Drawing.Point(139, 412);
            this.btnDigitalSignatureSignText.Name = "btnDigitalSignatureSignText";
            this.btnDigitalSignatureSignText.Size = new System.Drawing.Size(121, 23);
            this.btnDigitalSignatureSignText.TabIndex = 96;
            this.btnDigitalSignatureSignText.Text = "Sign";
            this.btnDigitalSignatureSignText.UseVisualStyleBackColor = true;
            this.btnDigitalSignatureSignText.Click += new System.EventHandler(this.btnDigitalSignatureSignText_Click);
            // 
            // txtDigitalSignatureTextToBeSigned
            // 
            this.txtDigitalSignatureTextToBeSigned.Location = new System.Drawing.Point(138, 357);
            this.txtDigitalSignatureTextToBeSigned.Name = "txtDigitalSignatureTextToBeSigned";
            this.txtDigitalSignatureTextToBeSigned.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDigitalSignatureTextToBeSigned.Size = new System.Drawing.Size(837, 20);
            this.txtDigitalSignatureTextToBeSigned.TabIndex = 94;
            this.txtDigitalSignatureTextToBeSigned.Text = "Lorem ipsum dolor sit amet.";
            this.txtDigitalSignatureTextToBeSigned.TextChanged += new System.EventHandler(this.txtDigitalSignatureTextToBeSigned_TextChanged);
            // 
            // btnDigitalSignatureCreateKey
            // 
            this.btnDigitalSignatureCreateKey.Location = new System.Drawing.Point(846, 152);
            this.btnDigitalSignatureCreateKey.Name = "btnDigitalSignatureCreateKey";
            this.btnDigitalSignatureCreateKey.Size = new System.Drawing.Size(129, 23);
            this.btnDigitalSignatureCreateKey.TabIndex = 92;
            this.btnDigitalSignatureCreateKey.Text = "Create Signature Key";
            this.btnDigitalSignatureCreateKey.UseVisualStyleBackColor = true;
            this.btnDigitalSignatureCreateKey.Click += new System.EventHandler(this.btnDigitalSignatureCreateKey_Click);
            // 
            // txtDigitalSignatureKeyXml
            // 
            this.txtDigitalSignatureKeyXml.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtDigitalSignatureKeyXml.Location = new System.Drawing.Point(138, 154);
            this.txtDigitalSignatureKeyXml.Multiline = true;
            this.txtDigitalSignatureKeyXml.Name = "txtDigitalSignatureKeyXml";
            this.txtDigitalSignatureKeyXml.ReadOnly = true;
            this.txtDigitalSignatureKeyXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDigitalSignatureKeyXml.Size = new System.Drawing.Size(702, 170);
            this.txtDigitalSignatureKeyXml.TabIndex = 91;
            this.txtDigitalSignatureKeyXml.TextChanged += new System.EventHandler(this.txtDigitalSignatureKeyXml_TextChanged);
            // 
            // lblDigitalSignatureKeyXml
            // 
            this.lblDigitalSignatureKeyXml.AutoSize = true;
            this.lblDigitalSignatureKeyXml.Location = new System.Drawing.Point(7, 157);
            this.lblDigitalSignatureKeyXml.Name = "lblDigitalSignatureKeyXml";
            this.lblDigitalSignatureKeyXml.Size = new System.Drawing.Size(49, 13);
            this.lblDigitalSignatureKeyXml.TabIndex = 90;
            this.lblDigitalSignatureKeyXml.Text = "Key Pair:";
            // 
            // txtDigitalSignatureKeyExchangeAlgorithm
            // 
            this.txtDigitalSignatureKeyExchangeAlgorithm.Location = new System.Drawing.Point(138, 96);
            this.txtDigitalSignatureKeyExchangeAlgorithm.Name = "txtDigitalSignatureKeyExchangeAlgorithm";
            this.txtDigitalSignatureKeyExchangeAlgorithm.ReadOnly = true;
            this.txtDigitalSignatureKeyExchangeAlgorithm.Size = new System.Drawing.Size(837, 20);
            this.txtDigitalSignatureKeyExchangeAlgorithm.TabIndex = 89;
            // 
            // lblDigitalSignatureKeyExchangeAlgorithm
            // 
            this.lblDigitalSignatureKeyExchangeAlgorithm.AutoSize = true;
            this.lblDigitalSignatureKeyExchangeAlgorithm.Location = new System.Drawing.Point(7, 99);
            this.lblDigitalSignatureKeyExchangeAlgorithm.Name = "lblDigitalSignatureKeyExchangeAlgorithm";
            this.lblDigitalSignatureKeyExchangeAlgorithm.Size = new System.Drawing.Size(125, 13);
            this.lblDigitalSignatureKeyExchangeAlgorithm.TabIndex = 88;
            this.lblDigitalSignatureKeyExchangeAlgorithm.Text = "Key Exchange Algorithm:";
            // 
            // txtDigitalSignatureKeySize
            // 
            this.txtDigitalSignatureKeySize.Location = new System.Drawing.Point(138, 70);
            this.txtDigitalSignatureKeySize.MaxLength = 5;
            this.txtDigitalSignatureKeySize.Name = "txtDigitalSignatureKeySize";
            this.txtDigitalSignatureKeySize.Size = new System.Drawing.Size(121, 20);
            this.txtDigitalSignatureKeySize.TabIndex = 87;
            this.txtDigitalSignatureKeySize.TextChanged += new System.EventHandler(this.txtDigitalSignatureKeySize_TextChanged);
            // 
            // lblDigitalSignatureKeySizeBits
            // 
            this.lblDigitalSignatureKeySizeBits.AutoSize = true;
            this.lblDigitalSignatureKeySizeBits.Location = new System.Drawing.Point(263, 73);
            this.lblDigitalSignatureKeySizeBits.Name = "lblDigitalSignatureKeySizeBits";
            this.lblDigitalSignatureKeySizeBits.Size = new System.Drawing.Size(23, 13);
            this.lblDigitalSignatureKeySizeBits.TabIndex = 86;
            this.lblDigitalSignatureKeySizeBits.Text = "bits";
            // 
            // lblDigitalSignatureKeySize
            // 
            this.lblDigitalSignatureKeySize.AutoSize = true;
            this.lblDigitalSignatureKeySize.Location = new System.Drawing.Point(7, 73);
            this.lblDigitalSignatureKeySize.Name = "lblDigitalSignatureKeySize";
            this.lblDigitalSignatureKeySize.Size = new System.Drawing.Size(51, 13);
            this.lblDigitalSignatureKeySize.TabIndex = 85;
            this.lblDigitalSignatureKeySize.Text = "Key Size:";
            // 
            // cboDigitalSignatureAlgorithm
            // 
            this.cboDigitalSignatureAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDigitalSignatureAlgorithm.FormattingEnabled = true;
            this.cboDigitalSignatureAlgorithm.Location = new System.Drawing.Point(138, 16);
            this.cboDigitalSignatureAlgorithm.Name = "cboDigitalSignatureAlgorithm";
            this.cboDigitalSignatureAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboDigitalSignatureAlgorithm.TabIndex = 84;
            this.cboDigitalSignatureAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboDigitalSignatureAlgorithm_SelectedIndexChanged);
            // 
            // lblDigitalSignatureAlgorithm
            // 
            this.lblDigitalSignatureAlgorithm.AutoSize = true;
            this.lblDigitalSignatureAlgorithm.Location = new System.Drawing.Point(7, 19);
            this.lblDigitalSignatureAlgorithm.Name = "lblDigitalSignatureAlgorithm";
            this.lblDigitalSignatureAlgorithm.Size = new System.Drawing.Size(101, 13);
            this.lblDigitalSignatureAlgorithm.TabIndex = 83;
            this.lblDigitalSignatureAlgorithm.Text = "Signature Algorithm:";
            // 
            // tabInMemoryEncryption
            // 
            this.tabInMemoryEncryption.Controls.Add(this.cboProtectionScope);
            this.tabInMemoryEncryption.Controls.Add(this.lblProtectionScope);
            this.tabInMemoryEncryption.Controls.Add(this.txtUnprotectedData);
            this.tabInMemoryEncryption.Controls.Add(this.lblUnprotectedData);
            this.tabInMemoryEncryption.Controls.Add(this.txtProtectedData);
            this.tabInMemoryEncryption.Controls.Add(this.lblProtectedData);
            this.tabInMemoryEncryption.Controls.Add(this.btnProtect);
            this.tabInMemoryEncryption.Controls.Add(this.cboProtectionEncoding);
            this.tabInMemoryEncryption.Controls.Add(this.lblProtectionEncoding);
            this.tabInMemoryEncryption.Controls.Add(this.txtProtectionRawData);
            this.tabInMemoryEncryption.Controls.Add(this.btnUnprotect);
            this.tabInMemoryEncryption.Controls.Add(this.lblProtectionRawData);
            this.tabInMemoryEncryption.Controls.Add(this.cboProtectionAlgorithm);
            this.tabInMemoryEncryption.Controls.Add(this.lblProtectionAlgorithm);
            this.tabInMemoryEncryption.Controls.Add(this.txtTextToBeProtected);
            this.tabInMemoryEncryption.Controls.Add(this.lblTextToBeProtected);
            this.tabInMemoryEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabInMemoryEncryption.Name = "tabInMemoryEncryption";
            this.tabInMemoryEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabInMemoryEncryption.Size = new System.Drawing.Size(981, 950);
            this.tabInMemoryEncryption.TabIndex = 8;
            this.tabInMemoryEncryption.Text = "In-Memory Protection";
            this.tabInMemoryEncryption.UseVisualStyleBackColor = true;
            // 
            // cboProtectionScope
            // 
            this.cboProtectionScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtectionScope.FormattingEnabled = true;
            this.cboProtectionScope.Location = new System.Drawing.Point(125, 43);
            this.cboProtectionScope.Name = "cboProtectionScope";
            this.cboProtectionScope.Size = new System.Drawing.Size(121, 21);
            this.cboProtectionScope.TabIndex = 63;
            this.cboProtectionScope.SelectedIndexChanged += new System.EventHandler(this.cboProtectionScope_SelectedIndexChanged);
            // 
            // lblProtectionScope
            // 
            this.lblProtectionScope.AutoSize = true;
            this.lblProtectionScope.Location = new System.Drawing.Point(6, 46);
            this.lblProtectionScope.Name = "lblProtectionScope";
            this.lblProtectionScope.Size = new System.Drawing.Size(92, 13);
            this.lblProtectionScope.TabIndex = 62;
            this.lblProtectionScope.Text = "Protection Scope:";
            // 
            // txtUnprotectedData
            // 
            this.txtUnprotectedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUnprotectedData.Location = new System.Drawing.Point(125, 233);
            this.txtUnprotectedData.Name = "txtUnprotectedData";
            this.txtUnprotectedData.ReadOnly = true;
            this.txtUnprotectedData.Size = new System.Drawing.Size(850, 20);
            this.txtUnprotectedData.TabIndex = 61;
            // 
            // lblUnprotectedData
            // 
            this.lblUnprotectedData.AutoSize = true;
            this.lblUnprotectedData.Location = new System.Drawing.Point(6, 236);
            this.lblUnprotectedData.Name = "lblUnprotectedData";
            this.lblUnprotectedData.Size = new System.Drawing.Size(95, 13);
            this.lblUnprotectedData.TabIndex = 60;
            this.lblUnprotectedData.Text = "Unprotected Data:";
            // 
            // txtProtectedData
            // 
            this.txtProtectedData.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtProtectedData.Location = new System.Drawing.Point(125, 178);
            this.txtProtectedData.Name = "txtProtectedData";
            this.txtProtectedData.ReadOnly = true;
            this.txtProtectedData.Size = new System.Drawing.Size(850, 20);
            this.txtProtectedData.TabIndex = 59;
            // 
            // lblProtectedData
            // 
            this.lblProtectedData.AutoSize = true;
            this.lblProtectedData.Location = new System.Drawing.Point(6, 181);
            this.lblProtectedData.Name = "lblProtectedData";
            this.lblProtectedData.Size = new System.Drawing.Size(82, 13);
            this.lblProtectedData.TabIndex = 58;
            this.lblProtectedData.Text = "Protected Data:";
            // 
            // btnProtect
            // 
            this.btnProtect.Location = new System.Drawing.Point(125, 123);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(121, 23);
            this.btnProtect.TabIndex = 57;
            this.btnProtect.Text = "Protect";
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.btnProtect_Click);
            // 
            // cboProtectionEncoding
            // 
            this.cboProtectionEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtectionEncoding.FormattingEnabled = true;
            this.cboProtectionEncoding.Location = new System.Drawing.Point(125, 70);
            this.cboProtectionEncoding.Name = "cboProtectionEncoding";
            this.cboProtectionEncoding.Size = new System.Drawing.Size(121, 21);
            this.cboProtectionEncoding.Sorted = true;
            this.cboProtectionEncoding.TabIndex = 56;
            this.cboProtectionEncoding.SelectedIndexChanged += new System.EventHandler(this.cboProtectionEncoding_SelectedIndexChanged);
            // 
            // lblProtectionEncoding
            // 
            this.lblProtectionEncoding.AutoSize = true;
            this.lblProtectionEncoding.Location = new System.Drawing.Point(6, 73);
            this.lblProtectionEncoding.Name = "lblProtectionEncoding";
            this.lblProtectionEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblProtectionEncoding.TabIndex = 55;
            this.lblProtectionEncoding.Text = "Encoding:";
            // 
            // txtProtectionRawData
            // 
            this.txtProtectionRawData.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtProtectionRawData.Location = new System.Drawing.Point(125, 152);
            this.txtProtectionRawData.Name = "txtProtectionRawData";
            this.txtProtectionRawData.ReadOnly = true;
            this.txtProtectionRawData.Size = new System.Drawing.Size(850, 20);
            this.txtProtectionRawData.TabIndex = 51;
            // 
            // btnUnprotect
            // 
            this.btnUnprotect.Location = new System.Drawing.Point(125, 204);
            this.btnUnprotect.Name = "btnUnprotect";
            this.btnUnprotect.Size = new System.Drawing.Size(121, 23);
            this.btnUnprotect.TabIndex = 50;
            this.btnUnprotect.Text = "Unprotect";
            this.btnUnprotect.UseVisualStyleBackColor = true;
            this.btnUnprotect.Click += new System.EventHandler(this.btnUnprotect_Click);
            // 
            // lblProtectionRawData
            // 
            this.lblProtectionRawData.AutoSize = true;
            this.lblProtectionRawData.Location = new System.Drawing.Point(6, 155);
            this.lblProtectionRawData.Name = "lblProtectionRawData";
            this.lblProtectionRawData.Size = new System.Drawing.Size(58, 13);
            this.lblProtectionRawData.TabIndex = 49;
            this.lblProtectionRawData.Text = "Raw Data:";
            // 
            // cboProtectionAlgorithm
            // 
            this.cboProtectionAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtectionAlgorithm.FormattingEnabled = true;
            this.cboProtectionAlgorithm.Location = new System.Drawing.Point(125, 16);
            this.cboProtectionAlgorithm.Name = "cboProtectionAlgorithm";
            this.cboProtectionAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cboProtectionAlgorithm.TabIndex = 48;
            this.cboProtectionAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cboProtectionAlgorithm_SelectedIndexChanged);
            // 
            // lblProtectionAlgorithm
            // 
            this.lblProtectionAlgorithm.AutoSize = true;
            this.lblProtectionAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.lblProtectionAlgorithm.Name = "lblProtectionAlgorithm";
            this.lblProtectionAlgorithm.Size = new System.Drawing.Size(104, 13);
            this.lblProtectionAlgorithm.TabIndex = 47;
            this.lblProtectionAlgorithm.Text = "Protection Algorithm:";
            // 
            // txtTextToBeProtected
            // 
            this.txtTextToBeProtected.Location = new System.Drawing.Point(125, 97);
            this.txtTextToBeProtected.Name = "txtTextToBeProtected";
            this.txtTextToBeProtected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextToBeProtected.Size = new System.Drawing.Size(850, 20);
            this.txtTextToBeProtected.TabIndex = 44;
            this.txtTextToBeProtected.Text = "Lorem ipsum dolor sit amet......";
            this.txtTextToBeProtected.TextChanged += new System.EventHandler(this.txtTextToBeProtected_TextChanged);
            // 
            // lblTextToBeProtected
            // 
            this.lblTextToBeProtected.AutoSize = true;
            this.lblTextToBeProtected.Location = new System.Drawing.Point(6, 100);
            this.lblTextToBeProtected.Name = "lblTextToBeProtected";
            this.lblTextToBeProtected.Size = new System.Drawing.Size(106, 13);
            this.lblTextToBeProtected.TabIndex = 43;
            this.lblTextToBeProtected.Text = "Text to be protected:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 998);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Crypto Samples (C# for .NET 2.0)";
            this.tabControl.ResumeLayout(false);
            this.tabRandomNumberGenerator.ResumeLayout(false);
            this.tabRandomNumberGenerator.PerformLayout();
            this.tabHashing.ResumeLayout(false);
            this.tabHashing.PerformLayout();
            this.tabSaltedHashing.ResumeLayout(false);
            this.tabSaltedHashing.PerformLayout();
            this.tabMessageAuthenticationCode.ResumeLayout(false);
            this.tabMessageAuthenticationCode.PerformLayout();
            this.tabSymmetricEncryption.ResumeLayout(false);
            this.tabSymmetricEncryption.PerformLayout();
            this.tabAsymmetricAlgorithm.ResumeLayout(false);
            this.tabAsymmetricAlgorithm.PerformLayout();
            this.tabHybridEncryption.ResumeLayout(false);
            this.tabHybridEncryption.PerformLayout();
            this.tabDigitalSignature.ResumeLayout(false);
            this.tabDigitalSignature.PerformLayout();
            this.tabInMemoryEncryption.ResumeLayout(false);
            this.tabInMemoryEncryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHashing;
        private System.Windows.Forms.Button btnChooseFileToBeHashed;
        private System.Windows.Forms.TextBox txtFileToBeHashed;
        private System.Windows.Forms.TextBox txtTextToBeHashed;
        private System.Windows.Forms.TextBox txtMessageDigest;
        private System.Windows.Forms.Button btnHashInput;
        private System.Windows.Forms.Label lblMessageDigest;
        private System.Windows.Forms.ComboBox cboHashAlgorithm;
        private System.Windows.Forms.Label lblHashAlgorithm;
        private System.Windows.Forms.TextBox txtDigestSize;
        private System.Windows.Forms.Label lblDigestSize;
        private System.Windows.Forms.Label lblHashSizeBits;
        private System.Windows.Forms.TabPage tabSymmetricEncryption;
        private System.Windows.Forms.Label lblEncryptedValueSizeBytes;
        private System.Windows.Forms.TextBox txtEncryptedValueSize;
        private System.Windows.Forms.Label lblEncryptedValueSize;
        private System.Windows.Forms.TextBox txtSymmetricallyEncryptedValue;
        private System.Windows.Forms.Button btnEncryptSymmetrically;
        private System.Windows.Forms.Label lblSymmetricallyEncryptedValue;
        private System.Windows.Forms.Label lblSymmetricEncryptionInitializationVector;
        private System.Windows.Forms.Button btnCreateSymmetricKey;
        private System.Windows.Forms.TextBox txtSymmetricKey;
        private System.Windows.Forms.Label lblSymmetricKey;
        private System.Windows.Forms.TextBox txtInputToBeSymmetricallyEncrypted;
        private System.Windows.Forms.Label lblTextToBeSymmetricallyEncrypted;
        private System.Windows.Forms.Label lblSymmetricKeySize;
        private System.Windows.Forms.ComboBox cboSymmetricAlgorithm;
        private System.Windows.Forms.Label lblSymmetricAlgorithm;
        private System.Windows.Forms.TextBox txtSymmetricEncryptionInitializationVector;
        private System.Windows.Forms.Label lblSymmetricBlockSize;
        private System.Windows.Forms.Label lblSymmetricBlockSizeBits;
        private System.Windows.Forms.Label lblSymmetricKeySizeBits;
        private System.Windows.Forms.ComboBox cboSymmetricPaddingMode;
        private System.Windows.Forms.Label lblSymmetricPaddingMode;
        private System.Windows.Forms.ComboBox cboSymmetricCipherMode;
        private System.Windows.Forms.Label lblSymmetricCipherMode;
        private System.Windows.Forms.Button btnCreateInitializationVector;
        private System.Windows.Forms.TextBox txtSymmetricallyDecryptedValue;
        private System.Windows.Forms.Label lblSymmetricallyDecryptedValue;
        private System.Windows.Forms.Button btnDecryptSymmetrically;
        private System.Windows.Forms.ComboBox cboHashEncoding;
        private System.Windows.Forms.Label lblHashEncoding;
        private System.Windows.Forms.ComboBox cboSymmetricEncoding;
        private System.Windows.Forms.Label lblSymmetricEncoding;
        private System.Windows.Forms.TabPage tabAsymmetricAlgorithm;
        private System.Windows.Forms.TabPage tabDigitalSignature;
        private System.Windows.Forms.TabPage tabHybridEncryption;
        private System.Windows.Forms.TabPage tabSaltedHashing;
        private System.Windows.Forms.TabPage tabRandomNumberGenerator;
        private System.Windows.Forms.TabPage tabMessageAuthenticationCode;
        private System.Windows.Forms.TabPage tabInMemoryEncryption;
        private System.Windows.Forms.TextBox txtSymmetricKeySize;
        private System.Windows.Forms.TextBox txtSymmetricBlockSize;
        private System.Windows.Forms.ComboBox cboAsymmetricAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsymmetricKeySize;
        private System.Windows.Forms.Label lblAsymmetricKeySizeBits;
        private System.Windows.Forms.Label lblAsymmetricKeySize;
        private System.Windows.Forms.Label lblPublicPrivateKey;
        private System.Windows.Forms.TextBox txtAsymmetricKeyExchangeAlgorithm;
        private System.Windows.Forms.Label lblAsymmetricKeyExchangeAlgorithm;
        private System.Windows.Forms.ComboBox cboAsymmetricEncoding;
        private System.Windows.Forms.Label lblAsymmetricEncoding;
        private System.Windows.Forms.TextBox txtAsymmetricallyDecryptedValue;
        private System.Windows.Forms.Label lblAsymmetricallyDecryptedValue;
        private System.Windows.Forms.Button btnAsymmetricallyDecrypt;
        private System.Windows.Forms.TextBox txtAsymmetricallyEncryptedValueSize;
        private System.Windows.Forms.Label lblAsymmetricallyEncryptedValueSize;
        private System.Windows.Forms.TextBox txtAsymmetricallyEncryptedValue;
        private System.Windows.Forms.Button btnEncryptAsymmetrically;
        private System.Windows.Forms.Label lblAsymmetricallyEncryptedValue;
        private System.Windows.Forms.TextBox txtAsymmetricTextToBeEncrypted;
        private System.Windows.Forms.Label lblAsymmetricTextToBeEncrypted;
        private System.Windows.Forms.Button btnCreateAsymmetricKey;
        private System.Windows.Forms.TextBox txtPublicPrivateKey;
        private System.Windows.Forms.Label txtAsymmetricallyEncryptedValueSizeBytes;
        private System.Windows.Forms.ComboBox cboAsymmetricEncryptionPaddingMode;
        private System.Windows.Forms.Label lblAsymmetricEncryptionPaddingMode;
        private System.Windows.Forms.ComboBox cboRngAlgorithm;
        private System.Windows.Forms.Label lblRngAlgorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRngCountBytes;
        private System.Windows.Forms.Label lblRngCountBytes;
        private System.Windows.Forms.Button btnRngGenerateBytes;
        private System.Windows.Forms.TextBox txtRngGeneratedBytes;
        private System.Windows.Forms.Label lblRngGeneratedBytes;
        private System.Windows.Forms.Button btnDeriveSymmetricKeyFromPassphrase;
        private System.Windows.Forms.TextBox txtSymmetricEncryptionPassphrase;
        private System.Windows.Forms.Label lblSymmetricEncryptionPassphrase;
        private System.Windows.Forms.Button btnSaltedHashInput;
        private System.Windows.Forms.ComboBox cboSaltedHashEncoding;
        private System.Windows.Forms.Label lblSaltedHashEncoding;
        private System.Windows.Forms.Label lblSaltedDigestSizeBits;
        private System.Windows.Forms.TextBox txtSaltedDigestSize;
        private System.Windows.Forms.Label lblSaltedDigestSize;
        private System.Windows.Forms.TextBox txtUnsaltedHash;
        private System.Windows.Forms.Label lblUnsaltedHash;
        private System.Windows.Forms.ComboBox cboSaltedHashAlgorithm;
        private System.Windows.Forms.Label lblSaltedHashAlgorithm;
        private System.Windows.Forms.TextBox txtFileToBeSaltedHashed;
        private System.Windows.Forms.TextBox txtTextToBeSaltedHashed;
        private System.Windows.Forms.TextBox txtRandomSalt;
        private System.Windows.Forms.Label lblRandomSalt;
        private System.Windows.Forms.TextBox txtSaltedMessageDigest;
        private System.Windows.Forms.Label lblSaltedMessageDigest;
        private System.Windows.Forms.TextBox txtSaltedHash;
        private System.Windows.Forms.Label lblSaltedHash;
        private System.Windows.Forms.Button btnChooseFileToBeSaltedHashed;
        private System.Windows.Forms.TextBox txtUnprotectedData;
        private System.Windows.Forms.Label lblUnprotectedData;
        private System.Windows.Forms.TextBox txtProtectedData;
        private System.Windows.Forms.Label lblProtectedData;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.ComboBox cboProtectionEncoding;
        private System.Windows.Forms.Label lblProtectionEncoding;
        private System.Windows.Forms.TextBox txtProtectionRawData;
        private System.Windows.Forms.Button btnUnprotect;
        private System.Windows.Forms.Label lblProtectionRawData;
        private System.Windows.Forms.ComboBox cboProtectionAlgorithm;
        private System.Windows.Forms.Label lblProtectionAlgorithm;
        private System.Windows.Forms.TextBox txtTextToBeProtected;
        private System.Windows.Forms.Label lblTextToBeProtected;
        private System.Windows.Forms.ComboBox cboProtectionScope;
        private System.Windows.Forms.Label lblProtectionScope;
        private System.Windows.Forms.ComboBox cboDigitalSignatureEncoding;
        private System.Windows.Forms.Label lblDigitalSignatureEncoding;
        private System.Windows.Forms.Button btnDigitalSignatureVerifyText;
        private System.Windows.Forms.Button btnDigitalSignatureSignText;
        private System.Windows.Forms.TextBox txtDigitalSignatureTextToBeSigned;
        private System.Windows.Forms.Button btnDigitalSignatureCreateKey;
        private System.Windows.Forms.TextBox txtDigitalSignatureKeyXml;
        private System.Windows.Forms.Label lblDigitalSignatureKeyXml;
        private System.Windows.Forms.TextBox txtDigitalSignatureKeyExchangeAlgorithm;
        private System.Windows.Forms.Label lblDigitalSignatureKeyExchangeAlgorithm;
        private System.Windows.Forms.TextBox txtDigitalSignatureKeySize;
        private System.Windows.Forms.Label lblDigitalSignatureKeySizeBits;
        private System.Windows.Forms.Label lblDigitalSignatureKeySize;
        private System.Windows.Forms.ComboBox cboDigitalSignatureAlgorithm;
        private System.Windows.Forms.Label lblDigitalSignatureAlgorithm;
        private System.Windows.Forms.TextBox txtDigitalSignatureSignatureAlgorithm;
        private System.Windows.Forms.Label lblDigitalSignatureSignatureAlgorithm;
        private System.Windows.Forms.ComboBox cboDigitalSignatureHashAlgorithm;
        private System.Windows.Forms.Label lblDigitalSignatureHashAlgorithm;
        private System.Windows.Forms.Button btnDigitalSignatureChooseFile;
        private System.Windows.Forms.TextBox txtDigitalSignatureFileToBeSigned;
        private System.Windows.Forms.TextBox txtDigitalSignatureVerification;
        private System.Windows.Forms.Label lblDigitalSignatureVerification;
        private System.Windows.Forms.Label lblDigitalSignatureSizeBits;
        private System.Windows.Forms.TextBox txtDigitalSignatureSize;
        private System.Windows.Forms.Label lblDigitalSignatureSize;
        private System.Windows.Forms.TextBox txtDigitalSignatureResult;
        private System.Windows.Forms.Label lblDigitalSignatureResult;
        private System.Windows.Forms.TextBox txtMacSecretKey;
        private System.Windows.Forms.Label lblMacSecretKey;
        private System.Windows.Forms.Button btnMacHashText;
        private System.Windows.Forms.ComboBox cboMacEncoding;
        private System.Windows.Forms.Label lblMacEncoding;
        private System.Windows.Forms.Label lblMacDigestSizeBits;
        private System.Windows.Forms.TextBox txtMacDigestSize;
        private System.Windows.Forms.Label lblMacDigestSize;
        private System.Windows.Forms.TextBox txtMacMessageDigest;
        private System.Windows.Forms.Label lblMacMessageDigest;
        private System.Windows.Forms.ComboBox cboMacAlgorithm;
        private System.Windows.Forms.Label lblMacAlgorithm;
        private System.Windows.Forms.Button btnMacChooseFile;
        private System.Windows.Forms.TextBox txtMacFileToBeHashed;
        private System.Windows.Forms.TextBox txtMacTextToBeHashed;
        private System.Windows.Forms.TextBox txtMacAuthentication;
        private System.Windows.Forms.Label lblMacAuthentication;
        private System.Windows.Forms.Button btnMacAuthenticateText;
        private System.Windows.Forms.ComboBox cboHybridEncryptionAsymmetricAlgorithmPaddingMode;
        private System.Windows.Forms.Label lblHybridEncryptionAsymmetricAlgorithmPaddingMode;
        private System.Windows.Forms.ComboBox cboHybridEncryptionEncoding;
        private System.Windows.Forms.Label lblHybridEncryptionEncoding;
        private System.Windows.Forms.Button btnHybridEncryptionEncrypt;
        private System.Windows.Forms.Button btnHybridEncryptionCreateAsymmetricKey;
        private System.Windows.Forms.TextBox txtHybridEncryptionAsymmetricAlgorithmKeyXml;
        private System.Windows.Forms.Label lblHybridEncryptionAsymmetricAlgorithmKeyXml;
        private System.Windows.Forms.TextBox txtHybridEncryptionAsymmetricAlgorithmKeySize;
        private System.Windows.Forms.Label lblHybridEncryptionAsymmetricAlgorithmKeySizeBits;
        private System.Windows.Forms.Label lblHybridEncryptionAsymmetricAlgorithmKeySize;
        private System.Windows.Forms.ComboBox cboHybridEncryptionAsymmetricAlgorithm;
        private System.Windows.Forms.Label lblHybridEncryptionAsymmetricAlgorithm;
        private System.Windows.Forms.TextBox txtHybridEncryptionTextToBeEncrypted;
        private System.Windows.Forms.Label lblHybridEncryptionTextToBeEncrypted;
        private System.Windows.Forms.TextBox txtHybridEncryptionSymmetricAlgorithmKeySize;
        private System.Windows.Forms.ComboBox cboHybridEncryptionSymmetricAlgorithmPaddingMode;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithmPaddingMode;
        private System.Windows.Forms.ComboBox cboHybridEncryptionSymmetricAlgorithmCipherMode;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithmCipherMode;
        private System.Windows.Forms.Button btnHybridEncryptionCreateIv;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithmKeySizeBits;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithmKeySize;
        private System.Windows.Forms.ComboBox cboHybridEncryptionSymmetricAlgorithm;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithm;
        private System.Windows.Forms.TextBox txtHybridEncryptionIv;
        private System.Windows.Forms.Label lblHybridEncryptionIv;
        private System.Windows.Forms.Button btnHybridEncryptionCreateSymmetricKey;
        private System.Windows.Forms.TextBox txtHybridEncryptionSymmetricKey;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricKey;
        private System.Windows.Forms.Label lblHybridEncryptionDecryptedText;
        private System.Windows.Forms.TextBox txtHybridEncryptionDecryptedSessionKey;
        private System.Windows.Forms.Label lblHybridEncryptionDecryptedSessionKey;
        private System.Windows.Forms.Button btnHybridEncryptionDecrypt;
        private System.Windows.Forms.TextBox txtHybridEncryptionEncryptedSessionKey;
        private System.Windows.Forms.Label lblHybridEncryptionEncryptedSessionKey;
        private System.Windows.Forms.TextBox txtHybridEncryptionEncryptedText;
        private System.Windows.Forms.Label lblHybridEncryptionEncryptedText;
        private System.Windows.Forms.TextBox txtHybridEncryptionDecryptedText;
        private System.Windows.Forms.TextBox txtHybridEncryptionDecryptedIV;
        private System.Windows.Forms.Label lblHybridEncryptionDecryptedIV;
        private System.Windows.Forms.TextBox txtHybridEncryptionEncryptedIV;
        private System.Windows.Forms.Label lblHybridEncryptionEncryptedIV;
        private System.Windows.Forms.RadioButton rdoHashingFileToBeHashed;
        private System.Windows.Forms.RadioButton rdoHashingTextToBeHashed;
        private System.Windows.Forms.RadioButton rdoFileToBeSaltedHashed;
        private System.Windows.Forms.RadioButton rdoTextToBeSaltedHashed;
        private System.Windows.Forms.RadioButton rdoMacFileToBeHashed;
        private System.Windows.Forms.RadioButton rdoMacTextToBeHashed;
        private System.Windows.Forms.RadioButton rdoDigitalSignatureFileToBeSigned;
        private System.Windows.Forms.RadioButton rdoDigitalSignatureTextToBeSigned;
        private System.Windows.Forms.TextBox txtHybridEncryptionSymmetricAlgorithmBlockSize;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithmBlockSizeBits;
        private System.Windows.Forms.Label lblHybridEncryptionSymmetricAlgorithmBlockSize;
    }
}

