using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class MultiplePlaces : Form
	{
		public MultiplePlaces()
		{
			InitializeComponent();
			
			// By default continue must be disabled
			btnContinue.Enabled = false;
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ---------------------------------------------------------------------
		private void pnlFrom_OnTextChangedEvent(object sender, EventArgs e)
		{
			btnContinue.Enabled = pnlFrom.Text != string.Empty &&
				pnlTo.Text != string.Empty;
		}
	}
}