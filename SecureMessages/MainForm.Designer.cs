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
		myMenuStrip = new System.Windows.Forms.MenuStrip();
		optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		yourKeysManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		myMenuStrip.SuspendLayout();
		SuspendLayout();
		// 
		// myMenuStrip
		// 
		myMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
		myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem, utilityToolStripMenuItem });
		myMenuStrip.Location = new System.Drawing.Point(0, 0);
		myMenuStrip.Name = "myMenuStrip";
		myMenuStrip.Size = new System.Drawing.Size(837, 28);
		myMenuStrip.TabIndex = 8;
		myMenuStrip.Text = "menuStrip1";
		// 
		// optionsToolStripMenuItem
		// 
		optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem, exitToolStripMenuItem });
		optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
		optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
		optionsToolStripMenuItem.Text = "&Options";
		// 
		// aboutToolStripMenuItem
		// 
		aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
		aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
		aboutToolStripMenuItem.Text = "&About";
		aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
		// 
		// exitToolStripMenuItem
		// 
		exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
		exitToolStripMenuItem.Text = "E&xit";
		exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
		// 
		// utilityToolStripMenuItem
		// 
		utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encryptToolStripMenuItem, decryptToolStripMenuItem, yourKeysManagerToolStripMenuItem });
		utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
		utilityToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
		utilityToolStripMenuItem.Text = "&Utility";
		// 
		// encryptToolStripMenuItem
		// 
		encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
		encryptToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
		encryptToolStripMenuItem.Text = "&Encrypt";
		encryptToolStripMenuItem.Click += EncryptToolStripMenuItem_Click;
		// 
		// decryptToolStripMenuItem
		// 
		decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
		decryptToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
		decryptToolStripMenuItem.Text = "&Decrypt";
		decryptToolStripMenuItem.Click += DecryptToolStripMenuItem_Click;
		// 
		// yourKeysManagerToolStripMenuItem
		// 
		yourKeysManagerToolStripMenuItem.Name = "yourKeysManagerToolStripMenuItem";
		yourKeysManagerToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
		yourKeysManagerToolStripMenuItem.Text = "Your Keys Manager";
		yourKeysManagerToolStripMenuItem.Click += YourKeysManagerToolStripMenuItem_Click;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackgroundImage = Properties.Resources.Wallpaper_001;
		BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		ClientSize = new System.Drawing.Size(837, 525);
		Controls.Add(myMenuStrip);
		Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		IsMdiContainer = true;
		MainMenuStrip = myMenuStrip;
		Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		Name = "MainForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "DT Secure Messages - Version 1.2.2";
		WindowState = System.Windows.Forms.FormWindowState.Maximized;
		Load += MainForm_Load;
		myMenuStrip.ResumeLayout(false);
		myMenuStrip.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
	private System.Windows.Forms.MenuStrip myMenuStrip;
	private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem yourKeysManagerToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
}
