namespace Janda
{
	partial class MulitiplePlacePanel
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
			this.lblCaption = new System.Windows.Forms.Label();
			this.cbxPlace = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblCaption
			// 
			this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.lblCaption.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCaption.Location = new System.Drawing.Point(0, 0);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(189, 18);
			// 
			// cbxPlace
			// 
			this.cbxPlace.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbxPlace.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.cbxPlace.Location = new System.Drawing.Point(0, 18);
			this.cbxPlace.Name = "cbxPlace";
			this.cbxPlace.Size = new System.Drawing.Size(189, 20);
			this.cbxPlace.TabIndex = 6;
			this.cbxPlace.TextChanged += new System.EventHandler(this.cbxPlace_TextChanged);
			// 
			// MulitiplePlacePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.cbxPlace);
			this.Controls.Add(this.lblCaption);
			this.Name = "MulitiplePlacePanel";
			this.Size = new System.Drawing.Size(189, 40);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblCaption;
		private System.Windows.Forms.ComboBox cbxPlace;
	}
}
