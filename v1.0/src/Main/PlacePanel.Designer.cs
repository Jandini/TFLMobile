namespace Janda
{
    partial class PlacePanel
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
			  this.rbtPlace = new System.Windows.Forms.RadioButton();
			  this.rbtAddress = new System.Windows.Forms.RadioButton();
			  this.rbtPostcode = new System.Windows.Forms.RadioButton();
			  this.rbtStation = new System.Windows.Forms.RadioButton();
			  this.cbxPlace = new System.Windows.Forms.ComboBox();
			  this.pnlInput = new Microsoft.WindowsCE.Forms.InputPanel();
			  this.SuspendLayout();
			  // 
			  // rbtPlace
			  // 
			  this.rbtPlace.Location = new System.Drawing.Point(0, 82);
			  this.rbtPlace.Name = "rbtPlace";
			  this.rbtPlace.Size = new System.Drawing.Size(114, 20);
			  this.rbtPlace.TabIndex = 4;
			  this.rbtPlace.TabStop = false;
			  this.rbtPlace.Text = "Place of interest";
			  // 
			  // rbtAddress
			  // 
			  this.rbtAddress.Location = new System.Drawing.Point(0, 64);
			  this.rbtAddress.Name = "rbtAddress";
			  this.rbtAddress.Size = new System.Drawing.Size(114, 20);
			  this.rbtAddress.TabIndex = 3;
			  this.rbtAddress.TabStop = false;
			  this.rbtAddress.Text = "Address";
			  // 
			  // rbtPostcode
			  // 
			  this.rbtPostcode.Location = new System.Drawing.Point(0, 46);
			  this.rbtPostcode.Name = "rbtPostcode";
			  this.rbtPostcode.Size = new System.Drawing.Size(114, 20);
			  this.rbtPostcode.TabIndex = 2;
			  this.rbtPostcode.TabStop = false;
			  this.rbtPostcode.Text = "Postcode";
			  // 
			  // rbtStation
			  // 
			  this.rbtStation.Checked = true;
			  this.rbtStation.Location = new System.Drawing.Point(0, 28);
			  this.rbtStation.Name = "rbtStation";
			  this.rbtStation.Size = new System.Drawing.Size(114, 20);
			  this.rbtStation.TabIndex = 1;
			  this.rbtStation.Text = "Station or stop";
			  // 
			  // cbxPlace
			  // 
			  this.cbxPlace.Dock = System.Windows.Forms.DockStyle.Top;
			  this.cbxPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			  this.cbxPlace.Location = new System.Drawing.Point(0, 0);
			  this.cbxPlace.Name = "cbxPlace";
			  this.cbxPlace.Size = new System.Drawing.Size(122, 22);
			  this.cbxPlace.TabIndex = 0;
			  this.cbxPlace.LostFocus += new System.EventHandler(this.cbxPlace_LostFocus);
			  this.cbxPlace.GotFocus += new System.EventHandler(this.cbxPlace_GotFocus);
			  // 
			  // FromToPanel
			  // 
			  this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			  this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			  this.BackColor = System.Drawing.SystemColors.Window;
			  this.Controls.Add(this.rbtPlace);
			  this.Controls.Add(this.rbtAddress);
			  this.Controls.Add(this.rbtPostcode);
			  this.Controls.Add(this.rbtStation);
			  this.Controls.Add(this.cbxPlace);
			  this.Name = "FromToPanel";
			  this.Size = new System.Drawing.Size(122, 108);
			  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtPlace;
        private System.Windows.Forms.RadioButton rbtAddress;
        private System.Windows.Forms.RadioButton rbtPostcode;
        private System.Windows.Forms.RadioButton rbtStation;
        private System.Windows.Forms.ComboBox cbxPlace;
		 private Microsoft.WindowsCE.Forms.InputPanel pnlInput;
    }
}
