using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXmlSerialize
{
    public class PlanItem
    {
        public string ID = "JOB";
        private string _job;
        /// <summary>
        /// Nội dung công việc
        /// </summary>
        public string Job { get => _job; set => _job = value; }

        private string _Status;
        /// <summary>
        /// Trạng thái công việc: DONE hoặc DOING
        /// </summary>
        public string Status { get => _Status; set => _Status = value; }
    }
}
