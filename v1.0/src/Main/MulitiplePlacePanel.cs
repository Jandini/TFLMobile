using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class MulitiplePlacePanel : UserControl
	{

		
		/// <summary>
		/// List of values e.g. 0:1, 1:0
		/// </summary>
		private string[] values = null;


		/// <summary>
		/// 
		/// </summary>
		public event EventHandler OnTextChangedEvent = null;


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public MulitiplePlacePanel()
		{
			InitializeComponent();
		}




		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string Caption
		{
			get
			{
				return lblCaption.Text;
			}

			set
			{
				lblCaption.Text = value;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="strings"></param>
		/// ---------------------------------------------------------------------
		public void SetValues(string[] strings)
		{
			if (strings != null)
			{
				this.values = new string[strings.Length];

				for (int i = 0; i < strings.Length; i++)
				{
					string s = strings[i];

					string[] v = s.Split('|');

					if (v.Length == 2)
					{
						// Put the name of place into combobox
						cbxPlace.Items.Add(v[0]);

						// Remember value of that place
						values[i] = v[1];
					}
				}
			}
		}



		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string SelectedValue
		{
			get
			{
				string result = string.Empty;

				if (values != null && cbxPlace.SelectedIndex != -1)
				{
					return values[cbxPlace.SelectedIndex];
				}

				return result;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public new string Text
		{
			get
			{
				return cbxPlace.Text;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string PlaceName
		{
			get
			{
				return cbxPlace.Text;
			}
			set
			{
				cbxPlace.DropDownStyle = ComboBoxStyle.DropDown;
				cbxPlace.Text = value;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// ---------------------------------------------------------------------
		private void cbxPlace_TextChanged(object sender, EventArgs e)
		{
			if (OnTextChangedEvent != null)
			{
				OnTextChangedEvent(sender, e);
			}
		}
	}
}
