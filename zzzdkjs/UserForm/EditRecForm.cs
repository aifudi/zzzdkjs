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
            textBoxCrossName.Text = fiberrec.roadcrossinfo.RoadCrossname;
            textBoxFiberTail.Text = fiberrec.FiberPigtail;
            string str = fiberrec.DetachmentLocationA;
            string[] strs = new string[5];
            if (str.Contains("－"))
            {
                // 将远端地址拆分为两个路口
                strs = str.Split('－');
                comboBoxJiGui.SelectedItem = strs[0];
                comboBoxKuangJia.SelectedItem = strs[1];
                comboBoxPanHao.SelectedItem = strs[2];
                comboBoxXuHao.SelectedItem = strs[3];
            }

            if (str.Contains("-"))
            {
                // 将远端地址拆分为两个路口
                strs = str.Split('-');
                comboBoxJiGui.SelectedItem = strs[0];
                comboBoxKuangJia.SelectedItem = strs[1];
                comboBoxPanHao.SelectedItem = strs[2];
                comboBoxXuHao.SelectedItem = strs[3];
            }

            textBoxLocof12floor.Text = fiberrec.DetachmentLocationB;
            comboBoxFiberPlugType.SelectedItem = fiberrec.FiberPlugType;
            textBoxLocof12floor.Text = fiberrec.DetachmentLocationB;
            textBoxCrossName.Text = fiberrec.roadcrossinfo.RoadCrossname;
            comboBoxOperator.SelectedItem = fiberrec.TeleOperator;

            if (string.Compare(fiberrec.IntranetUsed, "有") == 0)
            {
                checkBoxzdnw.Checked = true;
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
                checkBoxdsjk.Checked = true;
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
            rec.EditFlag = 0x11;
            try
            {
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return rec;
        }

        /// <summary>
        /// 启动编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "停止编辑")
            {
                button3.Text = "启动编辑";
                EnableOrDisableCtrl(this, false);
                button3.Enabled = true;
            }
            else
            {
                button3.Text = "停止编辑";
                EnableOrDisableCtrl(this, true);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        private void EnableOrDisableCtrl(Control ctrl, bool flag)
        {
            if (flag)
            {
                foreach (System.Windows.Forms.Control control in ctrl.Controls)
                {
                    control.Enabled = true;
                    if (ctrl.Controls.Count > 0)
                    {
                        EnableOrDisableCtrl(control, true);
                    }
                }
            }

            else
            {
                foreach (System.Windows.Forms.Control control in ctrl.Controls)
                {
                    control.Enabled = false;
                    if (ctrl.Controls.Count > 0)
                    {
                        EnableOrDisableCtrl(control, false);
                    }
                }
            }

        }
    }
}
