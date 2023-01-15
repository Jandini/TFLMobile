using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class LogoPanel : UserControl
	{

		/// <summary>
		/// 
		/// </summary>
		public LogoPanel()
		{
			InitializeComponent();			
		}


		/// <summary>
		/// Font
		/// </summary>
		private Font font = new Font("Tahoma", 8, FontStyle.Bold);

		/// <summary>
		/// Brush
		/// </summary>
		private Brush brush = new SolidBrush(Color.FromArgb(0, 0, 150));




		/// <summary>
		/// owner
		/// </summary>
		private Form owner = null;




		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			const int logoWidth = 150;
			const int logoY = 2;

			// center logo
			int logoX = (e.ClipRectangle.Width / 2) - (logoWidth / 2);


			int textX = logoX + 20;
			const int textY = logoY + 1;

			if (Parent != null)
			{
				if (owner != null)
				{
					e.Graphics.DrawIcon(owner.Icon, logoX, logoY);
				}

				e.Graphics.DrawString(Strings.strLogoCaption, font, brush, textX, textY);
			}
		}



		/// <summary>
		/// 
		/// </summary>
		public Form Owner
		{
			get
			{
				return owner;
			}

			set
			{
				owner = value;
			}

		}
	}
}
