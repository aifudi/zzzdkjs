namespace zzzdkjs.UserForm
{
    partial class RecSerachForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonRoadAuto = new System.Windows.Forms.RadioButton();
            this.comboBoxRoadName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRoadName = new System.Windows.Forms.TextBox();
            this.radioButtonRoadHand = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCrossName = new System.Windows.Forms.TextBox();
            this.radioButtonCrossHand = new System.Windows.Forms.RadioButton();
            this.radioButtonCrossAuto = new System.Windows.Forms.RadioButton();
            this.comboBoxCrossName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRoadAuto
            // 
            this.radioButtonRoadAuto.AutoSize = true;
            this.radioButtonRoadAuto.Checked = true;
            this.radioButtonRoadAuto.Location = new System.Drawing.Point(17, 20);
            this.radioButtonRoadAuto.Name = "radioButtonRoadAuto";
            this.radioButtonRoadAuto.Size = new System.Drawing.Size(47, 16);
            this.radioButtonRoadAuto.TabIndex = 0;
            this.radioButtonRoadAuto.TabStop = true;
            this.radioButtonRoadAuto.Text = "自动";
            this.radioButtonRoadAuto.UseVisualStyleBackColor = true;
            this.radioButtonRoadAuto.CheckedChanged += new System.EventHandler(this.radioButtonRoadAuto_CheckedChanged);
            // 
            // comboBoxRoadName
            // 
            this.comboBoxRoadName.FormattingEnabled = true;
            this.comboBoxRoadName.Location = new System.Drawing.Point(80, 16);
            this.comboBoxRoadName.Name = "comboBoxRoadName";
            this.comboBoxRoadName.Size = new System.Drawing.Size(121, 20);
            this.comboBoxRoadName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRoadName);
            this.groupBox1.Controls.Add(this.radioButtonRoadHand);
            this.groupBox1.Controls.Add(this.radioButtonRoadAuto);
            this.groupBox1.Controls.Add(this.comboBoxRoadName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按路名检索";
            // 
            // textBoxRoadName
            // 
            this.textBoxRoadName.Location = new System.Drawing.Point(80, 49);
            this.textBoxRoadName.Name = "textBoxRoadName";
            this.textBoxRoadName.Size = new System.Drawing.Size(121, 21);
            this.textBoxRoadName.TabIndex = 3;
            // 
            // radioButtonRoadHand
            // 
            this.radioButtonRoadHand.AutoSize = true;
            this.radioButtonRoadHand.Location = new System.Drawing.Point(17, 55);
            this.radioButtonRoadHand.Name = "radioButtonRoadHand";
            this.radioButtonRoadHand.Size = new System.Drawing.Size(47, 16);
            this.radioButtonRoadHand.TabIndex = 2;
            this.radioButtonRoadHand.TabStop = true;
            this.radioButtonRoadHand.Text = "手动";
            this.radioButtonRoadHand.UseVisualStyleBackColor = true;
            this.radioButtonRoadHand.CheckedChanged += new System.EventHandler(this.radioButtonRoadHand_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCrossName);
            this.groupBox2.Controls.Add(this.radioButtonCrossHand);
            this.groupBox2.Controls.Add(this.radioButtonCrossAuto);
            this.groupBox2.Controls.Add(this.comboBoxCrossName);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按路口检索";
            // 
            // textBoxCrossName
            // 
            this.textBoxCrossName.Location = new System.Drawing.Point(80, 50);
            this.textBoxCrossName.Name = "textBoxCrossName";
            this.textBoxCrossName.Size = new System.Drawing.Size(121, 21);
            this.textBoxCrossName.TabIndex = 4;
            // 
            // radioButtonCrossHand
            // 
            this.radioButtonCrossHand.AutoSize = true;
            this.radioButtonCrossHand.Location = new System.Drawing.Point(17, 55);
            this.radioButtonCrossHand.Name = "radioButtonCrossHand";
            this.radioButtonCrossHand.Size = new System.Drawing.Size(47, 16);
            this.radioButtonCrossHand.TabIndex = 2;
            this.radioButtonCrossHand.TabStop = true;
            this.radioButtonCrossHand.Text = "手动";
            this.radioButtonCrossHand.UseVisualStyleBackColor = true;
            this.radioButtonCrossHand.CheckedChanged += new System.EventHandler(this.radioButtonCrossHand_CheckedChanged);
            // 
            // radioButtonCrossAuto
            // 
            this.radioButtonCrossAuto.AutoSize = true;
            this.radioButtonCrossAuto.Location = new System.Drawing.Point(17, 20);
            this.radioButtonCrossAuto.Name = "radioButtonCrossAuto";
            this.radioButtonCrossAuto.Size = new System.Drawing.Size(47, 16);
            this.radioButtonCrossAuto.TabIndex = 0;
            this.radioButtonCrossAuto.TabStop = true;
            this.radioButtonCrossAuto.Text = "自动";
            this.radioButtonCrossAuto.UseVisualStyleBackColor = true;
            this.radioButtonCrossAuto.CheckedChanged += new System.EventHandler(this.radioButtonCrossAuto_CheckedChanged);
            // 
            // comboBoxCrossName
            // 
            this.comboBoxCrossName.FormattingEnabled = true;
            this.comboBoxCrossName.Location = new System.Drawing.Point(80, 16);
            this.comboBoxCrossName.Name = "comboBoxCrossName";
            this.comboBoxCrossName.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCrossName.TabIndex = 1;
            // 
            // RecSerachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RecSerachForm";
            this.Text = "路口查询记录";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRoadAuto;
        private System.Windows.Forms.ComboBox comboBoxRoadName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRoadHand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCrossHand;
        private System.Windows.Forms.RadioButton radioButtonCrossAuto;
        private System.Windows.Forms.ComboBox comboBoxCrossName;
        private System.Windows.Forms.TextBox textBoxRoadName;
        private System.Windows.Forms.TextBox textBoxCrossName;
    }
}