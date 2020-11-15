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
    public partial class frmHandlingDataIsNull : Form
    {
        #region // Property
        private PlanData _Data;
        public PlanData Data { get => _Data; set => _Data = value; }
        #endregion

        #region // Event
        private event EventHandler _SetDefaultJob;
        public event EventHandler SetDefaultJob
        {
            add
            {
                _SetDefaultJob += value;
            }
            remove
            {
                _SetDefaultJob -= value;
            }
        }
        #endregion
        public frmHandlingDataIsNull(PlanData data)
        {
            InitializeComponent();
            this.Data = data;
        }

        private void btnAddDefaulJob_Click(object sender, EventArgs e)
        {
            this.Close();
            _SetDefaultJob?.Invoke(this, new EventArgs());
        }
    }
}
