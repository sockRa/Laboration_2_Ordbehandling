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
		private WindowHandler wHandler;
		private StringHandler sHandler;

		private bool TextHaveBeenModified = false;

		public Main_Form()
		{
			InitializeComponent();
			wHandler = new WindowHandler(this);
		}

		private void Rtb_Main_TextChanged(object sender, EventArgs e)
		{
			if (!TextHaveBeenModified)
			{
				wHandler.AppendAsterix();
				TextHaveBeenModified = true;
			}
		}
	}
}