using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExcelParseNS;
using IDataParseNS;

namespace zzzdkjs.UserForm
{
    public partial class RecSerachForm : Form
    {
        private IDataParse DataParse;
        private Form1 Mainform;
        public RecSerachForm()
        {
            InitializeComponent();
        }

        public RecSerachForm(Form1 form1)
        {
            InitializeComponent();
            Mainform = form1;
            DataParse = Mainform.DataParse;
            // 初始化路口名和路段名

            List<string> roadcrossnamelist = DataParse.GetDataStatisticsByRoadCrossName();
            for (int i = 0; i < roadcrossnamelist.Count; i++)
            {
                comboBoxCrossName.Items.Add(roadcrossnamelist[i]);
            }

            for (int i = 0; i < roadcrossnamelist.Count; i++)
            {
                comboBoxRoadName.Items.Add(roadcrossnamelist[i]);
            }

            if (roadcrossnamelist.Count >0)
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
            List<string> roadcrossnamelist = DataParse.GetDataStatisticsByRoadCrossName();
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
                if (roadcrossnamelist.Contains(str))
                {
                    
                }
            }

            // 查询路口
            if (radioButtonCrossHand.Checked || radioButtonCrossAuto.Checked)
            {
                if (roadcrossnamelist.Contains(str))
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
