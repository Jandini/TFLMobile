namespace Janda
{
    partial class ResultsPanel
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
            this.components = new System.ComponentModel.Container();
            this.frmMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SuspendLayout();
            // 
            // frmMainBindingSource
            // 
            this.frmMainBindingSource.DataSource = typeof(Janda.frmMain);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.frmMainBindingSource;
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(264, 276);
            this.dataGrid1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Janda.frmMain);
            // 
            // ResultsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dataGrid1);
            this.Name = "ResultsPanel";
            this.Size = new System.Drawing.Size(264, 276);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource frmMainBindingSource;
    }
}
