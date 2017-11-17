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
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("电信");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("联通");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("移动");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("中信");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("自建");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("运营商", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("电视监视");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("电警");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("卡口");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("信号机");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("支队内网");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("视频专网");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("业务使用", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("路口位置");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("记录查询");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("光纤记录", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode45,
            treeNode46,
            treeNode47});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(838, 444);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(7);
            this.treeView1.Name = "treeView1";
            treeNode33.Name = "节点5";
            treeNode33.Text = "电信";
            treeNode34.Name = "节点6";
            treeNode34.Text = "联通";
            treeNode35.Name = "节点7";
            treeNode35.Text = "移动";
            treeNode36.Name = "节点3";
            treeNode36.Text = "中信";
            treeNode37.Name = "节点4";
            treeNode37.Text = "自建";
            treeNode38.BackColor = System.Drawing.Color.White;
            treeNode38.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode38.Name = "Operator";
            treeNode38.Text = "运营商";
            treeNode39.Name = "节点8";
            treeNode39.Text = "电视监视";
            treeNode40.Name = "节点9";
            treeNode40.Text = "电警";
            treeNode41.Name = "节点10";
            treeNode41.Text = "卡口";
            treeNode42.Name = "节点11";
            treeNode42.Text = "信号机";
            treeNode43.Name = "节点0";
            treeNode43.Text = "支队内网";
            treeNode44.Name = "节点1";
            treeNode44.Text = "视频专网";
            treeNode45.Name = "UsingType";
            treeNode45.Text = "业务使用";
            treeNode46.Name = "CrossingLoc";
            treeNode46.Text = "路口位置";
            treeNode47.Name = "RecSerach";
            treeNode47.Text = "记录查询";
            treeNode48.BackColor = System.Drawing.Color.White;
            treeNode48.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode48.Name = "节点0";
            treeNode48.Text = "光纤记录";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode48});
            this.treeView1.Size = new System.Drawing.Size(215, 444);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 444);
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
            this.tabPage1.Size = new System.Drawing.Size(605, 403);
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
            this.dataGridView1.Size = new System.Drawing.Size(591, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnFiberPigtail
            // 
            this.ColumnFiberPigtail.HeaderText = "光纤尾号";
            this.ColumnFiberPigtail.Name = "ColumnFiberPigtail";
            // 
            // ColumnTeleOperator
            // 
            this.ColumnTeleOperator.HeaderText = "运营商";
            this.ColumnTeleOperator.Name = "ColumnTeleOperator";
            // 
            // ColumnRoadIntersection
            // 
            this.ColumnRoadIntersection.HeaderText = "路口位置";
            this.ColumnRoadIntersection.Name = "ColumnRoadIntersection";
            // 
            // ColumnMonitorUsed
            // 
            this.ColumnMonitorUsed.HeaderText = "电视监视";
            this.ColumnMonitorUsed.Name = "ColumnMonitorUsed";
            // 
            // ColumnBayonetUsed
            // 
            this.ColumnBayonetUsed.HeaderText = "卡口";
            this.ColumnBayonetUsed.Name = "ColumnBayonetUsed";
            // 
            // ColumnVideoUsed
            // 
            this.ColumnVideoUsed.HeaderText = "视频";
            this.ColumnVideoUsed.Name = "ColumnVideoUsed";
            // 
            // ColumnSignalUsed
            // 
            this.ColumnSignalUsed.HeaderText = "信号机";
            this.ColumnSignalUsed.Name = "ColumnSignalUsed";
            // 
            // ColumnTrafficGuidanceUsed
            // 
            this.ColumnTrafficGuidanceUsed.HeaderText = "交通诱导";
            this.ColumnTrafficGuidanceUsed.Name = "ColumnTrafficGuidanceUsed";
            // 
            // ColumnEPoliceUsed
            // 
            this.ColumnEPoliceUsed.HeaderText = "电警";
            this.ColumnEPoliceUsed.Name = "ColumnEPoliceUsed";
            // 
            // ColumnIntranetUsed
            // 
            this.ColumnIntranetUsed.HeaderText = "内网业务";
            this.ColumnIntranetUsed.Name = "ColumnIntranetUsed";
            // 
            // ColumnDetachmentLocationA
            // 
            this.ColumnDetachmentLocationA.HeaderText = "11楼机柜部署";
            this.ColumnDetachmentLocationA.Name = "ColumnDetachmentLocationA";
            // 
            // ColumnDetachmentLocationB
            // 
            this.ColumnDetachmentLocationB.HeaderText = "12楼机柜部署";
            this.ColumnDetachmentLocationB.Name = "ColumnDetachmentLocationB";
            // 
            // ColumnFiberPlugType
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColumnFiberPlugType.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnFiberPlugType.HeaderText = "光纤类型";
            this.ColumnFiberPlugType.Name = "ColumnFiberPlugType";
            this.ColumnFiberPlugType.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cht1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage2.Size = new System.Drawing.Size(605, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图线分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cht1
            // 
            chartArea3.Name = "ChartArea1";
            this.cht1.ChartAreas.Add(chartArea3);
            this.cht1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.cht1.Legends.Add(legend3);
            this.cht1.Location = new System.Drawing.Point(7, 7);
            this.cht1.Margin = new System.Windows.Forms.Padding(7);
            this.cht1.Name = "cht1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cht1.Series.Add(series3);
            this.cht1.Size = new System.Drawing.Size(591, 404);
            this.cht1.TabIndex = 0;
            this.cht1.Text = "chart1";
            this.cht1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(605, 418);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(838, 444);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(838, 444);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "支队光纤数据管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}

