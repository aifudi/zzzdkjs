using System;
using System.Windows.Forms;
using ExcelParseNS;

namespace zzzdkjs.UserForm
{
    public partial class RecSerachForm : Form
    {
        private ExcelParse excelParse;
        private Form1 Mainform;
        public RecSerachForm()
        {
            InitializeComponent();
        }

        public RecSerachForm(Form1 form1)
        {
            InitializeComponent();
            Mainform = form1;
            excelParse = Mainform.excelParse;
            // 初始化路口名和路段名

            for (int i = 0; i < excelParse.roadnamelist.Count; i++)
            {
                comboBoxCrossName.Items.Add(excelParse.roadnamelist[i]);
            }

            for (int i = 0; i < excelParse.roadnamelist.Count; i++)
            {
                comboBoxRoadName.Items.Add(excelParse.roadnamelist[i]);
            }

            if (excelParse.roadnamelist.Count >0)
            {
                comboBoxCrossName.SelectedIndex = 0;
            }

            
        }

        /// <summary>
        /// 根据查询条件，返回查询结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string str = String.Empty;
            if (radioButtonRoadAuto.Checked)
            {
                str = comboBoxRoadName.Items[comboBoxRoadName.SelectedIndex].ToString();
      
            }

            if (radioButtonCrossAuto.Checked)
            {
                str = comboBoxRoadName.Items[comboBoxCrossName.SelectedIndex].ToString();
            }

            if (radioButtonCrossHand.Checked)
            {
                str = textBoxCrossName.Text;
            }

            if (radioButtonRoadHand.Checked)
            {
                str = textBoxRoadName.Text;
            }

            if (str == string.Empty)
            {
                MessageBox.Show("请输入需要查询的路口名或路段名");
                return;
            }

            // 查询路段
            if (radioButtonRoadAuto.Checked || radioButtonRoadHand.Checked)
            {
                if (excelParse.roadnamelist.Contains(str))
                {
                    
                }
            }

            // 查询路口
            if (radioButtonCrossHand.Checked || radioButtonCrossAuto.Checked)
            {
                if (excelParse.crossnamelist.Contains(str))
                {
                   
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonCrossAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCrossAuto.Checked)
            {
                radioButtonRoadAuto.Checked = false;
                radioButtonRoadHand.Checked = false;
            }
        }

        private void radioButtonCrossHand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCrossHand.Checked)
            {
                radioButtonRoadAuto.Checked = false;
                radioButtonRoadHand.Checked = false;
            }
        }

        private void radioButtonRoadAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRoadAuto.Checked)
            {
                radioButtonCrossAuto.Checked = false;
                radioButtonCrossHand.Checked = false;
            }
        }

        private void radioButtonRoadHand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRoadHand.Checked)
            {
                radioButtonCrossAuto.Checked = false;
                radioButtonCrossHand.Checked = false;
            }
        }

        /// <summary>
        /// 取消编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
     　　　this.Close();
        }
    }
}
