namespace SecureMessages
{
	partial class AboutForm
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
			aboutLabel = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// aboutLabel
			// 
			aboutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			aboutLabel.Location = new System.Drawing.Point(0, 0);
			aboutLabel.Name = "aboutLabel";
			aboutLabel.Padding = new System.Windows.Forms.Padding(5);
			aboutLabel.Size = new System.Drawing.Size(363, 204);
			aboutLabel.TabIndex = 0;
			aboutLabel.Text = "This program has been developed by Mr. Dariush Tasdighi\r\n\r\nPlease follow us in Telegram channel:\r\n\r\n@IranianExperts";
			// 
			// AboutForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(363, 204);
			Controls.Add(aboutLabel);
			Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			Name = "AboutForm";
			Text = "About";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Label aboutLabel;
	}
}