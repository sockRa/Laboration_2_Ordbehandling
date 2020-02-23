using System;
using System.IO;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling.Forms
{
	public partial class MainForm : Form
	{
		private readonly CurrentDocumentHandler _cdHandler;

		public MainForm()
		{
			InitializeComponent();
			_cdHandler = new CurrentDocumentHandler(Rtb_Main, this);

			FileHaveBeenModified = false;
			NewDocument = false;

			//Set focus on text box at startup
			ActiveControl = Rtb_Main;

			//Allow drag and drop into textbox
			Rtb_Main.AllowDrop = true;
		}

		public bool FileHaveBeenModified { get; set; }
		public bool NewDocument { get; set; }

		private DialogResult DisplaySaveFileDialog(string title)
		{
			if (title?.Length == 0)
			{
				title = _cdHandler.CurrentFileName;
			}
			//Display prompt which asks the user for an action to take
			return MessageBox.Show("Vill du spara ändringarna för " + title + "?", "NotPad", MessageBoxButtons.YesNoCancel);
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void InformationUpdate()
		{
			int row, letter;
			var word = row = letter = 0;
			var newWord = true;

			foreach (var character in Rtb_Main.Text)
			{
				switch (character)
				{
					case ' ':
						newWord = true;
						break;

					case '\n':
						row++;
						break;

					default:
						if (newWord)
						{
							word++;
							newWord = false;
						}

						letter++;
						break;
				}
			}

			//It is assume space is a letter
			label_letters_with_space.Text = Rtb_Main.Text.Length.ToString();
			label_letters_with_no_space.Text = letter.ToString();

			//+1 is because there is always at least one row at startup.
			label_number_of_rows.Text = (row + 1).ToString();
			label_number_of_words.Text = word.ToString();
		}

		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			// If the text have been modified, we need to save it.
			if (!FileHaveBeenModified) return;
			var choice = DisplaySaveFileDialog(_cdHandler.CurrentFilePath);

			switch (choice)
			{
				case DialogResult.Yes:
					_cdHandler.SaveDocument();
					break;
				//User press cancel so don't close the window.
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
			}
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FileHaveBeenModified && DisplaySaveFileDialog(_cdHandler.CurrentFileName) == DialogResult.Yes)
			{
				//Save changes before it is overwritten
				_cdHandler.SaveDocument();
			}

			//If the file have not been modified, there is no need to save it.
			//Just create a new one.
			_cdHandler.CreateNewDocument();
			_cdHandler.SetDefaultDocumentName();
			FileHaveBeenModified = false;
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewDocument = true;
			//If text have been modified, give the user a chance to save it's work
			SaveDocumentIfModified();

			_cdHandler.OpenTextFile();
		}

		private void Rtb_Main_DragDrop(object sender, DragEventArgs e)
		{
			//Retrieve the file name including path
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);
			var file = files[0];

			SetText(file);
			//Place the cursor at the end of the text.
			Rtb_Main.SelectionStart = Rtb_Main.Text.Length;
		}

		private void Rtb_Main_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
		}

		private void Rtb_Main_TextChanged(object sender, EventArgs e)
		{
			//Update the word count, etc
			InformationUpdate();
			// Add asterix to the filename if the file have been modified and it is not a new document
			if (!NewDocument && !FileHaveBeenModified)
			{
				Text = "*" + Text;
				FileHaveBeenModified = true;
			}

			if (Rtb_Main.Text.Length == 0)
			{
				_cdHandler.SetDefaultDocumentName();
			}

			NewDocument = false;
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_cdHandler.SaveWithPrompt();
		}

		private void SaveDocumentIfModified()
		{
			if (FileHaveBeenModified)
			{
				_cdHandler.SaveDocument();
			}
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveDocumentIfModified();
		}

		private void SetText(string filePath)
		{
			var documentText = CurrentDocumentHandler.ReadFileContent(filePath);
			var allowDragAndDropText = true;

			if ((ModifierKeys & Keys.Control) != 0)
			{
				Rtb_Main.AppendText(documentText);
			}
			else if ((ModifierKeys & Keys.Shift) != 0)
			{
				var i = Rtb_Main.SelectionStart;
				var subString = Rtb_Main.Text.Substring(i);
				Rtb_Main.Text = Rtb_Main.Text.Substring(0, i);

				Rtb_Main.Text += documentText;
				Rtb_Main.Text += subString;
			}
			else if (FileHaveBeenModified)
			{
				switch (DisplaySaveFileDialog(_cdHandler.CurrentFilePath))
				{
					case DialogResult.Yes:
						_cdHandler.SaveDocument();
						break;
					case DialogResult.Cancel:
						allowDragAndDropText = false;
						break;
				}

				if (!allowDragAndDropText) return;
				Rtb_Main.Text = documentText;
				_cdHandler.SetDocumentTitle(Path.GetFileName(filePath));
				_cdHandler.CurrentFilePath = filePath;
				FileHaveBeenModified = false;
				NewDocument = true;
			}
			else
			{
				Rtb_Main.Text = documentText;
				_cdHandler.SetDocumentTitle(Path.GetFileName(filePath));
				_cdHandler.CurrentFilePath = filePath;
				NewDocument = true;
			}
		}
	}
}