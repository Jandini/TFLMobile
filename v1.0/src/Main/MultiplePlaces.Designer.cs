namespace Janda
{
	partial class MultiplePlaces
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
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblTransport = new System.Windows.Forms.Label();
			this.btnContinue = new System.Windows.Forms.Button();
			this.pnlTo = new Janda.MulitiplePlacePanel();
			this.pnlFrom = new Janda.MulitiplePlacePanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(4, 25);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(233, 55);
			this.lblMessage.Text = "Journey Planner has found a number of locations matching the start location or de" +
				 "stination you entered. Please choose from the lists below.";
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
			this.lblTransport.Text = "Journey Planner";
			this.lblTransport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnContinue
			// 
			this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnContinue.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnContinue.Location = new System.Drawing.Point(165, 176);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(72, 20);
			this.btnContinue.TabIndex = 9;
			this.btnContinue.Text = "Continue";
			// 
			// pnlTo
			// 
			this.pnlTo.Caption = "Travelling to...";
			this.pnlTo.Location = new System.Drawing.Point(4, 130);
			this.pnlTo.Name = "pnlTo";
			this.pnlTo.Size = new System.Drawing.Size(233, 40);
			this.pnlTo.TabIndex = 13;
			this.pnlTo.OnTextChangedEvent += new System.EventHandler(this.pnlFrom_OnTextChangedEvent);
			// 
			// pnlFrom
			// 
			this.pnlFrom.Caption = "Travelling from...";
			this.pnlFrom.Location = new System.Drawing.Point(4, 84);
			this.pnlFrom.Name = "pnlFrom";
			this.pnlFrom.Size = new System.Drawing.Size(233, 40);
			this.pnlFrom.TabIndex = 12;
			this.pnlFrom.OnTextChangedEvent += new System.EventHandler(this.pnlFrom_OnTextChangedEvent);
			// 
			// btnBack
			// 
			this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(4, 176);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(72, 20);
			this.btnBack.TabIndex = 16;
			this.btnBack.Text = "Back";
			// 
			// MultiplePlaces
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 294);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.pnlTo);
			this.Controls.Add(this.pnlFrom);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.lblTransport);
			this.Controls.Add(this.lblMessage);
			this.Name = "MultiplePlaces";
			this.Text = "MultiplePlaces";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTransport;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Label lblMessage;
		public MulitiplePlacePanel pnlFrom;
		public MulitiplePlacePanel pnlTo;
		private System.Windows.Forms.Button btnBack;

	}
}