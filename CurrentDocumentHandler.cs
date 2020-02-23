using Laboration_2_Ordbehandling.Forms;
using System.IO;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public class CurrentDocumentHandler
	{
		private readonly MainForm _mainForm;
		private readonly OpenFileDialog _openDialog;
		private readonly RichTextBox _rtbMain;
		private readonly SaveFileDialog _saveDialog;
		private const string StandardFileName = "dok1.txt - NotPad";

		public CurrentDocumentHandler(RichTextBox rtbMain, MainForm mainForm)
		{
			_rtbMain = rtbMain;
			_mainForm = mainForm;

			_openDialog = new OpenFileDialog();
			_saveDialog = new SaveFileDialog();

			const string dialogFilter = "Text Files (*.txt)|*.txt";
			CurrentFilePath = "";
			CurrentFileName = "dok1.txt";

			_openDialog.Filter = dialogFilter;
			_saveDialog.Filter = dialogFilter;
		}

		public string CurrentFileName { get; private set; }
		public string CurrentFilePath { get; set; }

		public void CreateNewDocument()
		{
			_rtbMain.Text = "";
			_mainForm.FileHaveBeenModified = false;
		}

		private bool FileExists()
		{
			return CurrentFilePath != "";
		}

		private void SaveWithoutPrompt()
		{
			File.WriteAllText(CurrentFilePath, _rtbMain.Text);
		}

		public void SetDocumentTitle(string title)
		{
			_mainForm.Text = title + " - NotPad";
		}

		internal void OpenTextFile()
		{
			if (_openDialog.ShowDialog() == DialogResult.OK)
			{
				//Read the text from the file and add it to the text box
				_rtbMain.Text = File.ReadAllText(_openDialog.FileName);
				//Set the appropriate window title based on the file name
				SetDocumentTitle(_openDialog.SafeFileName);
				CurrentFileName = _openDialog.SafeFileName;
				//Save the current filepath
				CurrentFilePath = _openDialog.FileName;
			}

			_mainForm.NewDocument = false;
		}

		internal static string ReadFileContent(string path)
		{
			return File.ReadAllText(path);
		}

		internal void SaveDocument()
		{
			if (FileExists())
			{
				SaveWithoutPrompt();
			}
			else
			{
				SaveWithPrompt();
			}
			SetDocumentTitle(CurrentFileName);
			_mainForm.FileHaveBeenModified = false;
		}

		internal void SaveWithPrompt()
		{
			if (_saveDialog.ShowDialog() != DialogResult.OK) return;

			File.WriteAllText(_saveDialog.FileName, _rtbMain.Text);
			CurrentFileName = Path.GetFileName(_saveDialog.FileName);
			CurrentFilePath = _saveDialog.FileName;
		}

		internal void SetDefaultDocumentName()
		{
			_mainForm.Text = StandardFileName;
		}
	}
}