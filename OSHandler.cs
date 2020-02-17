using System;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling
{
	public class OSHandler
	{
		private SaveFileDialog saveFileDialog1;

		public OSHandler(SaveFileDialog saveFileDialog1)
		{
			this.saveFileDialog1 = saveFileDialog1;
		}

		internal void SaveChanges()
		{
			throw new NotImplementedException();
		}
	}
}