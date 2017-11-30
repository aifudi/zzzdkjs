using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExcelParseNS;
using FiberRecordNS;

namespace DllTest
{
    public partial class Form1 : Form
    {

        ExcelParse excelParse ;
        public Form1()
        {
            InitializeComponent();
            //string applicationstartuppath = Application.StartupPath;
            //string exceldatapath = applicationstartuppath + "\\FiberData.xls";
            //excelParse = new ExcelParse(exceldatapath);
        }


        /// <summary>
        /// 测试ExcelParse类是否可以正常工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            Dictionary<string,int> result = excelParse.GetDataStatisticsByTeleOperator();
        }

        /// <summary>
        /// 统计不同运营商承建的光纤线路数目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //string[] x = new string[] { "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", "大帝科技", "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", "大帝科技" };
            //double[] y = new double[] { 541, 574, 345, 854, 684, 257, 541, 574, 345, 854, 684, 257 };
            
            Dictionary<string, int> result = excelParse.GetDataStatisticsByTeleOperator();
            string[] x = result.Keys.ToArray();
            int[] y = result.Values.ToArray();
            #region 柱状图


            #endregion
        }

        /// <summary>
        /// 测试向excel文件中添加数据记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            FiberRecord rec = new FiberRecord();

            excelParse.AddNewRecord(rec);
        }

        /// <summary>
        /// 测试删除excel文件中的数据记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            FiberRecord record = new FiberRecord();
            record.FiberPigtail = "FC003";
            excelParse.DelRecord(record);
        }


        /// <summary>
        /// 根据不同的用途，对光纤记录进行分类的测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            FiberRecord record = new FiberRecord();
            record.FiberPigtail = "FC003";
            
            excelParse.GetDataStatisticsByUsing();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
