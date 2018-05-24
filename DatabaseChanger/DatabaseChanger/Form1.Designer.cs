namespace DatabaseChanger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboUUID = new System.Windows.Forms.ComboBox();
            this.cboDatacenter = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboUUID
            // 
            this.cboUUID.FormattingEnabled = true;
            this.cboUUID.Location = new System.Drawing.Point(12, 12);
            this.cboUUID.Name = "cboUUID";
            this.cboUUID.Size = new System.Drawing.Size(340, 21);
            this.cboUUID.TabIndex = 1;
            // 
            // cboDatacenter
            // 
            this.cboDatacenter.FormattingEnabled = true;
            this.cboDatacenter.Location = new System.Drawing.Point(372, 12);
            this.cboDatacenter.Name = "cboDatacenter";
            this.cboDatacenter.Size = new System.Drawing.Size(121, 21);
            this.cboDatacenter.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(514, 10);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 57);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cboDatacenter);
            this.Controls.Add(this.cboUUID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Change Datacenter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUUID;
        private System.Windows.Forms.ComboBox cboDatacenter;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblStatus;
    }
}

