namespace SecureMessages;

partial class MainForm
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		passwordLabel = new System.Windows.Forms.Label();
		passwordTextBox = new System.Windows.Forms.TextBox();
		encryptButton = new System.Windows.Forms.Button();
		decryptButton = new System.Windows.Forms.Button();
		plainTextLabel = new System.Windows.Forms.Label();
		plainTextTextBox = new System.Windows.Forms.TextBox();
		encryptedTextTextBox = new System.Windows.Forms.TextBox();
		encryptedTextLabel = new System.Windows.Forms.Label();
		SuspendLayout();
		// 
		// passwordLabel
		// 
		passwordLabel.AutoSize = true;
		passwordLabel.Location = new System.Drawing.Point(13, 15);
		passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		passwordLabel.Name = "passwordLabel";
		passwordLabel.Size = new System.Drawing.Size(89, 20);
		passwordLabel.TabIndex = 0;
		passwordLabel.Text = "&Password";
		// 
		// passwordTextBox
		// 
		passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		passwordTextBox.Location = new System.Drawing.Point(110, 12);
		passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		passwordTextBox.Name = "passwordTextBox";
		passwordTextBox.Size = new System.Drawing.Size(502, 27);
		passwordTextBox.TabIndex = 1;
		passwordTextBox.UseSystemPasswordChar = true;
		// 
		// encryptButton
		// 
		encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		encryptButton.Location = new System.Drawing.Point(13, 45);
		encryptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		encryptButton.Name = "encryptButton";
		encryptButton.Size = new System.Drawing.Size(599, 29);
		encryptButton.TabIndex = 2;
		encryptButton.Text = "&Encrypt";
		encryptButton.UseVisualStyleBackColor = true;
		encryptButton.Click += EncryptButton_Click;
		// 
		// decryptButton
		// 
		decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		decryptButton.Location = new System.Drawing.Point(13, 80);
		decryptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		decryptButton.Name = "decryptButton";
		decryptButton.Size = new System.Drawing.Size(599, 29);
		decryptButton.TabIndex = 3;
		decryptButton.Text = "&Decrypt";
		decryptButton.UseVisualStyleBackColor = true;
		decryptButton.Click += DecryptButton_Click;
		// 
		// plainTextLabel
		// 
		plainTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plainTextLabel.Location = new System.Drawing.Point(13, 112);
		plainTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		plainTextLabel.Name = "plainTextLabel";
		plainTextLabel.Size = new System.Drawing.Size(599, 25);
		plainTextLabel.TabIndex = 4;
		plainTextLabel.Text = "Plain Text";
		plainTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// plainTextTextBox
		// 
		plainTextTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plainTextTextBox.Location = new System.Drawing.Point(13, 140);
		plainTextTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		plainTextTextBox.Multiline = true;
		plainTextTextBox.Name = "plainTextTextBox";
		plainTextTextBox.Size = new System.Drawing.Size(599, 189);
		plainTextTextBox.TabIndex = 5;
		plainTextTextBox.Text = "Hello, World! - This is test message!";
		// 
		// encryptedTextTextBox
		// 
		encryptedTextTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		encryptedTextTextBox.Location = new System.Drawing.Point(13, 360);
		encryptedTextTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		encryptedTextTextBox.Multiline = true;
		encryptedTextTextBox.Name = "encryptedTextTextBox";
		encryptedTextTextBox.Size = new System.Drawing.Size(599, 219);
		encryptedTextTextBox.TabIndex = 7;
		// 
		// encryptedTextLabel
		// 
		encryptedTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		encryptedTextLabel.Location = new System.Drawing.Point(13, 332);
		encryptedTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		encryptedTextLabel.Name = "encryptedTextLabel";
		encryptedTextLabel.Size = new System.Drawing.Size(599, 25);
		encryptedTextLabel.TabIndex = 6;
		encryptedTextLabel.Text = "Encrypted Text";
		encryptedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(625, 591);
		Controls.Add(encryptedTextTextBox);
		Controls.Add(encryptedTextLabel);
		Controls.Add(plainTextTextBox);
		Controls.Add(plainTextLabel);
		Controls.Add(decryptButton);
		Controls.Add(encryptButton);
		Controls.Add(passwordTextBox);
		Controls.Add(passwordLabel);
		Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		Name = "MainForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "DT Secure Messages - Version 1.1";
		Load += MainForm_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Label passwordLabel;
	private System.Windows.Forms.TextBox passwordTextBox;
	private System.Windows.Forms.Button encryptButton;
	private System.Windows.Forms.Button decryptButton;
	private System.Windows.Forms.Label plainTextLabel;
	private System.Windows.Forms.TextBox plainTextTextBox;
	private System.Windows.Forms.TextBox encryptedTextTextBox;
	private System.Windows.Forms.Label encryptedTextLabel;
}
