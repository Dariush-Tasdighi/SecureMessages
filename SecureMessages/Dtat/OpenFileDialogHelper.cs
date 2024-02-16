namespace Dtat;

public static class OpenFileDialogHelper : object
{
	static OpenFileDialogHelper()
	{
		_openFileDialog = new();
	}

	private static System.Windows.Forms.OpenFileDialog _openFileDialog;

	public static System.Windows.Forms.OpenFileDialog Instance
	{
		get
		{
			_openFileDialog.ShowHelp = false;  // Default: []
			_openFileDialog.ShowPreview = true; // Default: []
			_openFileDialog.AddToRecent = true; // Default: []
			_openFileDialog.AddExtension = true; // Default: []
			_openFileDialog.Multiselect = false; // Default: []
			_openFileDialog.ShowReadOnly = true; // Default: []
			_openFileDialog.ValidateNames = true;// Default: []
			_openFileDialog.ReadOnlyChecked = false;// Default: []
			_openFileDialog.CheckFileExists = true; // Default: []
			_openFileDialog.CheckPathExists = true; // Default: []
			_openFileDialog.ShowHiddenFiles = true; // Default: []
			_openFileDialog.DereferenceLinks = true; // Default: []
			_openFileDialog.RestoreDirectory = true; // Default: []
			_openFileDialog.ShowPinnedPlaces = false; // Default: []
			_openFileDialog.AutoUpgradeEnabled = true; // Default: []
			_openFileDialog.OkRequiresInteraction = true;// Default: []
			_openFileDialog.SupportMultiDottedExtensions = true;// Default: []

			var applicationLocation =
				System.AppDomain.CurrentDomain.BaseDirectory;

			_openFileDialog.InitialDirectory = applicationLocation; // Default: []

			return _openFileDialog;
		}
	}
}
