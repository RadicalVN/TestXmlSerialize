using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TestXmlSerialize
{
    public partial class FrmMain : Form
    {
        #region // Property

        private string filePath = "data.xml";

        private PlanData _Data;

        public PlanData Data { get => _Data; set => _Data = value; }

        #endregion
        public FrmMain()
        {
            InitializeComponent();

            try
            {
                Data = DeserializeAllDataFromXML(filePath) as PlanData;
            }
            catch
            {
                MessageBox.Show("Load data is erorr!" + "\n" + "Đóng chương trình sau đó kiểm tra lại data hoặc tiến trình load data");
                
                // Set default Data when (Data == null)
                //SetDefaultJob();
            }
        }

        #region // Method of UserDefine
        /// <summary>
        /// Clear file xml và Lưu toàn bộ data mới xuống lại file xml
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        void SerializeAllDataToXML(object data, string filePath)
        {
            // Mở file đồng thời làm rỗng file (FileMode.Truncate = làm rỗng file trước khi ghi xuống)
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            
            // Ghi data mới
            sr.Serialize(fs, data);
            fs.Close();
        }

        /// <summary>
        /// Load tất cả data từ file xml lên sau đó chuyển sang dạng data PlanData.
        /// PlanData là cấu trúc dữ liệu được thiết kế phù hợp với cấu trúc dữ liệu trong file xml.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private object DeserializeAllDataFromXML(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                try
                {
                    #region // Note for create Object XmlSerializer and method (Serialize and Deserialize)
                    // Tạo mới một đối tượng kiểu XmlSerializer ()
                    // Với hàm khởi tạo, trả về một đối tượng có thể serialize thành file XML hoặc Deserialize

                    // Phương thức Deserialize(); Lấy dữ liệu trong file xml (theo liên kết được tạo - FileStream (fs))
                    // Chuyển thành PlanData (theo cấu trúc dữ liệu đã thiết kế trước để sử dụng trong chương trình - sourcecode) 
                    // Và return về Data dạng (cấu trúc dữ liệu) PlanData

                    // Phương thức Serialize(); ngược lại với Deserialize();
                    // Lấy dữ liệu từ chương trình từ dạng (cấu trúc dữ liệu) PlanData
                    // Lưu xuống file xml theo định dạng XML
                    #endregion
                    XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                    try
                    {
                        object result = sr.Deserialize(fs);
                        fs.Close();

                        // result.Tostring(); ==> ProjectName.PlanData
                        MessageBox.Show("Đã load được data: " + result.ToString());
                        return result;
                    }
                    catch
                    {
                        fs.Close();
                        MessageBox.Show("Lỗi tại phương thức Deserialize, không chuyển được từ file XML sang PlanData\n" + sr.Deserialize(fs).ToString());
                        return Data;
                    }

                }
                catch
                {
                    fs.Close();

                    // Khởi tạo và chạy Form xử lý khi dữ liệu hoàn toàn rỗng (formatted)
                    frmHandlingDataIsNull fr = new frmHandlingDataIsNull(this.Data);
                    // Ủy thác event
                    fr.SetDefaultJob += Fr_SetDefaultJob;
                    fr.ShowDialog();
                    return Data;
                }
            }
            catch
            {
                MessageBox.Show("Không tạo được kết nối tới file xml");
                return Data;
            }
        }

        private void Fr_SetDefaultJob(object sender, EventArgs e)
        {
            SetDefaultJob();
            //SerializeAllDataToXML(Data,filePath);
        }

        void SetDefaultJob()
        {
            Data = new PlanData();
            Data.JobData = new List<PlanItem>();
            Data.JobData.Add(new PlanItem()
            {
                ID = "JOB",
                Job = "Công việc mặc định",
                Status = "DONE"
            });
        }

        #endregion

        #region // Method of handling the Event
        private void btnDate_Click(object sender, EventArgs e)
        {
            FrmDailyPlan daily = new FrmDailyPlan(Data);
            daily.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeAllDataToXML(Data, filePath);
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            Data.JobData.RemoveAll(p => p.ID == "JOB");
        }
        #endregion
    }
}
