namespace SecureMessages;

internal static class Program
{
	[System.STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
        System.Windows.Forms.Application.Run(new MainForm());
	}
}
