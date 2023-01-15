using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class SearchForm : Form
	{
		public SearchForm()
		{
			InitializeComponent();
		}


		/// <summary>
		/// 
		/// </summary>
		public event EventHandler OnCancel = null;



		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		/// ---------------------------------------------------------------------
		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			e.Cancel = true;
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// Draw rectangle
		/// </summary>
		/// <param name="e"></param>
		/// ---------------------------------------------------------------------
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.DrawRectangle(new Pen(SystemColors.WindowFrame), 
				pnlLogo.Left - 18, lblSearch.Top - 19, 181, 105);
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ---------------------------------------------------------------------
		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (OnCancel != null)
			{
				OnCancel(sender, e);
			}
		}

		

		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string StatusText
		{
			set
			{
				lblSearch.Text = value;
				lblSearch.Refresh();
			}
		}
	}
}