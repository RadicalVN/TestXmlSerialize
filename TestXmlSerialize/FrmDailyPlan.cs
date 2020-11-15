using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestXmlSerialize
{
    public partial class FrmDailyPlan : Form
    {
        PlanData _JobByDay;
        public PlanData JobByDay { get => _JobByDay; set => _JobByDay = value; }
        FlowLayoutPanel fpnlPanel = new FlowLayoutPanel();
        public FrmDailyPlan(PlanData data)
        {
            InitializeComponent();
            
            this.JobByDay = data;

            fpnlPanel.Width = pnlJob.Width;
            fpnlPanel.Height = pnlJob.Height;
            fpnlPanel.AutoScroll = true;

            pnlJob.Controls.Add(fpnlPanel);
            ShowJob();

        }

        void ShowJob()
        {
            fpnlPanel.Controls.Clear();

            if (JobByDay != null && JobByDay.JobData != null)
            {
                List<PlanItem> todayJob = GetJob();
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
        }
        List<PlanItem> GetJob()
        {
            return JobByDay.JobData.Where(p => p.ID == "JOB").ToList();
        }
        void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.SaveJob += AJob_SaveJob;
            aJob.DeleteJob += AJob_DeleteJob;

            fpnlPanel.Controls.Add(aJob);
        }

        private void AJob_SaveJob(object sender, EventArgs e)
        {
            
        }

        private void AJob_DeleteJob(object sender, EventArgs e)
        {
            var itemToRemove = (sender as AJob).Job;
            JobByDay.JobData.Remove(itemToRemove);
            fpnlPanel.Controls.Remove(sender as AJob);
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            PlanItem JobNeedAdd = new PlanItem();
            // Thêm UserControl (AJob vào fpnlJob)
            AddJob(JobNeedAdd);

            // Thêm công việc (JobNeedAdd - PlanItem) vào data
            JobByDay.JobData.Add(JobNeedAdd);
        }
    }
}
