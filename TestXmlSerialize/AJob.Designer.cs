namespace TestXmlSerialize
{
    partial class AJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveJob);
            this.panel1.Controls.Add(this.txbStatus);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txbJob);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 27);
            this.panel1.TabIndex = 0;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(169, 3);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(53, 20);
            this.txbStatus.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(3, 3);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(160, 20);
            this.txbJob.TabIndex = 0;
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Location = new System.Drawing.Point(228, 1);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(36, 23);
            this.btnSaveJob.TabIndex = 3;
            this.btnSaveJob.Text = "Lưu";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(315, 34);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Button btnSaveJob;
    }
}
