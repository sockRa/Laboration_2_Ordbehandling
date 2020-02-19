using System.IO;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	internal class CurrentDocumentHandler
	{
		private readonly RichTextBox rtb_Main;
		private readonly Main_Form main_Form;
		private readonly OpenFileDialog openDialog;
		private readonly SaveFileDialog saveDialog;
		private readonly string DialogFilter;

		private readonly string StandardFileName = "dok1.txt - NotPad";
		public string CurrentFilePath { get; set; }
		public string CurrentFileName { get; set; }

		public CurrentDocumentHandler(RichTextBox rtb_Main, Main_Form main_Form)
		{
			this.rtb_Main = rtb_Main;
			this.main_Form = main_Form;

			openDialog = new OpenFileDialog();
			saveDialog = new SaveFileDialog();

			DialogFilter = "Text Files (*.txt)|*.txt";
			CurrentFilePath = "";
			CurrentFileName = "dok1.txt";

			openDialog.Filter = DialogFilter;
			saveDialog.Filter = DialogFilter;
		}

		internal void SetDefaultDocumentName()
		{
			main_Form.Text = StandardFileName;
		}

		private void SetDocumentTitle(string title)
		{
			main_Form.Text = title + " - NotPad";
		}

		public void CreateNewDocument()
		{
			rtb_Main.Text = "";
			main_Form.FileHaveBeenModified = false;
		}

		internal void SaveWithPromt()
		{
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveDialog.FileName, rtb_Main.Text);
				CurrentFileName = Path.GetFileName(saveDialog.FileName);
				CurrentFilePath = saveDialog.FileName;
			}

			SetDocumentTitle(CurrentFileName);
		}

		public void SaveWithoutPromt()
		{
			File.WriteAllText(CurrentFilePath, rtb_Main.Text);
		}

		internal void SaveDocument()
		{
			if (FileExists())
			{
				SaveWithoutPromt();
			}
			else
			{
				SaveWithPromt();
			}
			SetDocumentTitle(CurrentFileName);
			main_Form.FileHaveBeenModified = false;
		}

		internal void OpenTextFile()
		{
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				//Read the text from the file and add it to the textbox
				rtb_Main.Text = File.ReadAllText(openDialog.FileName);
				//Set the appropiate window title based on the file name
				SetDocumentTitle(openDialog.SafeFileName);
				CurrentFileName = openDialog.SafeFileName;
				//Save the current filepath
				CurrentFilePath = openDialog.FileName;
			}

			main_Form.NewDocument = false;
		}

		public bool FileExists()
		{
			return CurrentFilePath != "";
		}
	}
}