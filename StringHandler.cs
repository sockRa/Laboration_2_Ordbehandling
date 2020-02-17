using System;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public class StringHandler
	{
		private readonly RichTextBox rtb_Main;

		public string TextBox { get; set; }
		public bool TextHaveBeenModified { get; private set; }

		public StringHandler(RichTextBox rtb_Main)
		{
			this.rtb_Main = rtb_Main;
		}

		public void UpdateText()
		{
			TextBox = rtb_Main.Text;
		}

		public void NewTextFile()
		{
			rtb_Main.Text = "";
			FileHaveBeenModified = false;
		}
	}
}