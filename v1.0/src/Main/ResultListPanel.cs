using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Janda
{
	public partial class ResultListPanel : UserControl
	{
		public ResultListPanel()
		{
			InitializeComponent();


			resultListItem1.NextItem = resultListItem2;
			resultListItem2.PrevItem = resultListItem1;
			resultListItem2.NextItem = resultListItem3;			
			resultListItem3.PrevItem = resultListItem2;
		}
	}
}
