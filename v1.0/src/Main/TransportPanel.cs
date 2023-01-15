using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class TransportPanel : UserControl
	{
		public TransportPanel()
		{
			InitializeComponent();
		}

		public delegate void SelectionHandler(CheckState state);
		public event SelectionHandler OnSelectionChanged = null;


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="select"></param>
		/// ---------------------------------------------------------------------
		public void SelectAll(bool select)
		{
			lstTransport.ItemCheck -= new ItemCheckEventHandler(lstTransport_ItemCheck);

			try
			{
				foreach (ListViewItem item in lstTransport.Items)
				{
					item.Checked = select;
				}
			}
			finally
			{
				lstTransport.ItemCheck += new ItemCheckEventHandler(lstTransport_ItemCheck);
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// ---------------------------------------------------------------------
		private int GetSelectedCount()
		{
			int result = 0;

			foreach (ListViewItem item in lstTransport.Items)
			{
				if (item.Checked)
				{
					result++;
				}
			}

			return result;
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		protected void SelectionChanged(CheckState state)
		{
			int selectedCount = GetSelectedCount();

			if (state == CheckState.Checked)
			{
				selectedCount++;
			}
			else
			{
				selectedCount--;
			}

			CheckState checkState = CheckState.Unchecked;

			if (selectedCount == lstTransport.Items.Count)
			{
				checkState = CheckState.Checked;
			}
			else
			{
				if (selectedCount > 0)
				{
					checkState = CheckState.Indeterminate;
				}
			}

			if (OnSelectionChanged != null)
			{
				OnSelectionChanged(checkState);
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ---------------------------------------------------------------------
		private void lstTransport_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			SelectionChanged(e.NewValue);
		}



		/// <summary>
		/// 
		/// </summary>
		public string RequestParameters
		{
			get
			{
				string result = "&includedMeans=checkbox&inclMOT_11=1";

				foreach (ListViewItem item in lstTransport.Items)
				{
					if (item.Checked)
					{
						result += "&" + item.Tag.ToString() + "=on";
					}
				}

				return result;
			}
		}
	}
}
