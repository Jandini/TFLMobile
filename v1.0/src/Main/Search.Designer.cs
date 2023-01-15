namespace Janda
{
	partial class SearchForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblTransport = new System.Windows.Forms.Label();
			this.pnlLogo = new Janda.LogoPanel();
			this.SuspendLayout();
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.lblSearch.Location = new System.Drawing.Point(45, 108);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(150, 16);
			this.lblSearch.Text = "Connecting...";
			this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnCancel.Location = new System.Drawing.Point(84, 155);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 20);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblTransport
			// 
			this.lblTransport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTransport.BackColor = System.Drawing.SystemColors.Highlight;
			this.lblTransport.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.lblTransport.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblTransport.Location = new System.Drawing.Point(3, 3);
			this.lblTransport.Name = "lblTransport";
			this.lblTransport.Size = new System.Drawing.Size(234, 15);
			this.lblTransport.Text = "Searching Transport for London";
			this.lblTransport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnlLogo
			// 
			this.pnlLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlLogo.Location = new System.Drawing.Point(45, 126);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Owner = this;
			this.pnlLogo.Size = new System.Drawing.Size(150, 23);
			this.pnlLogo.TabIndex = 3;
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.ClientSize = new System.Drawing.Size(240, 294);
			this.Controls.Add(this.lblTransport);
			this.Controls.Add(this.pnlLogo);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.lblSearch);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.Text = "TFL Mobile";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblSearch;
		private LogoPanel pnlLogo;
		private System.Windows.Forms.Label lblTransport;
		public System.Windows.Forms.Button btnCancel;

	}
}