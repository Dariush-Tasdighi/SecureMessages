using System.Linq;

namespace SecureMessages;

public partial class CreatePairKeysForMyselfForm : Dtat.BaseForm
{
	public CreatePairKeysForMyselfForm()
	{
		InitializeComponent();
	}

	public string Path { get; set; } = "";

	private void CreatePairKeysForMyselfForm_Load(object sender, System.EventArgs e)
	{
		Path = "Keys";

		if (System.IO.Directory.Exists(path: Path) == false)
		{
			System.IO.Directory.CreateDirectory(path: Path);
		}

		FillListBox();
	}

	private System.Collections.Generic.IList<string> GetKeyNames(string path)
	{
		var directoryInfo =
			new System.IO.DirectoryInfo(path: path);

		var files =
			directoryInfo.GetFiles()
			.OrderBy(current => current.Name)
			.Select(current => current.Name)
			.ToList()
			;

		return files;
	}

	private void FillListBox()
	{
		var keys =
			GetKeyNames(path: Path);

		keysListBox.Items.Clear();

		foreach (var key in keys)
		{
			keysListBox.Items.Add(item: key);
		}
	}

	private void CreateButton_Click(object sender, System.EventArgs e)
	{
		var keyName =
			keyNameTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: keyName))
		{
			System.Windows.Forms.MessageBox.Show
				(text: "You did not specify key name!");

			return;
		}

		keyName =
			keyName.ToUpper().Replace
			(oldValue: " ", newValue: string.Empty);

		var keyNames =
			GetKeyNames(path: Path);

		// **************************************************
		var founded =
			keyNames
			.Where(current => string.Compare
				(current, keyName, true) == 0)
			.Any();

		if (founded)
		{
			System.Windows.Forms.MessageBox.Show
				(text: "Key name is already exist!");

			return;
		}
		// **************************************************

		// **************************************************
		founded =
			keyNames
			.Where(current => string.Compare
				(current, keyName + ".pub", true) == 0)
			.Any();

		if (founded)
		{
			System.Windows.Forms.MessageBox.Show
				(text: "Key name is already exist!");

			return;
		}
		// **************************************************

		var rsaPemKeys =
			Dtat.RsaHelper.GenerateRsaPemKeys();

		// **************************************************
		var publicKeyPemPathName =
			$"{Path}\\{keyName}.pub";

		System.IO.File.WriteAllText
			(path: publicKeyPemPathName, contents: rsaPemKeys.PublicKeyPem);
		// **************************************************

		// **************************************************
		var privateKeyPemPathName =
			$"{Path}\\{keyName}";

		System.IO.File.WriteAllText
			(path: privateKeyPemPathName, contents: rsaPemKeys.PrivateKeyPem);
		// **************************************************

		FillListBox();
	}

	private void KeysListBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		var keysListBoxSelectedIndex = keysListBox.SelectedIndex;

		if (keysListBoxSelectedIndex < 0)
		{
			contentTextBox.Text = string.Empty;
		}
		else
		{
			var fileName =
				keysListBox.Items[keysListBoxSelectedIndex].ToString();

			var pathName =
				$"{Path}\\{fileName}";

			contentTextBox.Text =
				System.IO.File.ReadAllText(path: pathName);
		}
	}
}
