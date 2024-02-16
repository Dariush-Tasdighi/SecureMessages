namespace SecureMessages;

public partial class MainForm : System.Windows.Forms.Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, System.EventArgs e)
	{
	}

	private void EncryptToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		var form =
			new EncryptMessageForm
			{
				MdiParent = this,
			};

		form.Show();
	}

	private void DecryptToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		var form =
			new DecryptEncryptedMessageForm
			{
				MdiParent = this,
			};

		form.Show();
	}

	private void CreatePairKeysForMyselfToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		var form =
			new CreatePairKeysForMyselfForm
			{
				MdiParent = this,
			};

		form.Show();
	}

	private void AboutToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		//var form =
		//	new AboutForm
		//	{
		//		MdiParent = this,
		//	};

		//form.Show();
	}

	private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		System.Windows.Forms.Application.Exit();
	}
}
