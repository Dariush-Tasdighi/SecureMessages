namespace Dtat;

partial class BaseForm
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		SuspendLayout();
		// 
		// BaseForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(403, 360);
		Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		Name = "BaseForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		ResumeLayout(false);
	}

	#endregion
}
