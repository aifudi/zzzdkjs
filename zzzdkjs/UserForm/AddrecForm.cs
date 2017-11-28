using System;
using System.Reflection;
using FiberRecordNS;
using System.Windows.Forms;
using Delegate = DelegateNS.Delegate;

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
            CtrlInit();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            bool flag = true;
            FiberRecord rec = GetEditedRec(ref flag);
            if (flag)
            {
                AddFiberRec(rec);
            }
            else
            {
                MessageBox.Show("当前数据记录有误，请确认后再进行添加！");
            }

        }

        /// <summary>
        /// 得到新增的光纤记录值
        /// flag = true 当前的数据输入无误，可以进行光纤数据记录的增添
        /// flag = false 当前的数据格式有误，给出错误信息，无法进行正常的数据记录增添
        /// </summary>
        /// <returns></returns>
        private FiberRecord GetEditedRec(ref bool flag)
        {
            FiberRecord rec = new FiberRecord();

            try
            {
                rec.FiberPigtail = textBoxFiberTail.Text;
                rec.TeleOperator = comboBoxOperator.SelectedItem.ToString();
                rec.DetachmentLocationA = string.Concat(comboBoxJiGui.SelectedItem.ToString(), "-",
                    comboBoxKuangJia.SelectedItem.ToString(), "-",
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
                rec.roadcrossinfo.log = double.Parse(textBoxlog.Text);
                rec.roadcrossinfo.lat = double.Parse(textBoxlat.Text);

                rec.EditFlag = 0x10; // 新增光纤记录

                flag = CheckValid(rec);

            }
            catch (Exception e)
            {
                flag = false;
            }

            
            return rec;
        }


        /// <summary>
        /// 主界面控件初始化
        /// </summary>
        private void CtrlInit()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox tempComboBox = control as ComboBox;
                    tempComboBox.SelectedIndex = 0;
                    continue;
                }
            }
        }

        /// <summary>
        /// 判断新建的光纤数据记录是否有效
        /// </summary>
        /// <returns></returns>
        private bool CheckValid(FiberRecord rec)
        {
            bool flag = true;
            Type type = rec.GetType();
            //再用Type.GetProperties获得PropertyInfo[],然后就可以用foreach 遍历了
            foreach (PropertyInfo pi in type.GetProperties())
            {
                object value1 = pi.GetValue(rec, null); //用rec.GetValue获得值
                if (value1.GetType() == typeof(string))
                {
                    if (value1 == string.Empty)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }


        /// <summary>
        /// 取消新增光纤记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
