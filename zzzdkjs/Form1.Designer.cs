namespace zzzdkjs
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("电信");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("联通");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("移动");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("中信");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("自建");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("运营商", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("电视监视");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("电警");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("卡口");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("信号机");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("支队内网");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("视频专网");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("业务使用", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("路口位置");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("记录查询");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("光纤记录", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("合同记录");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("查找");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("打印");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("辅助功能", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFiberPigtail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeleOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoadIntersection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonitorUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBayonetUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVideoUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSignalUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTrafficGuidanceUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEPoliceUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIntranetUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetachmentLocationA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetachmentLocationB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFiberPlugType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cht2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1390, 606);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(7);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点5";
            treeNode1.Text = "电信";
            treeNode2.Name = "节点6";
            treeNode2.Text = "联通";
            treeNode3.Name = "节点7";
            treeNode3.Text = "移动";
            treeNode4.Name = "节点3";
            treeNode4.Text = "中信";
            treeNode5.Name = "节点4";
            treeNode5.Text = "自建";
            treeNode6.BackColor = System.Drawing.Color.White;
            treeNode6.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode6.Name = "Operator";
            treeNode6.Text = "运营商";
            treeNode7.Name = "节点8";
            treeNode7.Text = "电视监视";
            treeNode8.Name = "节点9";
            treeNode8.Text = "电警";
            treeNode9.Name = "节点10";
            treeNode9.Text = "卡口";
            treeNode10.Name = "节点11";
            treeNode10.Text = "信号机";
            treeNode11.Name = "节点0";
            treeNode11.Text = "支队内网";
            treeNode12.Name = "节点1";
            treeNode12.Text = "视频专网";
            treeNode13.Name = "UsingType";
            treeNode13.Text = "业务使用";
            treeNode14.Name = "CrossingLocation";
            treeNode14.Text = "路口位置";
            treeNode15.Name = "RecSerach";
            treeNode15.Text = "记录查询";
            treeNode16.BackColor = System.Drawing.Color.White;
            treeNode16.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode16.Name = "NodeFiber";
            treeNode16.Text = "光纤记录";
            treeNode17.Name = "NodeContract";
            treeNode17.Text = "合同记录";
            treeNode18.Name = "NodeFind";
            treeNode18.Text = "查找";
            treeNode19.Name = "NodePrint";
            treeNode19.Text = "打印";
            treeNode20.Name = "AssistanceFun";
            treeNode20.Text = "辅助功能";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(214, 606);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 606);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage1.Size = new System.Drawing.Size(1158, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "记录列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFiberPigtail,
            this.ColumnTeleOperator,
            this.ColumnRoadIntersection,
            this.ColumnMonitorUsed,
            this.ColumnBayonetUsed,
            this.ColumnVideoUsed,
            this.ColumnSignalUsed,
            this.ColumnTrafficGuidanceUsed,
            this.ColumnEPoliceUsed,
            this.ColumnIntranetUsed,
            this.ColumnDetachmentLocationA,
            this.ColumnDetachmentLocationB,
            this.ColumnFiberPlugType});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 551);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnFiberPigtail
            // 
            this.ColumnFiberPigtail.HeaderText = "光纤尾号";
            this.ColumnFiberPigtail.Name = "ColumnFiberPigtail";
            this.ColumnFiberPigtail.ReadOnly = true;
            // 
            // ColumnTeleOperator
            // 
            this.ColumnTeleOperator.HeaderText = "运营商";
            this.ColumnTeleOperator.Name = "ColumnTeleOperator";
            this.ColumnTeleOperator.ReadOnly = true;
            // 
            // ColumnRoadIntersection
            // 
            this.ColumnRoadIntersection.HeaderText = "路口位置";
            this.ColumnRoadIntersection.Name = "ColumnRoadIntersection";
            this.ColumnRoadIntersection.ReadOnly = true;
            // 
            // ColumnMonitorUsed
            // 
            this.ColumnMonitorUsed.HeaderText = "电视监视";
            this.ColumnMonitorUsed.Name = "ColumnMonitorUsed";
            this.ColumnMonitorUsed.ReadOnly = true;
            // 
            // ColumnBayonetUsed
            // 
            this.ColumnBayonetUsed.HeaderText = "卡口";
            this.ColumnBayonetUsed.Name = "ColumnBayonetUsed";
            this.ColumnBayonetUsed.ReadOnly = true;
            // 
            // ColumnVideoUsed
            // 
            this.ColumnVideoUsed.HeaderText = "视频";
            this.ColumnVideoUsed.Name = "ColumnVideoUsed";
            this.ColumnVideoUsed.ReadOnly = true;
            // 
            // ColumnSignalUsed
            // 
            this.ColumnSignalUsed.HeaderText = "信号机";
            this.ColumnSignalUsed.Name = "ColumnSignalUsed";
            this.ColumnSignalUsed.ReadOnly = true;
            // 
            // ColumnTrafficGuidanceUsed
            // 
            this.ColumnTrafficGuidanceUsed.HeaderText = "交通诱导";
            this.ColumnTrafficGuidanceUsed.Name = "ColumnTrafficGuidanceUsed";
            this.ColumnTrafficGuidanceUsed.ReadOnly = true;
            // 
            // ColumnEPoliceUsed
            // 
            this.ColumnEPoliceUsed.HeaderText = "电警";
            this.ColumnEPoliceUsed.Name = "ColumnEPoliceUsed";
            this.ColumnEPoliceUsed.ReadOnly = true;
            // 
            // ColumnIntranetUsed
            // 
            this.ColumnIntranetUsed.HeaderText = "内网业务";
            this.ColumnIntranetUsed.Name = "ColumnIntranetUsed";
            this.ColumnIntranetUsed.ReadOnly = true;
            // 
            // ColumnDetachmentLocationA
            // 
            this.ColumnDetachmentLocationA.HeaderText = "11楼机柜部署";
            this.ColumnDetachmentLocationA.Name = "ColumnDetachmentLocationA";
            this.ColumnDetachmentLocationA.ReadOnly = true;
            // 
            // ColumnDetachmentLocationB
            // 
            this.ColumnDetachmentLocationB.HeaderText = "12楼机柜部署";
            this.ColumnDetachmentLocationB.Name = "ColumnDetachmentLocationB";
            this.ColumnDetachmentLocationB.ReadOnly = true;
            // 
            // ColumnFiberPlugType
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColumnFiberPlugType.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnFiberPlugType.HeaderText = "光纤类型";
            this.ColumnFiberPlugType.Name = "ColumnFiberPlugType";
            this.ColumnFiberPlugType.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cht2);
            this.tabPage2.Controls.Add(this.cht1);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage2.Size = new System.Drawing.Size(1158, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图表分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cht2
            // 
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.cht2.ChartAreas.Add(chartArea1);
            this.cht2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cht2.Location = new System.Drawing.Point(7, 7);
            this.cht2.Name = "cht2";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.cht2.Series.Add(series1);
            this.cht2.Size = new System.Drawing.Size(1144, 551);
            this.cht2.TabIndex = 1;
            this.cht2.Text = "chart1";
            this.cht2.Visible = false;
            // 
            // cht1
            // 
            chartArea2.Name = "ChartArea1";
            this.cht1.ChartAreas.Add(chartArea2);
            this.cht1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.cht1.Legends.Add(legend1);
            this.cht1.Location = new System.Drawing.Point(7, 7);
            this.cht1.Margin = new System.Windows.Forms.Padding(7);
            this.cht1.Name = "cht1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cht1.Series.Add(series2);
            this.cht1.Size = new System.Drawing.Size(1144, 551);
            this.cht1.TabIndex = 0;
            this.cht1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webBrowser1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1158, 580);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "地图浏览";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1152, 574);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1158, 580);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "合同情况";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(7);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1390, 606);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1390, 606);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "支队光纤数据管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFiberPigtail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeleOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoadIntersection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonitorUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBayonetUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVideoUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSignalUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrafficGuidanceUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEPoliceUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIntranetUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetachmentLocationA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetachmentLocationB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFiberPlugType;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht2;
    }
}

