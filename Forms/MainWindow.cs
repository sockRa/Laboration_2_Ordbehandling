using System;
using System.IO;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public partial class Main_Form : Form
	{
		private readonly CurrentDocumentHandler CDHandler;

		public bool FileHaveBeenModified { get; set; }
		public bool NewDocument { get; set; }

		public Main_Form()
		{
			InitializeComponent();
			CDHandler = new CurrentDocumentHandler(Rtb_Main, this);

			FileHaveBeenModified = false;
			NewDocument = false;

			//Set focus on textbox at startup
			ActiveControl = Rtb_Main;

			//Allow drag and drop into richtextbox
			Rtb_Main.AllowDrop = true;
		}

		private void Rtb_Main_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void Rtb_Main_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			int i;
			string subString;
			string file;

			//Get start position to drop the text.
			i = Rtb_Main.SelectionStart;
			subString = Rtb_Main.Text.Substring(i);
			Rtb_Main.Text = Rtb_Main.Text.Substring(0, i);

			//Retrive the file name including path
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			file = files[0];

			// No button is pressed, create a new document with the dragged and dropped file.
			//Rtb_Main.Text = CDHandler.ReadFileContent(file);
			SetText(file);
			//Place the cursor at the end of the text.
			Rtb_Main.SelectionStart = Rtb_Main.Text.Length;

			//Rtb_Main.Text += e.Data.GetData(DataFormats.Text).ToString();
			//Rtb_Main.Text += s;
		}

		private void SetText(string filePath)
		{
			string documentText = CDHandler.ReadFileContent(filePath);
			bool AllowText = true;

			if ((ModifierKeys & Keys.Control) != 0)
			{
				Rtb_Main.Text += documentText;
			}
			else if ((ModifierKeys & Keys.Shift) != 0)
			{
				int i = Rtb_Main.SelectionStart;
				string subString = Rtb_Main.Text.Substring(i);
				Rtb_Main.Text = Rtb_Main.Text.Substring(0, i);

				Rtb_Main.Text += documentText;
				Rtb_Main.Text += subString;
			}
			else
			{
				if (FileHaveBeenModified)
				{
					var choice = DisplaySaveFileDialog(CDHandler.CurrentFilePath);

					if (choice == DialogResult.Yes)
					{
						CDHandler.SaveDocument();
					}
					else if (choice == DialogResult.Cancel)
					{
						AllowText = false;
					}
				}

				if (AllowText)
				{
					Rtb_Main.Text = documentText;
					CDHandler.SetDocumentTitle(Path.GetFileName(filePath));
				}
			}
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
				CDHandler.SetDefaultDocumentName();
			}
		}

		private void InformationUpdate()
		{
			int word, row, letter;
			word = row = letter = 0;
			bool NewWord = true;

			foreach (char character in Rtb_Main.Text)
			{
				switch (character)
				{
					case ' ':
						NewWord = true;
						break;

					case '\n':
						row++;
						break;

					default:
						if (NewWord)
						{
							word++;
							NewWord = false;
						}

						letter++;
						break;
				}
			}

			//It is assume space is a letter
			label_letters_with_space.Text = Rtb_Main.Text.Length.ToString();
			label_letters_with_no_space.Text = letter.ToString();

			//+1 is because there is always atleast one row at startup.
			label_number_of_rows.Text = (row + 1).ToString();
			label_number_of_words.Text = word.ToString();
		}

		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			// If the text have been modified, we need to save it.
			if (FileHaveBeenModified)
			{
				var choice = DisplaySaveFileDialog(CDHandler.CurrentFilePath);

				if (choice == DialogResult.Yes)
				{
					CDHandler.SaveDocument();
				}
				else if (choice == DialogResult.Cancel)
				{
					//User press cancel so don't close the window.
					e.Cancel = true;
				}
			}
		}

		public DialogResult DisplaySaveFileDialog(string title)
		{
			if (title?.Length == 0)
			{
				title = CDHandler.CurrentFileName;
			}
			//Display promt which asks the user for an action to take
			return MessageBox.Show("Vill du spara ändringarna för " + title + "?", "NotPad", MessageBoxButtons.YesNoCancel);
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FileHaveBeenModified && DisplaySaveFileDialog(CDHandler.CurrentFileName) == DialogResult.Yes)
			{
				//Save changes before it is overwritten
				CDHandler.SaveDocument();
			}

			//If the file have not been modified, there is no need to save it.
			//Just create a new one.
			CDHandler.CreateNewDocument();
			CDHandler.SetDefaultDocumentName();
			FileHaveBeenModified = false;
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewDocument = true;
			//If text have been modified, give the user a chance to save it's work
			SaveDocumentIfModified();

			CDHandler.OpenTextFile();
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveDocumentIfModified();
		}

		private void SaveDocumentIfModified()
		{
			if (FileHaveBeenModified)
			{
				CDHandler.SaveDocument();
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CDHandler.SaveWithPromt();
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}