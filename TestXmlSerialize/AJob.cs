using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestXmlSerialize
{
    public partial class AJob : UserControl
    {
        private PlanItem _Job;

        public PlanItem Job
        {
            get { return _Job; }
            set { _Job = value; }
        }

        #region // Event
        private event EventHandler _SaveJob;
        public event EventHandler SaveJob
        {
            add
            {
                _SaveJob += value;
            }
            remove
            {
                _SaveJob -= value;
            }
        }

        private event EventHandler _DeleteJob;
        public event EventHandler DeleteJob
        {
            add
            {
                _DeleteJob += value;
            }
            remove
            {
                _DeleteJob -= value;
            }
        }
        #endregion
        public AJob(PlanItem jobParameter)
        {
            InitializeComponent();

            this.Job = jobParameter;

            ShowInfo();
        }
        void ShowInfo()
        {   
            txbJob.Text = Job.Job;
            txbStatus.Text = Job.Status;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _DeleteJob?.Invoke(this, new EventArgs());
        }

        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            this.Job.Job = txbJob.Text;
            this.Job.Status = txbStatus.Text;
            _SaveJob?.Invoke(this, new EventArgs());
        }
    }
}
