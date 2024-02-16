namespace SecureMessages;

public partial class EncryptMessageForm : Dtat.BaseForm
{
	public EncryptMessageForm()
	{
		InitializeComponent();
	}

	private void EncryptMessageForm_Load(object sender, System.EventArgs e)
	{
	}

	private void SelectPublicKeyButton_Click(object sender, System.EventArgs e)
	{
		var openFileDialog =
			Dtat.OpenFileDialogHelper.Instance;

		openFileDialog.DefaultExt = ".pub"; // Default: []
		openFileDialog.Title = "Select Public Key Pem File";// Default: [];
		openFileDialog.Filter = "Public Key Pem files (*.pub)|*.*"; // Default: []

		var result =
			openFileDialog.ShowDialog();

		if (result == System.Windows.Forms.DialogResult.OK)
		{
			publicKeyPemPathNameTextBox.Text = openFileDialog.FileName;

			publicKeyPemTextBox.Text = System.IO.File
				.ReadAllText(path: publicKeyPemPathNameTextBox.Text);
		}
	}

	private void EncryptButton_Click(object sender, System.EventArgs e)
	{
		var plainMessage =
			plainMessageTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: plainMessage))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "You did not specify any message for encryption!");

			return;
		}

		var publicKeyPem = publicKeyPemTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: publicKeyPem))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "You did not select any public key pem file!");

			return;
		}

		encryptedMessageTextBox.Text = Dtat.RsaHelper.Encrypt
			(plainText: plainMessage, publicKeyPem: publicKeyPem);
	}

	private void CopyToClipboardButton_Click(object sender, System.EventArgs e)
	{
		var encryptedMessage =
			encryptedMessageTextBox.Text;

		if(string.IsNullOrWhiteSpace(value: encryptedMessage))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "There is not any encrypted message for copying!");

			return;
		}

		System.Windows.Forms.Clipboard.SetText(text: encryptedMessage);

		System.Windows.Forms.MessageBox.Show
			(text: "Encrypted message copies in clipboard...");
	}
}
