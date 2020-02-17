using System;

namespace Laboration_2_Ordbehandling
{
	public class WindowHandler
	{
		private Main_Form MainWindow;

		private string StandardFileName;

		public WindowHandler(Main_Form main_Form)
		{
			MainWindow = main_Form;

			StandardFileName = "dok1.txt - NotPad";
		}

		public void AppendAsterix()
		{
			MainWindow.Text = "*" + MainWindow.Text;
		}

		internal string GetTitle()
		{
			return MainWindow.Text.Split(' ')[0].Split('.')[0].Split('*')[1];
		}

		internal void SetDefaultWindowTitle()
		{
			MainWindow.Text = StandardFileName;
		}
	}
}