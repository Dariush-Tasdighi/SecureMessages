namespace SecureMessages;

internal static class Program : object
{
	static Program()
	{
	}

	[System.STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();
		System.Windows.Forms.Application.Run(new MainForm());
	}
}
