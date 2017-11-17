using System;
using System.Windows.Forms;
using FiberRecordNS;
using Delegate = DelegateNS.Delegate;

namespace zzzdkjs.UserForm
{
    public partial class EditRecForm : Form
    {
        public EditRecForm(FiberRecord rec)
        {
            InitializeComponent();
            fiberrec = rec;
            CtrlInit();
        }

        public event Delegate.EditFiberRecHandle EditFiberRec;

        private FiberRecord fiberrec;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            FiberRecord rec = GetEditedRec();
            EditFiberRec(rec);//执行委托实例
        }

        private void button2_Click(object sender, EventArgs e)
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
            textBoxLocof11floor.Text = fiberrec.DetachmentLocationA;
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

            if (string.Compare(fiberrec.IntranetUsed,"有")==0)
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


            //遍历Form上的所有控件  
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.Enabled = false;
            }

            button3.Enabled = true;
        }

        /// <summary>
        /// 得到编辑后的光纤记录值
        /// </summary>
        /// <returns></returns>
        private FiberRecord GetEditedRec()
        {
            FiberRecord rec = new FiberRecord();
            rec.FiberPigtail = textBoxFiberTail.Text;
            rec.TeleOperator = comboBoxOperator.Items[comboBoxOperator.SelectedIndex].ToString();

            return rec;

        }


        /// <summary>
        /// 启动编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text =="停止编辑")
            {
                button3.Text = "启动编辑";
                //遍历Form上的所有控件  
                foreach (System.Windows.Forms.Control control in this.Controls)
                {
                    control.Enabled = false;
                }
                button3.Enabled = true;
            }
            else
            {
                button3.Text = "停止编辑";
                //遍历Form上的所有控件  
                foreach (System.Windows.Forms.Control control in this.Controls)
                {
                    control.Enabled = true;
                }
            }

        }
    }
}
