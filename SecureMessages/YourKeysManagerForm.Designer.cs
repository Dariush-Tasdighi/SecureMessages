namespace SecureMessages
{
	partial class YourKeysManagerForm
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
			keyNameLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			keysListBox = new System.Windows.Forms.ListBox();
			createButton = new System.Windows.Forms.Button();
			passwordTextBox = new System.Windows.Forms.TextBox();
			deleteButton = new System.Windows.Forms.Button();
			keyNameTextBox = new System.Windows.Forms.TextBox();
			mainSplitter = new System.Windows.Forms.Splitter();
			displayPanel = new System.Windows.Forms.Panel();
			contentTextBox = new System.Windows.Forms.TextBox();
			mainPanel.SuspendLayout();
			displayPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainPanel
			// 
			mainPanel.Controls.Add(keyNameLabel);
			mainPanel.Controls.Add(passwordLabel);
			mainPanel.Controls.Add(keysListBox);
			mainPanel.Controls.Add(createButton);
			mainPanel.Controls.Add(passwordTextBox);
			mainPanel.Controls.Add(deleteButton);
			mainPanel.Controls.Add(keyNameTextBox);
			mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
			mainPanel.Location = new System.Drawing.Point(0, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new System.Drawing.Size(401, 508);
			mainPanel.TabIndex = 1;
			// 
			// keyNameLabel
			// 
			keyNameLabel.AutoSize = true;
			keyNameLabel.Location = new System.Drawing.Point(13, 15);
			keyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			keyNameLabel.Name = "keyNameLabel";
			keyNameLabel.Size = new System.Drawing.Size(106, 23);
			keyNameLabel.TabIndex = 0;
			keyNameLabel.Text = "&Key Name";
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new System.Drawing.Point(13, 51);
			passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(106, 23);
			passwordLabel.TabIndex = 2;
			passwordLabel.Text = "&Password";
			// 
			// keysListBox
			// 
			keysListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			keysListBox.FormattingEnabled = true;
			keysListBox.ItemHeight = 23;
			keysListBox.Location = new System.Drawing.Point(127, 123);
			keysListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			keysListBox.Name = "keysListBox";
			keysListBox.Size = new System.Drawing.Size(267, 326);
			keysListBox.TabIndex = 5;
			keysListBox.SelectedIndexChanged += KeysListBox_SelectedIndexChanged;
			// 
			// createButton
			// 
			createButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			createButton.Location = new System.Drawing.Point(127, 84);
			createButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			createButton.Name = "createButton";
			createButton.Size = new System.Drawing.Size(267, 33);
			createButton.TabIndex = 4;
			createButton.Text = "&Create";
			createButton.UseVisualStyleBackColor = true;
			createButton.Click += CreateButton_Click;
			// 
			// passwordTextBox
			// 
			passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			passwordTextBox.Enabled = false;
			passwordTextBox.Location = new System.Drawing.Point(127, 48);
			passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new System.Drawing.Size(267, 30);
			passwordTextBox.TabIndex = 3;
			// 
			// deleteButton
			// 
			deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			deleteButton.Enabled = false;
			deleteButton.Location = new System.Drawing.Point(127, 463);
			deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new System.Drawing.Size(267, 33);
			deleteButton.TabIndex = 6;
			deleteButton.Text = "&Delete";
			deleteButton.UseVisualStyleBackColor = true;
			// 
			// keyNameTextBox
			// 
			keyNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			keyNameTextBox.Location = new System.Drawing.Point(127, 12);
			keyNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			keyNameTextBox.Name = "keyNameTextBox";
			keyNameTextBox.Size = new System.Drawing.Size(267, 30);
			keyNameTextBox.TabIndex = 1;
			// 
			// mainSplitter
			// 
			mainSplitter.Location = new System.Drawing.Point(401, 0);
			mainSplitter.Name = "mainSplitter";
			mainSplitter.Size = new System.Drawing.Size(4, 508);
			mainSplitter.TabIndex = 9;
			mainSplitter.TabStop = false;
			// 
			// displayPanel
			// 
			displayPanel.Controls.Add(contentTextBox);
			displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			displayPanel.Location = new System.Drawing.Point(405, 0);
			displayPanel.Name = "displayPanel";
			displayPanel.Size = new System.Drawing.Size(534, 508);
			displayPanel.TabIndex = 10;
			// 
			// contentTextBox
			// 
			contentTextBox.BackColor = System.Drawing.Color.DimGray;
			contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			contentTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			contentTextBox.ForeColor = System.Drawing.Color.White;
			contentTextBox.Location = new System.Drawing.Point(0, 0);
			contentTextBox.Multiline = true;
			contentTextBox.Name = "contentTextBox";
			contentTextBox.ReadOnly = true;
			contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			contentTextBox.Size = new System.Drawing.Size(534, 508);
			contentTextBox.TabIndex = 0;
			// 
			// YourKeysManagerForm
			// 
			AcceptButton = createButton;
			AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(939, 508);
			Controls.Add(displayPanel);
			Controls.Add(mainSplitter);
			Controls.Add(mainPanel);
			Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			Name = "YourKeysManagerForm";
			Text = "Your Keys Manager";
			Load += CreatePairKeysForMyselfForm_Load;
			mainPanel.ResumeLayout(false);
			mainPanel.PerformLayout();
			displayPanel.ResumeLayout(false);
			displayPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.ListBox keysListBox;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox keyNameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label keyNameLabel;
		private System.Windows.Forms.Splitter mainSplitter;
		private System.Windows.Forms.Panel displayPanel;
		private System.Windows.Forms.TextBox contentTextBox;
	}
}