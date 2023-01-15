using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class ResultListItem : UserControl
	{
		public ResultListItem()
		{
			InitializeComponent();

					
		}

		/// <summary>
		/// 
		/// </summary>
		private ResultListItem nextItem = null;

		/// <summary>
		/// 
		/// </summary>
		private ResultListItem prevItem = null;


		protected override void OnPaintBackground(PaintEventArgs e)
		{
			// Don't paint the background...			
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Color color = Focused ? SystemColors.Highlight : SystemColors.Window;
			Brush brush = new SolidBrush(color);
			Pen pen = new Pen(SystemColors.InactiveBorder);
			Rectangle rectangle = e.ClipRectangle;

			e.Graphics.FillRectangle(brush, rectangle);
			e.Graphics.DrawRectangle(pen, rectangle);			
		}

		
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			Invalidate();
		}


		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			Invalidate();
		}


		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.Focus();
		}


		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			switch (e.KeyCode)
			{
				case Keys.Up:

					if (nextItem != null)
					{
						nextItem.Focus();
					}
					break;

				case Keys.Down:
					if (prevItem != null)
					{
						prevItem.Focus();
					}
					break;
			}

			e.Handled = true;			
		}


		
		
		public ResultListItem NextItem
		{
			get
			{
				return nextItem;
			}

			set
			{
				nextItem = value;
			}
		}


		public ResultListItem PrevItem
		{
			get
			{
				return prevItem;
			}

			set
			{
				prevItem = value;
			}
		}
		
	}
}
