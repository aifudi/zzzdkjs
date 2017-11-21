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
            string applicationstartuppath = Application.StartupPath;
            string exceldatapath = applicationstartuppath + "\\FiberData.xls";
            excelParse = new ExcelParse(exceldatapath);
        }


        /// <summary>
        /// 测试ExcelParse类是否可以正常工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<FiberRecord> records = excelParse.GetFiberRecordsData(true);
            Dictionary<string,int> result = excelParse.GetDataStatisticsByTeleOperator(records);
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
            List<FiberRecord> records = excelParse.GetFiberRecordsData(true);
            Dictionary<string, int> result = excelParse.GetDataStatisticsByTeleOperator(records);
            string[] x = result.Keys.ToArray();
            int[] y = result.Values.ToArray();
            #region 柱状图

            //标题
            cht1.Titles.Add("柱状图数据分析");
            cht1.Titles[0].ForeColor = Color.Yellow;
            cht1.Titles[0].Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            cht1.Titles[0].Alignment = ContentAlignment.TopCenter;
            cht1.Titles.Add("合计：25414 宗");
            cht1.Titles[1].ForeColor = Color.White;
            cht1.Titles[1].Font = new Font("微软雅黑", 8f, FontStyle.Regular);
            cht1.Titles[1].Alignment = ContentAlignment.TopRight;

            //控件背景
            cht1.BackColor = Color.Transparent;
            //图表区背景
            cht1.ChartAreas[0].BackColor = Color.Transparent;
            cht1.ChartAreas[0].BorderColor = Color.Transparent;
            //X轴标签间距
            cht1.ChartAreas[0].AxisX.Interval = 1;
            cht1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
            cht1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            cht1.ChartAreas[0].AxisX.TitleFont = new Font("微软雅黑", 14f, FontStyle.Regular);
            cht1.ChartAreas[0].AxisX.TitleForeColor = Color.White;

            //X坐标轴颜色
            cht1.ChartAreas[0].AxisX.LineColor = ColorTranslator.FromHtml("#38587a"); ;
            cht1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            cht1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("微软雅黑", 10f, FontStyle.Regular);
            //X坐标轴标题
            //cht1.ChartAreas[0].AxisX.Title = "数量(宗)";
            //cht1.ChartAreas[0].AxisX.TitleFont = new Font("微软雅黑", 10f, FontStyle.Regular);
            //cht1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            //cht1.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
            //cht1.ChartAreas[0].AxisX.ToolTip = "数量(宗)";
            //X轴网络线条
            cht1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            cht1.ChartAreas[0].AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            //Y坐标轴颜色
            cht1.ChartAreas[0].AxisY.LineColor = ColorTranslator.FromHtml("#38587a");
            cht1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            cht1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("微软雅黑", 10f, FontStyle.Regular);
            //Y坐标轴标题
            cht1.ChartAreas[0].AxisY.Title = "数量(宗)";
            cht1.ChartAreas[0].AxisY.TitleFont = new Font("微软雅黑", 10f, FontStyle.Regular);
            cht1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            cht1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated270;
            cht1.ChartAreas[0].AxisY.ToolTip = "数量(宗)";
            //Y轴网格线条
            cht1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            cht1.ChartAreas[0].AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            cht1.ChartAreas[0].AxisY2.LineColor = Color.Transparent;
            cht1.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
            Legend legend = new Legend("legend");
            legend.Title = "legendTitle";

            cht1.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            cht1.Series[0].Label = "#VAL";                //设置显示X Y的值    
            cht1.Series[0].LabelForeColor = Color.White;
            cht1.Series[0].ToolTip = "#VALX:#VAL";     //鼠标移动到对应点显示数值
            cht1.Series[0].ChartType = SeriesChartType.Column;    //图类型(折线)


            cht1.Series[0].Color = Color.Lime;
            cht1.Series[0].LegendText = legend.Name;
            cht1.Series[0].IsValueShownAsLabel = true;
            cht1.Series[0].LabelForeColor = Color.White;
            cht1.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            cht1.Legends.Add(legend);
            cht1.Legends[0].Position.Auto = false;


            //绑定数据
            cht1.Series[0].Points.DataBindXY(x, y);
            cht1.Series[0].Points[0].Color = Color.White;
            cht1.Series[0].Palette = ChartColorPalette.Bright;

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
            List<FiberRecord> records = excelParse.GetFiberRecordsData(true);
            excelParse.GetDataStatisticsByUsing(records);
        }
    }
}
