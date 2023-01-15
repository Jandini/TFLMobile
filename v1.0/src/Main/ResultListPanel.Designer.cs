namespace Janda
{
	partial class ResultListPanel
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
			this.resultListItem1 = new Janda.ResultListItem();
			this.resultListItem2 = new Janda.ResultListItem();
			this.resultListItem3 = new Janda.ResultListItem();
			this.SuspendLayout();
			// 
			// resultListItem1
			// 
			this.resultListItem1.Location = new System.Drawing.Point(3, 3);
			this.resultListItem1.Name = "resultListItem1";
			this.resultListItem1.Size = new System.Drawing.Size(254, 51);
			this.resultListItem1.TabIndex = 0;
			// 
			// resultListItem2
			// 
			this.resultListItem2.Location = new System.Drawing.Point(3, 60);
			this.resultListItem2.Name = "resultListItem2";
			this.resultListItem2.Size = new System.Drawing.Size(254, 51);
			this.resultListItem2.TabIndex = 1;
			// 
			// resultListItem3
			// 
			this.resultListItem3.Location = new System.Drawing.Point(3, 117);
			this.resultListItem3.Name = "resultListItem3";
			this.resultListItem3.Size = new System.Drawing.Size(254, 51);
			this.resultListItem3.TabIndex = 2;
			// 
			// ResultListPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(240, 320);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.resultListItem3);
			this.Controls.Add(this.resultListItem2);
			this.Controls.Add(this.resultListItem1);
			this.Name = "ResultListPanel";
			this.Size = new System.Drawing.Size(338, 283);
			this.ResumeLayout(false);

		}

		#endregion

		private ResultListItem resultListItem1;
		private ResultListItem resultListItem2;
		private ResultListItem resultListItem3;

	}
}
