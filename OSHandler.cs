using System;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public class OSHandler
	{
		private SaveFileDialog sDialog;
		private OpenFileDialog oDialog;

		public OSHandler()
		{
			sDialog = new SaveFileDialog();
			oDialog = new OpenFileDialog();
		}

		internal void SaveChanges()
		{
		}

		internal void OpenTextFile()
		{
			OpenFileDialog dialog = new OpenFileDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
			}
		}
	}
}