namespace Janda
{
	partial class TransportPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem();
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportPanel));
			this.lstTransport = new System.Windows.Forms.ListView();
			this.lblTransport = new System.Windows.Forms.Label();
			this.imgIcons24 = new System.Windows.Forms.ImageList();
			this.SuspendLayout();
			// 
			// lstTransport
			// 
			this.lstTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.lstTransport.CheckBoxes = true;
			this.lstTransport.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			listViewItem1.ImageIndex = 0;
			listViewItem1.Tag = "inclMOT_0";
			listViewItem1.Text = "Rail";
			listViewItem2.ImageIndex = 1;
			listViewItem2.Tag = "inclMOT_1";
			listViewItem2.Text = "DLR";
			listViewItem3.ImageIndex = 2;
			listViewItem3.Tag = "inclMOT_2";
			listViewItem3.Text = "Tube";
			listViewItem4.ImageIndex = 3;
			listViewItem4.Tag = "inclMOT_4";
			listViewItem4.Text = "Tram";
			listViewItem5.ImageIndex = 4;
			listViewItem5.Tag = "inclMOT_5";
			listViewItem5.Text = "Bus";
			listViewItem6.ImageIndex = 5;
			listViewItem6.Tag = "inclMOT_7";
			listViewItem6.Text = "Coach";
			listViewItem7.ImageIndex = 6;
			listViewItem7.Tag = "inclMOT_9";
			listViewItem7.Text = "River";
			listViewItem8.ImageIndex = 7;
			listViewItem8.Tag = "useProxFootSearch";
			listViewItem8.Text = "Walk";
			this.lstTransport.Items.Add(listViewItem1);
			this.lstTransport.Items.Add(listViewItem2);
			this.lstTransport.Items.Add(listViewItem3);
			this.lstTransport.Items.Add(listViewItem4);
			this.lstTransport.Items.Add(listViewItem5);
			this.lstTransport.Items.Add(listViewItem6);
			this.lstTransport.Items.Add(listViewItem7);
			this.lstTransport.Items.Add(listViewItem8);
			this.lstTransport.LargeImageList = this.imgIcons24;
			this.lstTransport.Location = new System.Drawing.Point(0, 18);
			this.lstTransport.Name = "lstTransport";
			this.lstTransport.Size = new System.Drawing.Size(247, 209);
			this.lstTransport.TabIndex = 1;
			this.lstTransport.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstTransport_ItemCheck);
			// 
			// lblTransport
			// 
			this.lblTransport.BackColor = System.Drawing.SystemColors.Highlight;
			this.lblTransport.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTransport.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.lblTransport.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblTransport.Location = new System.Drawing.Point(0, 0);
			this.lblTransport.Name = "lblTransport";
			this.lblTransport.Size = new System.Drawing.Size(247, 15);
			this.lblTransport.Text = "Use any of these modes of transport";
			this.lblTransport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// imgIcons24
			// 
			this.imgIcons24.ImageSize = new System.Drawing.Size(24, 24);
			this.imgIcons24.Images.Clear();
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
			this.imgIcons24.Images.Add(((System.Drawing.Image)(resources.GetObject("resource7"))));
			// 
			// TransportPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.lblTransport);
			this.Controls.Add(this.lstTransport);
			this.Name = "TransportPanel";
			this.Size = new System.Drawing.Size(247, 227);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstTransport;
		private System.Windows.Forms.Label lblTransport;
		private System.Windows.Forms.ImageList imgIcons24;
	}
}
