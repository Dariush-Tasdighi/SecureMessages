namespace SecureMessages
{
	partial class DecryptEncryptedMessageForm
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
			mainPanel = new System.Windows.Forms.Panel();
			decryptButton = new System.Windows.Forms.Button();
			copyToClipboardButton = new System.Windows.Forms.Button();
			plainMessageTextBox = new System.Windows.Forms.TextBox();
			plainTextMessageLabel = new System.Windows.Forms.Label();
			encryptedMessageTextBox = new System.Windows.Forms.TextBox();
			encryptedMessageLabel = new System.Windows.Forms.Label();
			selectPrivateKeyButton = new System.Windows.Forms.Button();
			privateKeyPemPasswordTextBox = new System.Windows.Forms.TextBox();
			privateKeyPemPasswordLabel = new System.Windows.Forms.Label();
			mainSplitter = new System.Windows.Forms.Splitter();
			contentPanel = new System.Windows.Forms.Panel();
			privateKeyPemTextBox = new System.Windows.Forms.TextBox();
			privateKeyPemPathNameTextBox = new System.Windows.Forms.TextBox();
			mainPanel.SuspendLayout();
			contentPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainPanel
			// 
			mainPanel.Controls.Add(decryptButton);
			mainPanel.Controls.Add(copyToClipboardButton);
			mainPanel.Controls.Add(plainMessageTextBox);
			mainPanel.Controls.Add(plainTextMessageLabel);
			mainPanel.Controls.Add(encryptedMessageTextBox);
			mainPanel.Controls.Add(encryptedMessageLabel);
			mainPanel.Controls.Add(selectPrivateKeyButton);
			mainPanel.Controls.Add(privateKeyPemPasswordTextBox);
			mainPanel.Controls.Add(privateKeyPemPasswordLabel);
			mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
			mainPanel.Location = new System.Drawing.Point(0, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new System.Drawing.Size(435, 724);
			mainPanel.TabIndex = 0;
			// 
			// decryptButton
			// 
			decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			decryptButton.Location = new System.Drawing.Point(3, 396);
			decryptButton.Name = "decryptButton";
			decryptButton.Size = new System.Drawing.Size(426, 29);
			decryptButton.TabIndex = 5;
			decryptButton.Text = "&Decrypt";
			decryptButton.UseVisualStyleBackColor = true;
			decryptButton.Click += DecryptButton_Click;
			// 
			// copyToClipboardButton
			// 
			copyToClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			copyToClipboardButton.Location = new System.Drawing.Point(3, 692);
			copyToClipboardButton.Name = "copyToClipboardButton";
			copyToClipboardButton.Size = new System.Drawing.Size(426, 29);
			copyToClipboardButton.TabIndex = 8;
			copyToClipboardButton.Text = "&Copy to Clipboard";
			copyToClipboardButton.UseVisualStyleBackColor = true;
			copyToClipboardButton.Click += CopyToClipboardButton_Click;
			// 
			// plainMessageTextBox
			// 
			plainMessageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			plainMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			plainMessageTextBox.Location = new System.Drawing.Point(3, 456);
			plainMessageTextBox.Multiline = true;
			plainMessageTextBox.Name = "plainMessageTextBox";
			plainMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			plainMessageTextBox.Size = new System.Drawing.Size(426, 230);
			plainMessageTextBox.TabIndex = 7;
			// 
			// plainTextMessageLabel
			// 
			plainTextMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			plainTextMessageLabel.Location = new System.Drawing.Point(3, 428);
			plainTextMessageLabel.Name = "plainTextMessageLabel";
			plainTextMessageLabel.Size = new System.Drawing.Size(426, 25);
			plainTextMessageLabel.TabIndex = 6;
			plainTextMessageLabel.Text = "&Plain Message";
			plainTextMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// encryptedMessageTextBox
			// 
			encryptedMessageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			encryptedMessageTextBox.BackColor = System.Drawing.Color.DimGray;
			encryptedMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			encryptedMessageTextBox.ForeColor = System.Drawing.Color.White;
			encryptedMessageTextBox.Location = new System.Drawing.Point(3, 133);
			encryptedMessageTextBox.Multiline = true;
			encryptedMessageTextBox.Name = "encryptedMessageTextBox";
			encryptedMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			encryptedMessageTextBox.Size = new System.Drawing.Size(426, 257);
			encryptedMessageTextBox.TabIndex = 4;
			// 
			// encryptedMessageLabel
			// 
			encryptedMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			encryptedMessageLabel.Location = new System.Drawing.Point(3, 105);
			encryptedMessageLabel.Name = "encryptedMessageLabel";
			encryptedMessageLabel.Size = new System.Drawing.Size(426, 25);
			encryptedMessageLabel.TabIndex = 3;
			encryptedMessageLabel.Text = "&Encrypted Message";
			encryptedMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// selectPrivateKeyButton
			// 
			selectPrivateKeyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			selectPrivateKeyButton.Location = new System.Drawing.Point(3, 73);
			selectPrivateKeyButton.Name = "selectPrivateKeyButton";
			selectPrivateKeyButton.Size = new System.Drawing.Size(426, 29);
			selectPrivateKeyButton.TabIndex = 2;
			selectPrivateKeyButton.Text = "Select Private Key Pem File";
			selectPrivateKeyButton.UseVisualStyleBackColor = true;
			selectPrivateKeyButton.Click += selectPrivateKeyButton_Click;
			// 
			// privateKeyPemPasswordTextBox
			// 
			privateKeyPemPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			privateKeyPemPasswordTextBox.Enabled = false;
			privateKeyPemPasswordTextBox.Location = new System.Drawing.Point(3, 37);
			privateKeyPemPasswordTextBox.Name = "privateKeyPemPasswordTextBox";
			privateKeyPemPasswordTextBox.Size = new System.Drawing.Size(426, 30);
			privateKeyPemPasswordTextBox.TabIndex = 1;
			privateKeyPemPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// privateKeyPemPasswordLabel
			// 
			privateKeyPemPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			privateKeyPemPasswordLabel.Location = new System.Drawing.Point(3, 9);
			privateKeyPemPasswordLabel.Name = "privateKeyPemPasswordLabel";
			privateKeyPemPasswordLabel.Size = new System.Drawing.Size(426, 25);
			privateKeyPemPasswordLabel.TabIndex = 0;
			privateKeyPemPasswordLabel.Text = "Private Key Pem Password";
			privateKeyPemPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainSplitter
			// 
			mainSplitter.Location = new System.Drawing.Point(435, 0);
			mainSplitter.Name = "mainSplitter";
			mainSplitter.Size = new System.Drawing.Size(4, 724);
			mainSplitter.TabIndex = 1;
			mainSplitter.TabStop = false;
			// 
			// contentPanel
			// 
			contentPanel.Controls.Add(privateKeyPemTextBox);
			contentPanel.Controls.Add(privateKeyPemPathNameTextBox);
			contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			contentPanel.Location = new System.Drawing.Point(439, 0);
			contentPanel.Name = "contentPanel";
			contentPanel.Size = new System.Drawing.Size(538, 724);
			contentPanel.TabIndex = 2;
			// 
			// privateKeyPemTextBox
			// 
			privateKeyPemTextBox.BackColor = System.Drawing.Color.DimGray;
			privateKeyPemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			privateKeyPemTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			privateKeyPemTextBox.ForeColor = System.Drawing.Color.White;
			privateKeyPemTextBox.Location = new System.Drawing.Point(0, 23);
			privateKeyPemTextBox.Multiline = true;
			privateKeyPemTextBox.Name = "privateKeyPemTextBox";
			privateKeyPemTextBox.ReadOnly = true;
			privateKeyPemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			privateKeyPemTextBox.Size = new System.Drawing.Size(538, 701);
			privateKeyPemTextBox.TabIndex = 1;
			// 
			// privateKeyPemPathNameTextBox
			// 
			privateKeyPemPathNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			privateKeyPemPathNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			privateKeyPemPathNameTextBox.Location = new System.Drawing.Point(0, 0);
			privateKeyPemPathNameTextBox.Name = "privateKeyPemPathNameTextBox";
			privateKeyPemPathNameTextBox.ReadOnly = true;
			privateKeyPemPathNameTextBox.Size = new System.Drawing.Size(538, 23);
			privateKeyPemPathNameTextBox.TabIndex = 0;
			// 
			// DecryptEncryptedMessageForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(977, 724);
			Controls.Add(contentPanel);
			Controls.Add(mainSplitter);
			Controls.Add(mainPanel);
			Name = "DecryptEncryptedMessageForm";
			Text = "DecryptEncryptedMessageForm";
			Load += DecryptEncryptedMessageForm_Load;
			mainPanel.ResumeLayout(false);
			mainPanel.PerformLayout();
			contentPanel.ResumeLayout(false);
			contentPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Splitter mainSplitter;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.TextBox privateKeyPemPathNameTextBox;
		private System.Windows.Forms.TextBox privateKeyPemTextBox;
		private System.Windows.Forms.TextBox privateKeyPemPasswordTextBox;
		private System.Windows.Forms.Label privateKeyPemPasswordLabel;
		private System.Windows.Forms.Button selectPrivateKeyButton;
		private System.Windows.Forms.Label encryptedMessageLabel;
		private System.Windows.Forms.TextBox encryptedMessageTextBox;
		private System.Windows.Forms.Label plainTextMessageLabel;
		private System.Windows.Forms.TextBox plainMessageTextBox;
		private System.Windows.Forms.Button copyToClipboardButton;
		private System.Windows.Forms.Button decryptButton;
	}
}