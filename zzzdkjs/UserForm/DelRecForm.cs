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
            textBoxCrossName.Text = fiberrec.RoadCross;
            textBoxFiberTail.Text = fiberrec.FiberPigtail;
            //textBoxLocof11floor.Text = fiberrec.DetachmentLocationA;
            textBoxLocof12floor.Text = fiberrec.DetachmentLocationB;
            switch (fiberrec.TeleOperator)
            {
                case "电信":
                    comboBoxOperator.SelectedIndex = 0;
                    break;
                case "联通":
                    comboBoxOperator.SelectedIndex = 1;
                    break;
                case "移动":
                    comboBoxOperator.SelectedIndex = 2;
                    break;
                case "中信":
                    comboBoxOperator.SelectedIndex = 3;
                    break;
            }

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
