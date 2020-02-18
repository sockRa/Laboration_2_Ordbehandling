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
		private readonly CurrentDocumentHandler CDHandler;

		public bool FileHaveBeenModified { get; set; }
		private bool NewDocument { get; set; }

		public Main_Form()
		{
			InitializeComponent();
			CDHandler = new CurrentDocumentHandler(Rtb_Main, this);

			FileHaveBeenModified = false;
			NewDocument = false;

			//Set focus on textbox at startup
			ActiveControl = Rtb_Main;
		}

		private void Rtb_Main_TextChanged(object sender, EventArgs e)
		{
			// Add asterix to the filename if the file have been modified and it is not a new document
			if (!NewDocument && !FileHaveBeenModified)
			{
				CDHandler.MarkDocumentAsModified();
				FileHaveBeenModified = true;
			}
		}

		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			// If the text have been modified, we need to save it.
			if (FileHaveBeenModified)
			{
				if (DisplaySaveFileDialog() == DialogResult.Yes)
				{
					CDHandler.SaveChanges();
				}
				else if (DisplaySaveFileDialog() == DialogResult.Cancel)
				{
					//User press cancel so don't close the window.
					e.Cancel = true;
				}
			}
		}

		private DialogResult DisplaySaveFileDialog()
		{
			//Display promt which asks the user for an action to take
			return MessageBox.Show("Vill du spara ändringarna för " + CDHandler.GetTitle() + "?", "NotPad", MessageBoxButtons.YesNoCancel);
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//SaveFileIfModified();
		}

		private void SaveFileIfModified()
		{
			if (FileHaveBeenModified)
			{
				if (DisplaySaveFileDialog() == DialogResult.Yes)
				{
					//Save changes before it is overwritten
					CDHandler.SaveChanges();
				}

				CDHandler.NewTextFile();
				CDHandler.SetDefaultWindowTitle();
				FileHaveBeenModified = false;
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewDocument = true;
			//If text have been modified, give the user a chance to save it's work
			SaveFileIfModified();
			CDHandler.OpenTextFile();
			NewDocument = false;
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CDHandler.SaveChanges();
		}
	}
}