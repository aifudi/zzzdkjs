using DelegateNS;
using FiberRecordNS;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace zzzdkjs.UserForm
{
    public partial class DelRecForm : Form
    {

        public event Delegate.DelFiberRecHandle DelFiberRec;

        private FiberRecord fiberrec;

        public DelRecForm(FiberRecord rec)
        {
            InitializeComponent();
            fiberrec = rec;
            CtrlInit();
        }


        /// <summary>
        /// 删除光纤记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            fiberrec.EditFlag = 0x01;
            DelFiberRec(fiberrec);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 主界面控件初始化
        /// </summary>
        private void CtrlInit()
        {
            textBoxCrossName.Text = fiberrec.roadcrossinfo.RoadCrossname;
            textBoxFiberTail.Text = fiberrec.FiberPigtail;

            //textBoxLocof11floor.Text = fiberrec.DetachmentLocationA;
            string[] strs = new string[4];
            if (fiberrec.DetachmentLocationA.Contains("-"))
            {
                strs = fiberrec.DetachmentLocationA.Split('-');
            }
            if (fiberrec.DetachmentLocationA.Contains("-"))
            {
                strs = fiberrec.DetachmentLocationA.Split('-');
            }

            comboBoxJiGui.SelectedItem = strs[0];
            comboBoxKuangJia.SelectedItem = strs[1];
            comboBoxPanHao.SelectedItem = strs[2];
            comboBoxXuHao.SelectedItem = strs[3];

            textBoxLocof12floor.Text = fiberrec.DetachmentLocationB;
            comboBoxOperator.SelectedItem = fiberrec.TeleOperator;
            
            checkBoxzdnw.Checked = string.Compare(fiberrec.IntranetUsed, "有") == 0;
            checkBoxdj.Checked = string.Compare(fiberrec.EPoliceUsed, "有") == 0;
            checkBoxxhj.Checked = string.Compare(fiberrec.SignalUsed, "有") == 0;
            checkBoxkk.Checked = string.Compare(fiberrec.BayonetUsed, "有") == 0;
            checkBoxspzw.Checked = string.Compare(fiberrec.VideoUsed, "有") == 0;
            checkBoxdsjk.Checked = string.Compare(fiberrec.MonitorUsed, "有") == 0;
            checkBoxjtyd.Checked = string.Compare(fiberrec.TrafficGuidanceUsed, "有") == 0;
        }
    }
}
