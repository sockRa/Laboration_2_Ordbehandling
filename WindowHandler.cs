using System;

namespace Laboration_2_Ordbehandling
{
	internal class WindowHandler
	{
		private Main_Form MainWindow;

		public WindowHandler(Main_Form main_Form)
		{
			MainWindow = main_Form;
		}

		internal void AppendAsterix()
		{
			MainWindow.Text = "*" + MainWindow.Text;
		}
	}
}