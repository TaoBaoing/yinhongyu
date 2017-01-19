namespace Ktv.YuDing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXingMing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当日单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预定号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预定时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手机号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客服 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.包房号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活动 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.活动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客服管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FangXing = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加预定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // txtXingMing
            // 
            this.txtXingMing.Location = new System.Drawing.Point(217, 36);
            this.txtXingMing.Name = "txtXingMing";
            this.txtXingMing.Size = new System.Drawing.Size(80, 21);
            this.txtXingMing.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "房型";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(347, 36);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(498, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "->";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(677, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(156, 21);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(972, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.单号,
            this.当日单号,
            this.预定号,
            this.预定时间,
            this.姓名,
            this.性别,
            this.手机号码,
            this.房型,
            this.客服,
            this.包房号,
            this.活动,
            this.Status});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 81);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 480);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // 单号
            // 
            this.单号.DataPropertyName = "Id";
            this.单号.HeaderText = "单号";
            this.单号.Name = "单号";
            this.单号.ReadOnly = true;
            this.单号.Visible = false;
            this.单号.Width = 80;
            // 
            // 当日单号
            // 
            this.当日单号.DataPropertyName = "TodayId";
            this.当日单号.HeaderText = "当日单号";
            this.当日单号.Name = "当日单号";
            this.当日单号.ReadOnly = true;
            this.当日单号.Width = 80;
            // 
            // 预定号
            // 
            this.预定号.DataPropertyName = "Code";
            this.预定号.HeaderText = "预定号";
            this.预定号.Name = "预定号";
            this.预定号.ReadOnly = true;
            // 
            // 预定时间
            // 
            this.预定时间.DataPropertyName = "YuDingTime";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.预定时间.DefaultCellStyle = dataGridViewCellStyle1;
            this.预定时间.HeaderText = "预定时间";
            this.预定时间.Name = "预定时间";
            this.预定时间.ReadOnly = true;
            this.预定时间.Width = 120;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "XingMing";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "Sex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            this.性别.Width = 60;
            // 
            // 手机号码
            // 
            this.手机号码.DataPropertyName = "Phone";
            this.手机号码.HeaderText = "手机号码";
            this.手机号码.Name = "手机号码";
            this.手机号码.ReadOnly = true;
            // 
            // 房型
            // 
            this.房型.DataPropertyName = "FangXing";
            this.房型.HeaderText = "房型";
            this.房型.Name = "房型";
            this.房型.ReadOnly = true;
            this.房型.Width = 80;
            // 
            // 客服
            // 
            this.客服.DataPropertyName = "KeFuName";
            this.客服.HeaderText = "客服";
            this.客服.Name = "客服";
            this.客服.ReadOnly = true;
            // 
            // 包房号
            // 
            this.包房号.DataPropertyName = "BaoFangHao";
            this.包房号.HeaderText = "包房号";
            this.包房号.Name = "包房号";
            this.包房号.ReadOnly = true;
            // 
            // 活动
            // 
            this.活动.DataPropertyName = "HuoDongName";
            this.活动.HeaderText = "活动";
            this.活动.Name = "活动";
            this.活动.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中项ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除选中项ToolStripMenuItem
            // 
            this.删除选中项ToolStripMenuItem.Name = "删除选中项ToolStripMenuItem";
            this.删除选中项ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除选中项ToolStripMenuItem.Text = "删除选中";
            this.删除选中项ToolStripMenuItem.Click += new System.EventHandler(this.删除选中项ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.活动管理ToolStripMenuItem,
            this.客服管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 活动管理ToolStripMenuItem
            // 
            this.活动管理ToolStripMenuItem.Name = "活动管理ToolStripMenuItem";
            this.活动管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.活动管理ToolStripMenuItem.Text = "活动管理";
            this.活动管理ToolStripMenuItem.Click += new System.EventHandler(this.活动管理ToolStripMenuItem_Click);
            // 
            // 客服管理ToolStripMenuItem
            // 
            this.客服管理ToolStripMenuItem.Name = "客服管理ToolStripMenuItem";
            this.客服管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客服管理ToolStripMenuItem.Text = "用户管理";
            this.客服管理ToolStripMenuItem.Click += new System.EventHandler(this.客服管理ToolStripMenuItem_Click);
            // 
            // FangXing
            // 
            this.FangXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FangXing.FormattingEnabled = true;
            this.FangXing.Items.AddRange(new object[] {
            "",
            "小房",
            "中房",
            "大房",
            "大套",
            "V01",
            "V02",
            "V03"});
            this.FangXing.Location = new System.Drawing.Point(874, 37);
            this.FangXing.Name = "FangXing";
            this.FangXing.Size = new System.Drawing.Size(84, 20);
            this.FangXing.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "手机号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 563);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FangXing);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXingMing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客服预定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXingMing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 活动管理ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中项ToolStripMenuItem;
        private System.Windows.Forms.ComboBox FangXing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 客服管理ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当日单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预定号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预定时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手机号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客服;
        private System.Windows.Forms.DataGridViewTextBoxColumn 包房号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 活动;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

