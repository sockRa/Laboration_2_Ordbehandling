using System;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public class StringHandler
	{
		private readonly RichTextBox rtb_Main;
		private readonly Main_Form main_Form;

		public string TextBox { get; set; }

		public StringHandler(RichTextBox rtb_Main, Main_Form main_Form)
		{
			this.rtb_Main = rtb_Main;
			this.main_Form = main_Form;
		}

		public void UpdateText()
		{
			TextBox = rtb_Main.Text;
		}

		public void NewTextFile()
		{
			rtb_Main.Text = "";
			main_Form.FileHaveBeenModified = false;
		}
	}
}