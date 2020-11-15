using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXmlSerialize
{
    [Serializable]
    public class PlanData
    {
        List<PlanItem> _JobData;
        /// <summary>
        /// Danh sách công việc
        /// </summary>
        public List<PlanItem> JobData { get => _JobData; set => _JobData = value; }
    }
}
