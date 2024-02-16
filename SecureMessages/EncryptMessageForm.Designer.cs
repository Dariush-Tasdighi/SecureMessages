namespace SecureMessages;

partial class EncryptMessageForm
{
	private System.ComponentModel.IContainer components = null;

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
		selectPublicKeyButton = new System.Windows.Forms.Button();
		plainMessageLabel = new System.Windows.Forms.Label();
		plainMessageTextBox = new System.Windows.Forms.TextBox();
		encryptButton = new System.Windows.Forms.Button();
		encryptedMessageTextBox = new System.Windows.Forms.TextBox();
		copyToClipboardButton = new System.Windows.Forms.Button();
		mainPanel = new System.Windows.Forms.Panel();
		encryptedMessageLabel = new System.Windows.Forms.Label();
		mainSplitter = new System.Windows.Forms.Splitter();
		contentPanel = new System.Windows.Forms.Panel();
		publicKeyPemTextBox = new System.Windows.Forms.TextBox();
		publicKeyPemPathNameTextBox = new System.Windows.Forms.TextBox();
		mainPanel.SuspendLayout();
		contentPanel.SuspendLayout();
		SuspendLayout();
		// 
		// selectPublicKeyButton
		// 
		selectPublicKeyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		selectPublicKeyButton.Location = new System.Drawing.Point(3, 12);
		selectPublicKeyButton.Name = "selectPublicKeyButton";
		selectPublicKeyButton.Size = new System.Drawing.Size(427, 29);
		selectPublicKeyButton.TabIndex = 0;
		selectPublicKeyButton.Text = "Select Public Key Pem File";
		selectPublicKeyButton.UseVisualStyleBackColor = true;
		selectPublicKeyButton.Click += SelectPublicKeyButton_Click;
		// 
		// plainMessageLabel
		// 
		plainMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plainMessageLabel.Location = new System.Drawing.Point(3, 44);
		plainMessageLabel.Name = "plainMessageLabel";
		plainMessageLabel.Size = new System.Drawing.Size(427, 25);
		plainMessageLabel.TabIndex = 1;
		plainMessageLabel.Text = "&Plain Message";
		plainMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// plainMessageTextBox
		// 
		plainMessageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plainMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
		plainMessageTextBox.Location = new System.Drawing.Point(3, 72);
		plainMessageTextBox.Multiline = true;
		plainMessageTextBox.Name = "plainMessageTextBox";
		plainMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		plainMessageTextBox.Size = new System.Drawing.Size(427, 257);
		plainMessageTextBox.TabIndex = 2;
		// 
		// encryptButton
		// 
		encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		encryptButton.Location = new System.Drawing.Point(3, 335);
		encryptButton.Name = "encryptButton";
		encryptButton.Size = new System.Drawing.Size(427, 29);
		encryptButton.TabIndex = 3;
		encryptButton.Text = "&Encrypt";
		encryptButton.UseVisualStyleBackColor = true;
		encryptButton.Click += EncryptButton_Click;
		// 
		// encryptedMessageTextBox
		// 
		encryptedMessageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		encryptedMessageTextBox.BackColor = System.Drawing.Color.DimGray;
		encryptedMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
		encryptedMessageTextBox.ForeColor = System.Drawing.Color.White;
		encryptedMessageTextBox.Location = new System.Drawing.Point(3, 395);
		encryptedMessageTextBox.Multiline = true;
		encryptedMessageTextBox.Name = "encryptedMessageTextBox";
		encryptedMessageTextBox.ReadOnly = true;
		encryptedMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		encryptedMessageTextBox.Size = new System.Drawing.Size(427, 224);
		encryptedMessageTextBox.TabIndex = 5;
		// 
		// copyToClipboardButton
		// 
		copyToClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		copyToClipboardButton.Location = new System.Drawing.Point(3, 625);
		copyToClipboardButton.Name = "copyToClipboardButton";
		copyToClipboardButton.Size = new System.Drawing.Size(427, 29);
		copyToClipboardButton.TabIndex = 6;
		copyToClipboardButton.Text = "&Copy to Clipboard";
		copyToClipboardButton.UseVisualStyleBackColor = true;
		copyToClipboardButton.Click += CopyToClipboardButton_Click;
		// 
		// mainPanel
		// 
		mainPanel.Controls.Add(encryptedMessageLabel);
		mainPanel.Controls.Add(selectPublicKeyButton);
		mainPanel.Controls.Add(copyToClipboardButton);
		mainPanel.Controls.Add(plainMessageLabel);
		mainPanel.Controls.Add(encryptedMessageTextBox);
		mainPanel.Controls.Add(plainMessageTextBox);
		mainPanel.Controls.Add(encryptButton);
		mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
		mainPanel.Location = new System.Drawing.Point(0, 0);
		mainPanel.Name = "mainPanel";
		mainPanel.Size = new System.Drawing.Size(436, 657);
		mainPanel.TabIndex = 0;
		// 
		// encryptedMessageLabel
		// 
		encryptedMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		encryptedMessageLabel.Location = new System.Drawing.Point(3, 367);
		encryptedMessageLabel.Name = "encryptedMessageLabel";
		encryptedMessageLabel.Size = new System.Drawing.Size(427, 25);
		encryptedMessageLabel.TabIndex = 4;
		encryptedMessageLabel.Text = "&Encrypted Message";
		encryptedMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// mainSplitter
		// 
		mainSplitter.Location = new System.Drawing.Point(436, 0);
		mainSplitter.Name = "mainSplitter";
		mainSplitter.Size = new System.Drawing.Size(4, 657);
		mainSplitter.TabIndex = 7;
		mainSplitter.TabStop = false;
		// 
		// contentPanel
		// 
		contentPanel.Controls.Add(publicKeyPemTextBox);
		contentPanel.Controls.Add(publicKeyPemPathNameTextBox);
		contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
		contentPanel.Location = new System.Drawing.Point(440, 0);
		contentPanel.Name = "contentPanel";
		contentPanel.Size = new System.Drawing.Size(538, 657);
		contentPanel.TabIndex = 8;
		// 
		// publicKeyPemTextBox
		// 
		publicKeyPemTextBox.BackColor = System.Drawing.Color.DimGray;
		publicKeyPemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
		publicKeyPemTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
		publicKeyPemTextBox.ForeColor = System.Drawing.Color.White;
		publicKeyPemTextBox.Location = new System.Drawing.Point(0, 23);
		publicKeyPemTextBox.Multiline = true;
		publicKeyPemTextBox.Name = "publicKeyPemTextBox";
		publicKeyPemTextBox.ReadOnly = true;
		publicKeyPemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		publicKeyPemTextBox.Size = new System.Drawing.Size(538, 634);
		publicKeyPemTextBox.TabIndex = 1;
		// 
		// publicKeyPemPathNameTextBox
		// 
		publicKeyPemPathNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
		publicKeyPemPathNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
		publicKeyPemPathNameTextBox.Location = new System.Drawing.Point(0, 0);
		publicKeyPemPathNameTextBox.Name = "publicKeyPemPathNameTextBox";
		publicKeyPemPathNameTextBox.ReadOnly = true;
		publicKeyPemPathNameTextBox.Size = new System.Drawing.Size(538, 23);
		publicKeyPemPathNameTextBox.TabIndex = 0;
		// 
		// EncryptMessageForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(978, 657);
		Controls.Add(contentPanel);
		Controls.Add(mainSplitter);
		Controls.Add(mainPanel);
		Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
		Name = "EncryptMessageForm";
		Text = "Encrypt Message";
		Load += EncryptMessageForm_Load;
		mainPanel.ResumeLayout(false);
		mainPanel.PerformLayout();
		contentPanel.ResumeLayout(false);
		contentPanel.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private System.Windows.Forms.Button selectPublicKeyButton;
	private System.Windows.Forms.Label plainMessageLabel;
	private System.Windows.Forms.TextBox plainMessageTextBox;
	private System.Windows.Forms.Button encryptButton;
	private System.Windows.Forms.TextBox encryptedMessageTextBox;
	private System.Windows.Forms.Button copyToClipboardButton;
	private System.Windows.Forms.Panel mainPanel;
	private System.Windows.Forms.Splitter mainSplitter;
	private System.Windows.Forms.Panel contentPanel;
	private System.Windows.Forms.TextBox publicKeyPemTextBox;
	private System.Windows.Forms.TextBox publicKeyPemPathNameTextBox;
	private System.Windows.Forms.Label encryptedMessageLabel;
}