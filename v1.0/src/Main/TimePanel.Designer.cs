namespace Janda
{
	partial class TimePanel
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
			this.rbtArrive = new System.Windows.Forms.RadioButton();
			this.rbtDepart = new System.Windows.Forms.RadioButton();
			this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
			this.lblNeed = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rbtArrive
			// 
			this.rbtArrive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.rbtArrive.Location = new System.Drawing.Point(119, -1);
			this.rbtArrive.Name = "rbtArrive";
			this.rbtArrive.Size = new System.Drawing.Size(62, 20);
			this.rbtArrive.TabIndex = 52;
			this.rbtArrive.TabStop = false;
			this.rbtArrive.Text = "arrive";
			// 
			// rbtDepart
			// 
			this.rbtDepart.Checked = true;
			this.rbtDepart.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.rbtDepart.Location = new System.Drawing.Point(57, -1);
			this.rbtDepart.Name = "rbtDepart";
			this.rbtDepart.Size = new System.Drawing.Size(62, 20);
			this.rbtDepart.TabIndex = 51;
			this.rbtDepart.Text = "depart";
			// 
			// dtpDateTime
			// 
			this.dtpDateTime.CustomFormat = "\'on\' dd/mm/yyyy \'at\' hh:mm \'hours\'";
			this.dtpDateTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTime.Location = new System.Drawing.Point(0, 20);
			this.dtpDateTime.Name = "dtpDateTime";
			this.dtpDateTime.Size = new System.Drawing.Size(234, 20);
			this.dtpDateTime.TabIndex = 50;
			// 
			// lblNeed
			// 
			this.lblNeed.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.lblNeed.Location = new System.Drawing.Point(3, 2);
			this.lblNeed.Name = "lblNeed";
			this.lblNeed.Size = new System.Drawing.Size(48, 18);
			this.lblNeed.Text = "I need to";
			// 
			// TimePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.rbtArrive);
			this.Controls.Add(this.rbtDepart);
			this.Controls.Add(this.dtpDateTime);
			this.Controls.Add(this.lblNeed);
			this.Name = "TimePanel";
			this.Size = new System.Drawing.Size(235, 40);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton rbtArrive;
		private System.Windows.Forms.RadioButton rbtDepart;
		private System.Windows.Forms.DateTimePicker dtpDateTime;
		private System.Windows.Forms.Label lblNeed;
	}
}
