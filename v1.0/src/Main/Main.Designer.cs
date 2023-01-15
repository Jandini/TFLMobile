namespace Janda
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mnuMain;

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
			  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			  this.mnuMain = new System.Windows.Forms.MainMenu();
			  this.tabResults = new System.Windows.Forms.TabPage();
			  this.btnLatest = new System.Windows.Forms.Button();
			  this.btnLater = new System.Windows.Forms.Button();
			  this.btnEarlier = new System.Windows.Forms.Button();
			  this.btnEarliest = new System.Windows.Forms.Button();
			  this.lblResults = new System.Windows.Forms.Label();
			  this.lstResults = new System.Windows.Forms.ListView();
			  this.colNo = new System.Windows.Forms.ColumnHeader();
			  this.colDepart = new System.Windows.Forms.ColumnHeader();
			  this.colArrive = new System.Windows.Forms.ColumnHeader();
			  this.colDuration = new System.Windows.Forms.ColumnHeader();
			  this.colTransport = new System.Windows.Forms.ColumnHeader();
			  this.imgIcons = new System.Windows.Forms.ImageList();
			  this.tabTransport = new System.Windows.Forms.TabPage();
			  this.chkSelectAll = new System.Windows.Forms.CheckBox();
			  this.btnSearchTransport = new System.Windows.Forms.Button();
			  this.pnlTransport = new Janda.TransportPanel();
			  this.tabRoute = new System.Windows.Forms.TabPage();
			  this.chkReverse = new System.Windows.Forms.CheckBox();
			  this.lblTransport = new System.Windows.Forms.Label();
			  this.btnLeaveNow = new System.Windows.Forms.Button();
			  this.pnlTime = new Janda.TimePanel();
			  this.btnSearchRoute = new System.Windows.Forms.Button();
			  this.pnlTo = new Janda.FromToPanel();
			  this.pnlFrom = new Janda.FromToPanel();
			  this.tabMain = new System.Windows.Forms.TabControl();
			  this.tabDetails = new System.Windows.Forms.TabPage();
			  this.lblDetails = new System.Windows.Forms.Label();
			  this.webBrowser = new System.Windows.Forms.WebBrowser();
			  this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			  this.tabResults.SuspendLayout();
			  this.tabTransport.SuspendLayout();
			  this.tabRoute.SuspendLayout();
			  this.tabMain.SuspendLayout();
			  this.tabDetails.SuspendLayout();
			  this.SuspendLayout();
			  // 
			  // tabResults
			  // 
			  this.tabResults.AutoScrollMargin = new System.Drawing.Size(240, 320);
			  this.tabResults.Controls.Add(this.btnLatest);
			  this.tabResults.Controls.Add(this.btnLater);
			  this.tabResults.Controls.Add(this.btnEarlier);
			  this.tabResults.Controls.Add(this.btnEarliest);
			  this.tabResults.Controls.Add(this.lblResults);
			  this.tabResults.Controls.Add(this.lstResults);
			  this.tabResults.Location = new System.Drawing.Point(0, 0);
			  this.tabResults.Name = "tabResults";
			  this.tabResults.Size = new System.Drawing.Size(240, 245);
			  this.tabResults.Text = "Journey";
			  // 
			  // btnLatest
			  // 
			  this.btnLatest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			  this.btnLatest.Enabled = false;
			  this.btnLatest.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnLatest.Location = new System.Drawing.Point(183, 220);
			  this.btnLatest.Name = "btnLatest";
			  this.btnLatest.Size = new System.Drawing.Size(54, 20);
			  this.btnLatest.TabIndex = 7;
			  this.btnLatest.Tag = "tripLast";
			  this.btnLatest.Text = "latest";
			  this.btnLatest.Click += new System.EventHandler(this.btnEarliest_Click);
			  // 
			  // btnLater
			  // 
			  this.btnLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			  this.btnLater.Enabled = false;
			  this.btnLater.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnLater.Location = new System.Drawing.Point(123, 220);
			  this.btnLater.Name = "btnLater";
			  this.btnLater.Size = new System.Drawing.Size(54, 20);
			  this.btnLater.TabIndex = 6;
			  this.btnLater.Tag = "tripNext";
			  this.btnLater.Text = "later";
			  this.btnLater.Click += new System.EventHandler(this.btnEarliest_Click);
			  // 
			  // btnEarlier
			  // 
			  this.btnEarlier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			  this.btnEarlier.Enabled = false;
			  this.btnEarlier.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnEarlier.Location = new System.Drawing.Point(63, 220);
			  this.btnEarlier.Name = "btnEarlier";
			  this.btnEarlier.Size = new System.Drawing.Size(54, 20);
			  this.btnEarlier.TabIndex = 5;
			  this.btnEarlier.Tag = "tripPrev";
			  this.btnEarlier.Text = "earlier";
			  this.btnEarlier.Click += new System.EventHandler(this.btnEarliest_Click);
			  // 
			  // btnEarliest
			  // 
			  this.btnEarliest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			  this.btnEarliest.Enabled = false;
			  this.btnEarliest.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnEarliest.Location = new System.Drawing.Point(3, 220);
			  this.btnEarliest.Name = "btnEarliest";
			  this.btnEarliest.Size = new System.Drawing.Size(54, 20);
			  this.btnEarliest.TabIndex = 4;
			  this.btnEarliest.Tag = "tripFirst";
			  this.btnEarliest.Text = "earliest";
			  this.btnEarliest.Click += new System.EventHandler(this.btnEarliest_Click);
			  // 
			  // lblResults
			  // 
			  this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							  | System.Windows.Forms.AnchorStyles.Right)));
			  this.lblResults.BackColor = System.Drawing.SystemColors.Highlight;
			  this.lblResults.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.lblResults.ForeColor = System.Drawing.SystemColors.HighlightText;
			  this.lblResults.Location = new System.Drawing.Point(3, 3);
			  this.lblResults.Name = "lblResults";
			  this.lblResults.Size = new System.Drawing.Size(234, 15);
			  this.lblResults.Text = "Choose route of your journey";
			  this.lblResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			  // 
			  // lstResults
			  // 
			  this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							  | System.Windows.Forms.AnchorStyles.Left)
							  | System.Windows.Forms.AnchorStyles.Right)));
			  this.lstResults.Columns.Add(this.colNo);
			  this.lstResults.Columns.Add(this.colDepart);
			  this.lstResults.Columns.Add(this.colArrive);
			  this.lstResults.Columns.Add(this.colDuration);
			  this.lstResults.Columns.Add(this.colTransport);
			  this.lstResults.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			  this.lstResults.FullRowSelect = true;
			  this.lstResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			  this.lstResults.Location = new System.Drawing.Point(3, 21);
			  this.lstResults.Name = "lstResults";
			  this.lstResults.Size = new System.Drawing.Size(234, 193);
			  this.lstResults.TabIndex = 0;
			  this.lstResults.View = System.Windows.Forms.View.Details;
			  this.lstResults.ItemActivate += new System.EventHandler(this.lstResults_ItemActivate);
			  // 
			  // colNo
			  // 
			  this.colNo.Text = "#";
			  this.colNo.Width = 20;
			  // 
			  // colDepart
			  // 
			  this.colDepart.Text = "Depart";
			  this.colDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			  this.colDepart.Width = 45;
			  // 
			  // colArrive
			  // 
			  this.colArrive.Text = "Arrive";
			  this.colArrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			  this.colArrive.Width = 45;
			  // 
			  // colDuration
			  // 
			  this.colDuration.Text = "Duration";
			  this.colDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			  this.colDuration.Width = 55;
			  // 
			  // colTransport
			  // 
			  this.colTransport.Text = "Transport";
			  this.colTransport.Width = 66;
			  this.imgIcons.Images.Clear();
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
			  this.imgIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
			  // 
			  // tabTransport
			  // 
			  this.tabTransport.AutoScroll = true;
			  this.tabTransport.Controls.Add(this.chkSelectAll);
			  this.tabTransport.Controls.Add(this.btnSearchTransport);
			  this.tabTransport.Controls.Add(this.pnlTransport);
			  this.tabTransport.Location = new System.Drawing.Point(0, 0);
			  this.tabTransport.Name = "tabTransport";
			  this.tabTransport.Size = new System.Drawing.Size(240, 245);
			  this.tabTransport.Text = "Transport";
			  this.tabTransport.Resize += new System.EventHandler(this.tabTransport_Resize);
			  // 
			  // chkSelectAll
			  // 
			  this.chkSelectAll.ThreeState = true;
			  this.chkSelectAll.Checked = true;
			  this.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
			  this.chkSelectAll.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			  this.chkSelectAll.Location = new System.Drawing.Point(3, 220);
			  this.chkSelectAll.Name = "chkSelectAll";
			  this.chkSelectAll.Size = new System.Drawing.Size(107, 20);
			  this.chkSelectAll.TabIndex = 47;
			  this.chkSelectAll.Text = "Select all modes";
			  this.chkSelectAll.Click += new System.EventHandler(this.chkSelectAll_Click);
			  // 
			  // btnSearchTransport
			  // 
			  this.btnSearchTransport.Anchor = System.Windows.Forms.AnchorStyles.None;
			  this.btnSearchTransport.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnSearchTransport.Location = new System.Drawing.Point(159, 220);
			  this.btnSearchTransport.Name = "btnSearchTransport";
			  this.btnSearchTransport.Size = new System.Drawing.Size(78, 20);
			  this.btnSearchTransport.TabIndex = 46;
			  this.btnSearchTransport.Text = "Search";
			  this.btnSearchTransport.Click += new System.EventHandler(this.btnSearchTransport_Click);
			  // 
			  // pnlTransport
			  // 
			  this.pnlTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							  | System.Windows.Forms.AnchorStyles.Left)
							  | System.Windows.Forms.AnchorStyles.Right)));
			  this.pnlTransport.Location = new System.Drawing.Point(3, 3);
			  this.pnlTransport.Name = "pnlTransport";
			  this.pnlTransport.Size = new System.Drawing.Size(234, 211);
			  this.pnlTransport.TabIndex = 0;
			  this.pnlTransport.OnSelectionChanged += new Janda.TransportPanel.SelectionHandler(this.pnlTransport_OnSelectionChanged);
			  // 
			  // tabRoute
			  // 
			  this.tabRoute.AutoScroll = true;
			  this.tabRoute.Controls.Add(this.chkReverse);
			  this.tabRoute.Controls.Add(this.lblTransport);
			  this.tabRoute.Controls.Add(this.btnLeaveNow);
			  this.tabRoute.Controls.Add(this.pnlTime);
			  this.tabRoute.Controls.Add(this.btnSearchRoute);
			  this.tabRoute.Controls.Add(this.pnlTo);
			  this.tabRoute.Controls.Add(this.pnlFrom);
			  this.tabRoute.Location = new System.Drawing.Point(0, 0);
			  this.tabRoute.Name = "tabRoute";
			  this.tabRoute.Size = new System.Drawing.Size(240, 245);
			  this.tabRoute.Text = "Route";
			  // 
			  // chkReverse
			  // 
			  this.chkReverse.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			  this.chkReverse.Location = new System.Drawing.Point(3, 130);
			  this.chkReverse.Name = "chkReverse";
			  this.chkReverse.Size = new System.Drawing.Size(100, 20);
			  this.chkReverse.TabIndex = 49;
			  this.chkReverse.Text = "Reverse route";
			  this.chkReverse.CheckStateChanged += new System.EventHandler(this.chkReverse_CheckStateChanged);
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
			  this.lblTransport.Text = "Traveling";
			  this.lblTransport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			  // 
			  // btnLeaveNow
			  // 
			  this.btnLeaveNow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnLeaveNow.Location = new System.Drawing.Point(159, 130);
			  this.btnLeaveNow.Name = "btnLeaveNow";
			  this.btnLeaveNow.Size = new System.Drawing.Size(78, 20);
			  this.btnLeaveNow.TabIndex = 48;
			  this.btnLeaveNow.Text = "Leave now";
			  this.btnLeaveNow.Click += new System.EventHandler(this.btnLeaveNow_Click);
			  // 
			  // pnlTime
			  // 
			  this.pnlTime.Enabled = false;
			  this.pnlTime.Location = new System.Drawing.Point(3, 174);
			  this.pnlTime.Name = "pnlTime";
			  this.pnlTime.Size = new System.Drawing.Size(234, 40);
			  this.pnlTime.TabIndex = 46;
			  // 
			  // btnSearchRoute
			  // 
			  this.btnSearchRoute.Enabled = false;
			  this.btnSearchRoute.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.btnSearchRoute.Location = new System.Drawing.Point(159, 220);
			  this.btnSearchRoute.Name = "btnSearchRoute";
			  this.btnSearchRoute.Size = new System.Drawing.Size(78, 20);
			  this.btnSearchRoute.TabIndex = 45;
			  this.btnSearchRoute.Text = "Search";
			  this.btnSearchRoute.Click += new System.EventHandler(this.btnSearchRoute_Click);
			  // 
			  // pnlTo
			  // 
			  this.pnlTo.DefaultPlace = "To...";
			  this.pnlTo.Location = new System.Drawing.Point(122, 21);
			  this.pnlTo.Name = "pnlTo";
			  this.pnlTo.Size = new System.Drawing.Size(115, 103);
			  this.pnlTo.TabIndex = 1;
			  // 
			  // pnlFrom
			  // 
			  this.pnlFrom.DefaultPlace = "From...";
			  this.pnlFrom.Location = new System.Drawing.Point(3, 21);
			  this.pnlFrom.Name = "pnlFrom";
			  this.pnlFrom.Size = new System.Drawing.Size(115, 103);
			  this.pnlFrom.TabIndex = 0;
			  // 
			  // tabMain
			  // 
			  this.tabMain.Controls.Add(this.tabRoute);
			  this.tabMain.Controls.Add(this.tabTransport);
			  this.tabMain.Controls.Add(this.tabResults);
			  this.tabMain.Controls.Add(this.tabDetails);
			  this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			  this.tabMain.Location = new System.Drawing.Point(0, 0);
			  this.tabMain.Name = "tabMain";
			  this.tabMain.SelectedIndex = 0;
			  this.tabMain.Size = new System.Drawing.Size(240, 268);
			  this.tabMain.TabIndex = 3;
			  // 
			  // tabDetails
			  // 
			  this.tabDetails.Controls.Add(this.lblDetails);
			  this.tabDetails.Controls.Add(this.webBrowser);
			  this.tabDetails.Location = new System.Drawing.Point(0, 0);
			  this.tabDetails.Name = "tabDetails";
			  this.tabDetails.Size = new System.Drawing.Size(240, 245);
			  this.tabDetails.Text = "Summary";
			  this.tabDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.tabDetails_Paint);
			  // 
			  // lblDetails
			  // 
			  this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							  | System.Windows.Forms.AnchorStyles.Right)));
			  this.lblDetails.BackColor = System.Drawing.SystemColors.Highlight;
			  this.lblDetails.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			  this.lblDetails.ForeColor = System.Drawing.SystemColors.HighlightText;
			  this.lblDetails.Location = new System.Drawing.Point(3, 3);
			  this.lblDetails.Name = "lblDetails";
			  this.lblDetails.Size = new System.Drawing.Size(234, 15);
			  this.lblDetails.Text = "Journey summary";
			  this.lblDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			  // 
			  // webBrowser
			  // 
			  this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							  | System.Windows.Forms.AnchorStyles.Left)
							  | System.Windows.Forms.AnchorStyles.Right)));
			  this.webBrowser.Location = new System.Drawing.Point(4, 22);
			  this.webBrowser.Name = "webBrowser";
			  this.webBrowser.Size = new System.Drawing.Size(232, 219);
			  // 
			  // dateTimePicker2
			  // 
			  this.dateTimePicker2.CustomFormat = "\'on\' dd/mm/yyyy \'at\' hh:mm \'hours\'";
			  this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			  this.dateTimePicker2.Location = new System.Drawing.Point(3, 28);
			  this.dateTimePicker2.Name = "dateTimePicker2";
			  this.dateTimePicker2.Size = new System.Drawing.Size(234, 22);
			  this.dateTimePicker2.TabIndex = 41;
			  // 
			  // frmMain
			  // 
			  this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			  this.AutoScroll = true;
			  this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			  this.BackColor = System.Drawing.Color.WhiteSmoke;
			  this.ClientSize = new System.Drawing.Size(240, 268);
			  this.Controls.Add(this.tabMain);
			  this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			  this.KeyPreview = true;
			  this.Menu = this.mnuMain;
			  this.Name = "frmMain";
			  this.Text = "TFL Mobile";
			  this.tabResults.ResumeLayout(false);
			  this.tabTransport.ResumeLayout(false);
			  this.tabRoute.ResumeLayout(false);
			  this.tabMain.ResumeLayout(false);
			  this.tabDetails.ResumeLayout(false);
			  this.ResumeLayout(false);

        }

        #endregion

		 private System.Windows.Forms.TabPage tabResults;
		 private System.Windows.Forms.ListView lstResults;
		 private System.Windows.Forms.ColumnHeader colNo;
		 private System.Windows.Forms.ColumnHeader colDepart;
		 private System.Windows.Forms.ColumnHeader colArrive;
		 private System.Windows.Forms.ColumnHeader colDuration;
		 private System.Windows.Forms.ColumnHeader colTransport;
		 private System.Windows.Forms.TabPage tabTransport;
		 private System.Windows.Forms.TabPage tabRoute;
		 private FromToPanel pnlTo;
		 private FromToPanel pnlFrom;
		 private System.Windows.Forms.TabControl tabMain;
		 private System.Windows.Forms.Button btnSearchRoute;
		 private System.Windows.Forms.DateTimePicker dateTimePicker2;
		 private TimePanel pnlTime;
		 private TransportPanel pnlTransport;
		 private System.Windows.Forms.Button btnSearchTransport;
		 private System.Windows.Forms.CheckBox chkSelectAll;
		 private System.Windows.Forms.Button btnLeaveNow;
		 private System.Windows.Forms.Label lblTransport;
		 private System.Windows.Forms.Label lblResults;
		 private System.Windows.Forms.CheckBox chkReverse;
		 private System.Windows.Forms.ImageList imgIcons;
		 private System.Windows.Forms.Button btnLater;
		 private System.Windows.Forms.Button btnEarlier;
		 private System.Windows.Forms.Button btnEarliest;
		 private System.Windows.Forms.Button btnLatest;
		 private System.Windows.Forms.TabPage tabDetails;
		 private System.Windows.Forms.Label lblDetails;
		 private System.Windows.Forms.WebBrowser webBrowser;
    }
}

