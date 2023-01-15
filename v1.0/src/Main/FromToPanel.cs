using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class FromToPanel : UserControl
	{

		/// <summary>
		/// Default value will be placed when combo box value is empty
		/// </summary>
		private string defaultPlace = string.Empty;


		/// <summary>
		/// 
		/// </summary>
		private string typeOfPlace = string.Empty;


		/// <summary>
		/// 
		/// </summary>
		private Microsoft.WindowsCE.Forms.InputPanel inputPanel = null;


		/// ------------------------------------------------------------------------
		/// <summary>
		/// Class constructor
		/// </summary>
		/// ------------------------------------------------------------------------
		public FromToPanel()
		{
			InitializeComponent();

			// Set default place type to "stop"
			typeOfPlace = rbtStation.Tag.ToString();

			try
			{
				this.inputPanel = new Microsoft.WindowsCE.Forms.InputPanel();
			}
			catch (Exception)
			{

			}
		}


		


		/// ------------------------------------------------------------------------
		/// <summary>
		/// Default place property
		/// </summary>
		/// ------------------------------------------------------------------------
		public string DefaultPlace
		{
			get
			{
				return defaultPlace;
			}

			set
			{
				defaultPlace = value;
				PlaceName = value;
			}
		}




		/// ------------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ------------------------------------------------------------------------
		private void cbxPlace_GotFocus(object sender, EventArgs e)
		{
			if (inputPanel != null)
			{
				inputPanel.Enabled = true;
			}
		}


		/// ------------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ------------------------------------------------------------------------
		private void cbxPlace_LostFocus(object sender, EventArgs e)
		{
			inputPanel.Enabled = false;
		}



		/// ------------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ------------------------------------------------------------------------
		private void rbtStation_CheckedChanged(object sender, EventArgs e)
		{
			typeOfPlace = (sender as RadioButton).Tag.ToString(); ;
		}



		/// ------------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ------------------------------------------------------------------------
		public string PlaceName
		{
			get
			{
				return cbxPlace.Text;
			}

			set
			{
				cbxPlace.Text = value;
			}
		}


		/// ------------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ------------------------------------------------------------------------
		public string PlaceType
		{
			get
			{
				return this.typeOfPlace;
			}
			set
			{
				foreach (Control control in this.Controls)
				{
					if (control is RadioButton)
					{
						RadioButton radio = control as RadioButton;

						if (radio.Tag as string == value)
						{
							radio.Checked = true;
							
							break;
						}
					}
				}
			}
		}
	}
}
