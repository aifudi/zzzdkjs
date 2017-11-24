using DelegateNS;
using FiberRecordNS;
using System.Windows.Forms;

namespace zzzdkjs.UserForm
{
    public partial class AddrecForm : Form
    {

        public event Delegate.AddFiberRecHandle AddFiberRec;
        private FiberRecord fiberrec;

        public AddrecForm(FiberRecord rec)
        {
            InitializeComponent();
            fiberrec = rec;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            FiberRecord rec = GetEditedRec();
            AddFiberRec(rec);
        }

        /// <summary>
        /// 得到新增的光纤记录值
        /// </summary>
        /// <returns></returns>
        private FiberRecord GetEditedRec()
        {
            FiberRecord rec = new FiberRecord();

            rec.FiberPigtail = textBoxFiberTail.Text;
            rec.TeleOperator = comboBoxOperator.SelectedItem.ToString();
            rec.DetachmentLocationA = string.Concat(comboBoxJiGui.SelectedItem.ToString(), "-", comboBoxKuangJia.SelectedItem.ToString(), "-",
                comboBoxPanHao.SelectedItem.ToString(), "-", comboBoxXuHao.SelectedItem.ToString());
            rec.FiberPlugType = comboBoxFiberPlugType.SelectedItem.ToString();
            rec.DetachmentLocationB = textBoxLocof12floor.Text;
            rec.roadcrossinfo.RoadCrossname = textBoxCrossName.Text;

            rec.BayonetUsed = checkBoxkk.Checked ? "有" : "无";
            rec.VideoUsed = checkBoxspzw.Checked ? "有" : "无";
            rec.EPoliceUsed = checkBoxdj.Checked ? "有" : "无";
            rec.MonitorUsed = checkBoxdsjk.Checked ? "有" : "无";
            rec.IntranetUsed = checkBoxzdnw.Checked ? "有" : "无";
            rec.SignalUsed = checkBoxxhj.Checked ? "有" : "无";
            rec.TrafficGuidanceUsed = checkBoxjtyd.Checked ? "有" : "无";

            rec.EditFlag = 0x10;

            return rec;

        }


        /// <summary>
        /// 主界面控件初始化
        /// </summary>
        private void CtrlInit()
        {

        }
        }
}
