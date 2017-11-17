using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExcelParseNS;
using FiberRecordNS;
using zzzdkjs.UserForm;


/// <summary>
/// 光纤查询管理系统的主程序界面，在该窗体中调用其它类库
/// </summary>
namespace zzzdkjs
{
    public partial class Form1 : Form
    {
        // 程序启动路径
        private string applicationstartuppath;
        // 保存光纤记录的excel文件名称
        private string exceldatapath;
        // 当前Treeview控件中选中的节点
        private TreeNode currentselectednode;
        // 当前datagridview中选中的行
        private int currentselectdatagridviewrowindex;

        public ExcelParse excelParse;

        // 点击Datagridview时，选中的FiberRecord记录
        private FiberRecord selectedfiberRecord = new FiberRecord();
        public Form1()
        {
            InitializeComponent();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 控件初始化
        /// </summary>
        private void ControlInit()
        {

            #region Form主窗体的控件缓冲设置
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //UpdateStatus.Continue;  
            UpdateStyles();
            #endregion

            #region TreeView控件初始化,
            /// 找到"路口位置"节点，并进行“路口位置”子节点的初始化
            TreeNode LocationNode = FindTreeNode("路口位置");
            for (int i = 0; i < excelParse.roadnamelist.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = excelParse.roadnamelist[i];
                LocationNode.Nodes.Add(node);
            }

            //            /// 找到"运营商"节点，并进行“运营商”子节点的初始化
            //            TreeNode OperatorNode = FindTreeNode("运营商");
            //            for (int i = 0; i < 2; i++)
            //            {
            //                TreeNode node = new TreeNode();
            //                OperatorNode.Nodes.Add(node);
            //            }
            //
            //            /// 找到"业务使用"节点，并进行“业务使用”子节点的初始化
            //            TreeNode UseTypeNode = FindTreeNode("业务使用");
            //            for (int i = 0; i < 2; i++)
            //            {
            //                TreeNode node = new TreeNode();
            //                UseTypeNode.Nodes.Add(node);
            //            }
            currentselectednode = treeView1.TopNode;
            #endregion


            /// TreeNode的所有节点目录都全部展开
            treeView1.ExpandAll();


            #region 初始化Datagridview
            /// 首先向Datagridview控件中添加数据列，利用反射获取fiberrecord的属性值
            dataGridView1.Font = new Font("宋体", 12);
            dataGridView1.Columns["ColumnFiberPigtail"].Width = 100;
            dataGridView1.Columns["ColumnTeleOperator"].Width = 100;
            dataGridView1.Columns["ColumnRoadIntersection"].Width = 200;
            dataGridView1.Columns["ColumnBayonetUsed"].Width = 85;
            dataGridView1.Columns["ColumnMonitorUsed"].Width = 100;

            dataGridView1.Columns["ColumnVideoUsed"].Width = 85;
            dataGridView1.Columns["ColumnSignalUsed"].Width = 85;
            dataGridView1.Columns["ColumnTrafficGuidanceUsed"].Width = 100;
            dataGridView1.Columns["ColumnEPoliceUsed"].Width = 85;
            dataGridView1.Columns["ColumnIntranetUsed"].Width = 100;
            dataGridView1.Columns["ColumnDetachmentLocationA"].Width = 90;
            dataGridView1.Columns["ColumnDetachmentLocationB"].Width = 90;
            dataGridView1.Columns["ColumnFiberPlugType"].Width = 100;



            // 设置列居中
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < excelParse.fiberrecords.Count; i++)
            {
                int index = this.dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells["ColumnFiberPigtail"].Value = excelParse.fiberrecords[i].FiberPigtail;
                dataGridView1.Rows[index].Cells["ColumnTeleOperator"].Value = excelParse.fiberrecords[i].TeleOperator;
                dataGridView1.Rows[index].Cells["ColumnRoadIntersection"].Value = excelParse.fiberrecords[i].RoadCross;
                dataGridView1.Rows[index].Cells["ColumnBayonetUsed"].Value = excelParse.fiberrecords[i].BayonetUsed;
                dataGridView1.Rows[index].Cells["ColumnVideoUsed"].Value = excelParse.fiberrecords[i].VideoUsed;
                dataGridView1.Rows[index].Cells["ColumnSignalUsed"].Value = excelParse.fiberrecords[i].SignalUsed;
                dataGridView1.Rows[index].Cells["ColumnTrafficGuidanceUsed"].Value = excelParse.fiberrecords[i].TrafficGuidanceUsed;
                dataGridView1.Rows[index].Cells["ColumnEPoliceUsed"].Value = excelParse.fiberrecords[i].EPoliceUsed;
                dataGridView1.Rows[index].Cells["ColumnMonitorUsed"].Value = excelParse.fiberrecords[i].MonitorUsed;
                dataGridView1.Rows[index].Cells["ColumnIntranetUsed"].Value = excelParse.fiberrecords[i].IntranetUsed;
                dataGridView1.Rows[index].Cells["ColumnDetachmentLocationA"].Value = excelParse.fiberrecords[i].DetachmentLocationA;
                dataGridView1.Rows[index].Cells["ColumnDetachmentLocationB"].Value = excelParse.fiberrecords[i].DetachmentLocationB;
                dataGridView1.Rows[index].Cells["ColumnFiberPlugType"].Value = excelParse.fiberrecords[i].FiberPlugType;

            }


            #endregion
        }

        /// <summary>
        /// 在TreeView控件中查找名称为nodename的节点
        /// </summary>
        /// <param name="nodename"></param>
        /// <returns></returns>
        private TreeNode FindTreeNode(string nodename)
        {

            TreeNode node = new TreeNode();
            TreeNode root = treeView1.Nodes[0];
            for (int i = 0; i < root.Nodes.Count; i++)
            {
                if (string.Compare(nodename, root.Nodes[i].Text) == 0)
                {
                    node = root.Nodes[i];
                    break;
                }
            }
            return node;
        }

        public void xx()
        {
            List<FiberRecord> records = excelParse.GetDataFromExcelByCom(true);
            Dictionary<string, int> result = excelParse.GetDataStatisticsByTeleOperator(records);
            string[] x = result.Keys.ToArray();
            int[] y = result.Values.ToArray();
            #region 柱状图

            //标题
            cht1.Titles.Add("运营商光纤数据分析");
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
            cht1.ChartAreas[0].AxisY.Title = "光纤数量(条)";
            cht1.ChartAreas[0].AxisY.TitleFont = new Font("微软雅黑", 10f, FontStyle.Regular);
            cht1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            cht1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated270;
            cht1.ChartAreas[0].AxisY.ToolTip = "光纤数量(条)";
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
        /// 主程序窗体初始化操作，主要完成
        /// 1.光纤数据的解析
        /// 2.控件的初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            applicationstartuppath = Application.StartupPath;
            exceldatapath = applicationstartuppath + "\\FiberData.xls";
            excelParse = new ExcelParse(exceldatapath);
            ControlInit();
        }


        /// <summary>
        /// 测试按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (null == dataGridView1.Rows[i].Cells["ColumnTeleOperator"].Value)
                {
                    continue;
                }
                if (string.Compare(dataGridView1.Rows[i].Cells["ColumnTeleOperator"].Value.ToString(), "电信") == 0)
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }

            dataGridView1.Invalidate();
        }

        /// <summary>
        /// 点击TreeNode触发的响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodename = string.Empty;

            TreeNode node = e.Node;
            currentselectednode = e.Node;

            TreeNode parentnode = node.Parent;
            int index = 1;
            int tabindex = tabControl1.SelectedIndex;

            while (parentnode != null)
            {
                index++;
                parentnode = parentnode.Parent;
            }

            if (index == 1)
            {
                // 当前点击节点为顶级节点
            }

            if (index == 2)
            {
                string str = node.Name;
                string str2 = String.Empty;
                switch (str)
                {
                    case "RecSerach":
                        RecSerachForm recSerachForm = new RecSerachForm(this);
                        recSerachForm.ShowDialog();
                        break;
                    case "Operator":
                        if (tabindex == 0)
                        {
                            str2 = node.Nodes[0].Text;
                            ShowSelectrecbyOperator(str2);
                        }
                        if (tabindex == 1)
                        {
                            ShowGraphbyOperator();
                        }
                        break;

                    case "UsingType":
                        if (tabindex == 0)
                        {
                            str2 = node.Nodes[0].Text;
                            ShowSelectrecbyUsingType(str2);
                        }

                        if (tabindex == 1)
                        {

                        }

                        break;
                    case "CrossingLocation":
                        break;
                }

            }

            if (index == 3)
            {
                /// 当前点击节点为3级节点
                string str = node.Parent.Name;
                string str2 = node.Text;
                switch (str)
                {
                    // 显示指定运营商的光纤记录
                    case "Operator":

                        ShowSelectrecbyOperator(str2);
                        break;
                    case "UsingType":
                        ShowSelectrecbyUsingType(str2);
                        break;
                    case "CrossingLocation":
                        break;
                }
            }
        }



        /// <summary>
        /// 显示指定运营商的光纤记录
        /// </summary>
        private void ShowSelectrecbyOperator(string OperatorName)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Visible = false;
            }


            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (null == dataGridView1.Rows[i].Cells["ColumnTeleOperator"].Value)
                {
                    continue;
                }
                if (string.Compare(dataGridView1.Rows[i].Cells["ColumnTeleOperator"].Value.ToString(), OperatorName) == 0)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }

            dataGridView1.Invalidate();
        }

        /// <summary>
        /// 显示指定业务的光纤记录
        /// </summary>
        private void ShowSelectrecbyUsingType(string UsingTypeName)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Visible = false;
            }

            switch (UsingTypeName)
            {
                case "电视监视":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["ColumnMonitorUsed"].Value == null)
                        {
                            continue;
                        }

                        if (string.Compare(dataGridView1.Rows[i].Cells["ColumnMonitorUsed"].Value.ToString(), "有") == 0)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                    break;
                case "电警":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["ColumnEPoliceUsed"].Value == null)
                        {
                            continue;

                        }
                        if (string.Compare(dataGridView1.Rows[i].Cells["ColumnEPoliceUsed"].Value.ToString(), "有") == 0)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                    break;
                case "卡口":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["ColumnBayonetUsed"].Value == null)
                        {
                            continue;
                        }

                        if (string.Compare(dataGridView1.Rows[i].Cells["ColumnBayonetUsed"].Value.ToString(), "有") == 0)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                    break;
                case "信号机":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["ColumnSignalUsed"].Value == null)
                        {
                            continue;
                        }

                        if (string.Compare(dataGridView1.Rows[i].Cells["ColumnSignalUsed"].Value.ToString(), "有") == 0)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                    break;
                case "支队内网":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["ColumnIntranetUsed"].Value == null)
                        {
                            continue;
                        }

                        if (string.Compare(dataGridView1.Rows[i].Cells["ColumnIntranetUsed"].Value.ToString(), "有") == 0)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                    break;
                case "视频专网":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["ColumnVideoUsed"].Value == null)
                        {
                            continue;
                        }

                        if (string.Compare(dataGridView1.Rows[i].Cells["ColumnVideoUsed"].Value.ToString(), "有") == 0)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                    break;

            }

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                //                if (string.Compare(dataGridView1.Rows[i].Cells["ColumnTeleOperator"].Value.ToString(), UsingTypeName) == 0)
                //                {
                //                    dataGridView1.Rows[i].Visible = true;
                //                }
            }

            dataGridView1.Invalidate();
        }

        /// <summary>
        /// 显示不同运营商的占比图表
        /// </summary>
        private void ShowGraphbyOperator()
        {
            //string[] x = new string[] { "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", "大帝科技", "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", "大帝科技" };
            //double[] y = new double[] { 541, 574, 345, 854, 684, 257, 541, 574, 345, 854, 684, 257 };
            Dictionary<string, int> result = excelParse.numberofoperatordict;
            string[] x = result.Keys.ToArray();
            int[] y = result.Values.ToArray();

            #region 柱状图


            //标题
            cht1.Titles.Add("运营商光纤数据分析");
            cht1.Titles[0].ForeColor = Color.Red;
            cht1.Titles[0].Font = new Font("微软雅黑", 20f, FontStyle.Regular);
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
            cht1.ChartAreas[0].AxisX.TitleForeColor = Color.Blue;

            //X坐标轴颜色
            cht1.ChartAreas[0].AxisX.LineColor = ColorTranslator.FromHtml("#38587a"); ;
            cht1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            cht1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("微软雅黑", 10f, FontStyle.Regular);
            //X坐标轴标题
            cht1.ChartAreas[0].AxisX.Title = "数量(宗)";
            cht1.ChartAreas[0].AxisX.TitleFont = new Font("微软雅黑", 10f, FontStyle.Regular);
            cht1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            cht1.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
            cht1.ChartAreas[0].AxisX.ToolTip = "数量(宗)";
            //X轴网络线条
            cht1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            cht1.ChartAreas[0].AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            //Y坐标轴颜色
            cht1.ChartAreas[0].AxisY.LineColor = ColorTranslator.FromHtml("#38587a");
            cht1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            cht1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("微软雅黑", 10f, FontStyle.Regular);
            //Y坐标轴标题
            cht1.ChartAreas[0].AxisY.Title = "光纤数量(条)";
            cht1.ChartAreas[0].AxisY.TitleFont = new Font("微软雅黑", 10f, FontStyle.Regular);
            cht1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            cht1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated270;
            cht1.ChartAreas[0].AxisY.ToolTip = "光纤数量(条)";
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
        /// 显示不同业务使用的占比图表
        /// </summary>
        private void ShowGraphbyUsingType()
        {
            Dictionary<string, int> result = excelParse.numberofoperatordict;
            string[] x = result.Keys.ToArray();
            int[] y = result.Values.ToArray();

            #region 柱状图

            //标题
            cht1.Titles.Add("光纤使用用途数据分析");
            cht1.Titles[0].ForeColor = Color.Red;
            cht1.Titles[0].Font = new Font("微软雅黑", 20f, FontStyle.Regular);
            cht1.Titles[0].Alignment = ContentAlignment.TopCenter;
            //            cht1.Titles.Add("合计：25414 宗");
            //            cht1.Titles[1].ForeColor = Color.White;
            //            cht1.Titles[1].Font = new Font("微软雅黑", 8f, FontStyle.Regular);
            //            cht1.Titles[1].Alignment = ContentAlignment.TopRight;

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
            cht1.ChartAreas[0].AxisX.TitleForeColor = Color.Red;

            //X坐标轴颜色
            cht1.ChartAreas[0].AxisX.LineColor = ColorTranslator.FromHtml("#38587a"); ;
            cht1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            cht1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("微软雅黑", 10f, FontStyle.Regular);

            //X轴网络线条
            cht1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            cht1.ChartAreas[0].AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            //Y坐标轴颜色
            cht1.ChartAreas[0].AxisY.LineColor = ColorTranslator.FromHtml("#38587a");
            cht1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            cht1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("微软雅黑", 10f, FontStyle.Regular);
            //Y坐标轴标题
            cht1.ChartAreas[0].AxisY.Title = "光纤数量(条)";
            cht1.ChartAreas[0].AxisY.TitleFont = new Font("微软雅黑", 20f, FontStyle.Regular);
            cht1.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
            cht1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated270;
            cht1.ChartAreas[0].AxisY.ToolTip = "光纤数量(条)";
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
        /// 切换TAB标签页触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                TreeNode parentnode = currentselectednode.Parent;
                int index = 1;
                while (parentnode != null)
                {
                    index++;
                    parentnode = parentnode.Parent;
                }

                if (index == 1)
                {
                    // 当前点击节点为顶级节点
                }

                if (index == 2)
                {
                    // 当前点击的节点为二级节点
                    /// 当前点击节点为3级节点
                    string str2 = currentselectednode.Text;
                    switch (str2)
                    {
                        // 显示指定运营商的光纤记录
                        case "运营商":
                            ShowGraphbyOperator();
                            break;
                        case "业务使用":
                            ShowGraphbyUsingType();
                            break;
                    }

                }

                if (index == 3)
                {

                }
            }


        }

        /// <summary>
        /// 光纤记录操作选择对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.Rows[e.RowIndex].Cells["ColumnFiberPigtail"].Value.ToString();
            currentselectdatagridviewrowindex = e.RowIndex;
            if (str == null)
            {
                return;
            }


            foreach (FiberRecord rec in excelParse.fiberrecords)
            {
                if (string.Compare(str, rec.FiberPigtail) == 0)
                {
                    selectedfiberRecord = rec;
                    break;
                }
            }

            OPChooseForm opChooseForm = new OPChooseForm(selectedfiberRecord);
            opChooseForm.EditFiberRec += EditFiberRec;
            opChooseForm.AddFiberRec += AddFiberRec;
            opChooseForm.DelFiberRec += DelFiberRec;

            opChooseForm.ShowDialog();
        }

        /// <summary>
        /// 编辑光纤记录
        /// </summary>
        private void EditFiberRec(FiberRecord rec)
        {

            if (string.Compare(selectedfiberRecord.FiberPigtail, rec.FiberPigtail) != 0)
            {
                // 尾纤编号发生了更改，需要判断是否与当前记录存在冲突
                bool flag = false;
                for (int i = 0; i < excelParse.fiberrecords.Count; i++)
                {
                    if (string.Compare(rec.FiberPigtail, excelParse.fiberrecords[i].FiberPigtail) == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    MessageBox.Show("当前尾纤已存在，请更改！");
                    return;
                }

                else
                {
                    // 完成datagridview控件中的记录更改工作

                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnFiberPigtail"].Value = rec.FiberPigtail;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnTeleOperator"].Value = rec.TeleOperator;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnRoadIntersection"].Value = rec.RoadCross;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnBayonetUsed"].Value = rec.BayonetUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnVideoUsed"].Value = rec.VideoUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnSignalUsed"].Value = rec.SignalUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnTrafficGuidanceUsed"].Value = rec.TrafficGuidanceUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnEPoliceUsed"].Value = rec.EPoliceUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnMonitorUsed"].Value = rec.MonitorUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnIntranetUsed"].Value = rec.IntranetUsed;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnDetachmentLocationA"].Value = rec.DetachmentLocationA;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnDetachmentLocationB"].Value = rec.DetachmentLocationB;
                    dataGridView1.Rows[currentselectdatagridviewrowindex].Cells["ColumnFiberPlugType"].Value = rec.FiberPlugType;
                }
            }

            else
            {
                // 直接完成记录更改工作
            }
        }

        /// <summary>
        /// 增加光纤记录
        /// </summary>
        private void AddFiberRec(FiberRecord rec)
        {
            
            // 尾纤编号发生了更改，需要判断是否与当前记录存在冲突
            bool flag = false;
            for (int i = 0; i < excelParse.fiberrecords.Count; i++)
            {
                if (string.Compare(rec.FiberPigtail, excelParse.fiberrecords[i].FiberPigtail) == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("当前尾纤已存在，无法增加新的光纤记录，请更改！");
                return;
            }

            else
            {
                // 完成datagridview控件中的记录增加工作

                int index = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["ColumnFiberPigtail"].Value = rec.FiberPigtail;
                dataGridView1.Rows[index].Cells["ColumnTeleOperator"].Value = rec.TeleOperator;
                dataGridView1.Rows[index].Cells["ColumnRoadIntersection"].Value = rec.RoadCross;
                dataGridView1.Rows[index].Cells["ColumnBayonetUsed"].Value = rec.BayonetUsed;
                dataGridView1.Rows[index].Cells["ColumnVideoUsed"].Value = rec.VideoUsed;
                dataGridView1.Rows[index].Cells["ColumnSignalUsed"].Value = rec.SignalUsed;
                dataGridView1.Rows[index].Cells["ColumnTrafficGuidanceUsed"].Value = rec.TrafficGuidanceUsed;
                dataGridView1.Rows[index].Cells["ColumnEPoliceUsed"].Value = rec.EPoliceUsed;
                dataGridView1.Rows[index].Cells["ColumnMonitorUsed"].Value = rec.MonitorUsed;
                dataGridView1.Rows[index].Cells["ColumnIntranetUsed"].Value = rec.IntranetUsed;
                dataGridView1.Rows[index].Cells["ColumnDetachmentLocationA"].Value = rec.DetachmentLocationA;
                dataGridView1.Rows[index].Cells["ColumnDetachmentLocationB"].Value = rec.DetachmentLocationB;
                dataGridView1.Rows[index].Cells["ColumnFiberPlugType"].Value = rec.FiberPlugType;
            }



        }

        /// <summary>
        /// 删除光纤记录
        /// </summary>
        private void DelFiberRec(FiberRecord rec)
        {
            MessageBox.Show("delegate del test");
        }
    }
}
