namespace TestXmlSerialize
{
    partial class frmHandlingDataIsNull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandlingDataIsNull));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseFormHandlingDataIsNull = new System.Windows.Forms.Button();
            this.btnAddDefaulJob = new System.Windows.Forms.Button();
            this.lblIfomationDataErorr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseFormHandlingDataIsNull);
            this.panel1.Controls.Add(this.btnAddDefaulJob);
            this.panel1.Controls.Add(this.lblIfomationDataErorr);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 169);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseFormHandlingDataIsNull
            // 
            this.btnCloseFormHandlingDataIsNull.Location = new System.Drawing.Point(15, 134);
            this.btnCloseFormHandlingDataIsNull.Name = "btnCloseFormHandlingDataIsNull";
            this.btnCloseFormHandlingDataIsNull.Size = new System.Drawing.Size(101, 23);
            this.btnCloseFormHandlingDataIsNull.TabIndex = 2;
            this.btnCloseFormHandlingDataIsNull.Text = "Close and fix bug";
            this.btnCloseFormHandlingDataIsNull.UseVisualStyleBackColor = true;
            // 
            // btnAddDefaulJob
            // 
            this.btnAddDefaulJob.Location = new System.Drawing.Point(229, 134);
            this.btnAddDefaulJob.Name = "btnAddDefaulJob";
            this.btnAddDefaulJob.Size = new System.Drawing.Size(97, 23);
            this.btnAddDefaulJob.TabIndex = 1;
            this.btnAddDefaulJob.Text = "Add Default Job";
            this.btnAddDefaulJob.UseVisualStyleBackColor = true;
            this.btnAddDefaulJob.Click += new System.EventHandler(this.btnAddDefaulJob_Click);
            // 
            // lblIfomationDataErorr
            // 
            this.lblIfomationDataErorr.AutoSize = true;
            this.lblIfomationDataErorr.Location = new System.Drawing.Point(12, 11);
            this.lblIfomationDataErorr.Name = "lblIfomationDataErorr";
            this.lblIfomationDataErorr.Size = new System.Drawing.Size(314, 78);
            this.lblIfomationDataErorr.TabIndex = 0;
            this.lblIfomationDataErorr.Text = resources.GetString("lblIfomationDataErorr.Text");
            // 
            // frmHandlingDataIsNull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 193);
            this.Controls.Add(this.panel1);
            this.Name = "frmHandlingDataIsNull";
            this.Text = "Xử lý lỗi khi gặp lỗi load data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIfomationDataErorr;
        private System.Windows.Forms.Button btnAddDefaulJob;
        private System.Windows.Forms.Button btnCloseFormHandlingDataIsNull;
    }
}