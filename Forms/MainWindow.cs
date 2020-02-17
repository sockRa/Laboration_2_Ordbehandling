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
		//Handels all mainform logic
		private readonly WindowHandler wHandler;

		//Handels operations that involves string manipulation from the textbox.
		private readonly StringHandler sHandler;

		//Handels operations that write/read from the system
		private readonly OSHandler osHandler;

		public bool FileHaveBeenModified { get; set; }

		public Main_Form()
		{
			InitializeComponent();
			wHandler = new WindowHandler(this);
			sHandler = new StringHandler(Rtb_Main, this);
			osHandler = new OSHandler();

			FileHaveBeenModified = false;

			//Set focus on textbox at startup
			ActiveControl = Rtb_Main;
		}

		private void Rtb_Main_TextChanged(object sender, EventArgs e)
		{
			// Update the text in the textbox
			sHandler.UpdateText();
			// Add asterix to the filename if the file have been modified.
			if (!FileHaveBeenModified)
			{
				wHandler.AppendAsterix();
				FileHaveBeenModified = true;
			}
		}

		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			// If the text have been modified, we need to save it.
			if (FileHaveBeenModified)
			{
				if (SaveDialog() == DialogResult.Yes)
				{
					osHandler.SaveChanges();
				}
				else if (SaveDialog() == DialogResult.Cancel)
				{
					//User press cancel so don't close the window.
					e.Cancel = true;
				}
			}
		}

		private DialogResult SaveDialog()
		{
			//Display promt which asks the user for an action to take
			return MessageBox.Show("Vill du spara ändringarna för " + wHandler.GetTitle() + "?", "NotPad", MessageBoxButtons.YesNoCancel);
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowSaveDialogIfModified();
		}

		private void ShowSaveDialogIfModified()
		{
			if (FileHaveBeenModified)
			{
				if (SaveDialog() == DialogResult.Yes)
				{
					//Save changes before it is overwritten
					osHandler.SaveChanges();
				}

				sHandler.NewTextFile();
				wHandler.SetDefaultWindowTitle();
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//If text have been modified, give the user a chance to save it's work
			ShowSaveDialogIfModified();
			osHandler.OpenTextFile();
		}
	}
}