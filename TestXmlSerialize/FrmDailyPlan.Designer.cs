namespace TestXmlSerialize
{
    partial class FrmDailyPlan
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
            this.pnlJob = new System.Windows.Forms.Panel();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlJob
            // 
            this.pnlJob.AutoScroll = true;
            this.pnlJob.Location = new System.Drawing.Point(12, 32);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(344, 287);
            this.pnlJob.TabIndex = 0;
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(13, 3);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 1;
            this.btnAddJob.Text = "Thêm việc";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // FrmDailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 331);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.pnlJob);
            this.Name = "FrmDailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Daily Plan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.Button btnAddJob;
    }
}