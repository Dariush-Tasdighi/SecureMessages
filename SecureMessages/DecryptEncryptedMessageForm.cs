namespace SecureMessages;

public partial class DecryptEncryptedMessageForm : Dtat.BaseForm
{
	public DecryptEncryptedMessageForm()
	{
		InitializeComponent();
	}

	private void DecryptEncryptedMessageForm_Load(object sender, System.EventArgs e)
	{
	}

	private void selectPrivateKeyButton_Click(object sender, System.EventArgs e)
	{
		var openFileDialog =
			Dtat.OpenFileDialogHelper.Instance;

		openFileDialog.DefaultExt = "*.*"; // Default: []
		openFileDialog.Title = "Select Private Key Pem File";// Default: [];
		openFileDialog.Filter = "Private Key Pem files (*.*)|*.*"; // Default: []

		var result =
			openFileDialog.ShowDialog();

		if (result == System.Windows.Forms.DialogResult.OK)
		{
			privateKeyPemPathNameTextBox.Text = openFileDialog.FileName;

			privateKeyPemTextBox.Text = System.IO.File
				.ReadAllText(path: privateKeyPemPathNameTextBox.Text);
		}
	}

	private void DecryptButton_Click(object sender, System.EventArgs e)
	{
		var encryptedMessage =
			encryptedMessageTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: encryptedMessage))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "You did not specify any message for decryption!");

			return;
		}

		var privateKeyPem = privateKeyPemTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: privateKeyPem))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "You did not select any private key pem file!");

			return;
		}

		plainMessageTextBox.Text = Dtat.RsaHelper.Decrypt
			(encryptedBase64String: encryptedMessage, privateKeyPem: privateKeyPem);
	}

	private void CopyToClipboardButton_Click(object sender, System.EventArgs e)
	{
		var plainMessage =
			plainMessageTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: plainMessage))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "There is not any plain message for copying!");

			return;
		}

		System.Windows.Forms.Clipboard.SetText(text: plainMessage);

		System.Windows.Forms.MessageBox.Show
			(text: "Plain message copies in clipboard...");
	}
}
