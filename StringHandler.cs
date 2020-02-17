using System;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	internal class StringHandler
	{
		private readonly RichTextBox rtb_Main;
		public string TextBox { get; set; }

		public StringHandler(RichTextBox rtb_Main)
		{
			this.rtb_Main = rtb_Main;
		}

		internal void UpdateText()
		{
			TextBox = rtb_Main.Text;
		}
	}
}