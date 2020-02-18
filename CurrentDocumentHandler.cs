using System;
using System.IO;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	internal class CurrentDocumentHandler
	{
		private RichTextBox rtb_Main;
		private Main_Form main_Form;
		private OpenFileDialog openDialog;
		private SaveFileDialog saveDialog;
		private string DialogFilter;

		private string StandardFileName = "dok1.txt - NotPad";
		private string CurrentFilePath { get; set; }

		public CurrentDocumentHandler(RichTextBox rtb_Main, Main_Form main_Form)
		{
			this.rtb_Main = rtb_Main;
			this.main_Form = main_Form;

			openDialog = new OpenFileDialog();
			saveDialog = new SaveFileDialog();

			DialogFilter = "Text Files (*.txt)|*.txt";
			CurrentFilePath = "";

			openDialog.Filter = DialogFilter;
			saveDialog.Filter = DialogFilter;
		}

		public void MarkDocumentAsModified()
		{
			main_Form.Text = "*" + main_Form.Text;
		}

		internal string GetTitle()
		{
			try
			{
				return main_Form.Text.Split(' ')[0].Split('.')[0].Split('*')[1];
			}
			catch
			{
				return main_Form.Text.Split(' ')[0].Split('.')[0];
			}
		}

		internal void SetDefaultWindowTitle()
		{
			main_Form.Text = StandardFileName;
		}

		private void SetDocumentTitle(string title)
		{
			main_Form.Text = title + " - NotPad";
		}

		public void NewTextFile()
		{
			rtb_Main.Text = "";
			main_Form.FileHaveBeenModified = false;
		}

		internal void SaveChanges()
		{
			if (CurrentFilePath != "")
			{
				File.WriteAllText(CurrentFilePath, rtb_Main.Text);
			}
			else if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveDialog.FileName, rtb_Main.Text);
				CurrentFilePath = "";
			}
		}

		internal void OpenTextFile()
		{
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				//Read the text from the file and add it to the textbox
				rtb_Main.Text = File.ReadAllText(openDialog.FileName);
				//Set the appropiate window title based on the file name
				SetDocumentTitle(openDialog.SafeFileName);
				//Save the current filepath
				CurrentFilePath = openDialog.FileName;
			}
		}
	}
}