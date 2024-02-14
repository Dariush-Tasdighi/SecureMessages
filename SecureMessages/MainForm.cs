namespace SecureMessages;

public partial class MainForm : System.Windows.Forms.Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	public int KeySize { get; set; }
	public string Path { get; set; } = "";

	private void MainForm_Load(object sender, System.EventArgs e)
	{
		KeySize = 4096;
		Path = @"C:\Keys";
	}

	private void EncryptButton_Click
		(object sender, System.EventArgs e)
	{
		var plainText =
			plainTextTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: plainText))
		{
			// TODO: Display Message!

			return;
		}

		var publicKeyPemPathName =
			$"{Path}\\PublicKey.pem";

		if (System.IO.File.Exists
			(path: publicKeyPemPathName) == false)
		{
			// TODO: Display Message!

			return;
		}

		var publicKeyPem = System.IO.File
			.ReadAllText(path: publicKeyPemPathName);

		encryptedTextTextBox.Text = Dtat.RsaHelper.Encrypt
			(plainText: plainText, publicKeyPem: publicKeyPem);
	}

	private void DecryptButton_Click
		(object sender, System.EventArgs e)
	{
		var encryptedBase64String =
			encryptedTextTextBox.Text;

		if (string.IsNullOrWhiteSpace
			(value: encryptedBase64String))
		{
			// TODO: Display Message!

			return;
		}

		var privateKeyPathName =
			$"{Path}\\PrivateKey.pem";

		if (System.IO.File.Exists
			(path: privateKeyPathName) == false)
		{
			// TODO: Display Message!

			return;
		}

		var privateKeyPem =
			System.IO.File.ReadAllText(path: privateKeyPathName);

		using var rsa = new System.Security
			.Cryptography.RSACryptoServiceProvider(dwKeySize: KeySize);

		plainTextTextBox.Text = Dtat.RsaHelper.Decrypt
			(encryptedBase64String: encryptedBase64String, privateKeyPem: privateKeyPem);
	}
}
