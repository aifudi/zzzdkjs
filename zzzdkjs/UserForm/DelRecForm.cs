using DelegateNS;
using FiberRecordNS;
using System.Windows.Forms;

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
            textBoxLocof12floor.Text = fiberrec.DetachmentLocationB;
            comboBoxOperator.SelectedItem = fiberrec.TeleOperator;
            
            if (string.Compare(fiberrec.IntranetUsed, "有") == 0)
            {

            }
            if (string.Compare(fiberrec.EPoliceUsed, "有") == 0)
            {
                checkBoxdj.Checked = true;
            }
            if (string.Compare(fiberrec.SignalUsed, "有") == 0)
            {
                checkBoxxhj.Checked = true;
            }
            if (string.Compare(fiberrec.BayonetUsed, "有") == 0)
            {
                checkBoxkk.Checked = true;
            }
            if (string.Compare(fiberrec.VideoUsed, "有") == 0)
            {
                checkBoxspzw.Checked = true;
            }
            if (string.Compare(fiberrec.MonitorUsed, "有") == 0)
            {

            }
        }
    }
}
