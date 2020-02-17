using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public partial class Main_Form : Form
	{
		//Handels all the generic form operations
		private readonly WindowHandler wHandler;

		//Handels all operations that involves string manipulation,counting,etc.
		private readonly StringHandler sHandler;

		//Handels operations that write/read from the system
		private readonly OSHandler osHandler;

		private bool TextHaveBeenModified = false;

		public Main_Form()
		{
			InitializeComponent();
			wHandler = new WindowHandler(this);
			sHandler = new StringHandler(Rtb_Main);
			osHandler = new OSHandler(saveFileDialog1);

			//Set focus on textbox at startup
			ActiveControl = Rtb_Main;
		}

		private void Rtb_Main_TextChanged(object sender, EventArgs e)
		{
			// Update the text in the textbox
			sHandler.UpdateText();
			// Add asterix to the filename if the file have been modified.
			if (!TextHaveBeenModified)
			{
				wHandler.AppendAsterix();
				TextHaveBeenModified = true;
			}
		}

		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			// If the text have been modified, we need to save it.
			if (TextHaveBeenModified)
			{
				//Display promt which asks the user for an action to take
				MessageBox.Show("Vill du spara ändringarna för " + wHandler.GetTitle() + "?", "NotPad", MessageBoxButtons.YesNoCancel);
			}
		}
	}
}