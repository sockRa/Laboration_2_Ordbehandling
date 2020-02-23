using System;
using System.Windows.Forms;
using Laboration_2_Ordbehandling.Forms;

namespace Laboration_2_Ordbehandling
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}