﻿namespace 酒水寄存
{
    partial class MainForm1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.种类管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxKind = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CunJiuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuJiuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.存酒日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.到期日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.种类 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.存酒卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.续存日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.续存操作人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取酒操作人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取酒日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.过期取酒管理员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.续存 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.取酒 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.种类管理ToolStripMenuItem,
            this.返库管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 种类管理ToolStripMenuItem
            // 
            this.种类管理ToolStripMenuItem.Name = "种类管理ToolStripMenuItem";
            this.种类管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.种类管理ToolStripMenuItem.Text = "种类管理";
            this.种类管理ToolStripMenuItem.Click += new System.EventHandler(this.种类管理ToolStripMenuItem_Click);
            // 
            // 返库管理ToolStripMenuItem
            // 
            this.返库管理ToolStripMenuItem.Name = "返库管理ToolStripMenuItem";
            this.返库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.返库管理ToolStripMenuItem.Text = "返库管理";
            this.返库管理ToolStripMenuItem.Click += new System.EventHandler(this.返库管理ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(903, 554);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCardNumber);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxKind);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "存酒管理";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "→";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(560, 43);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(99, 21);
            this.txtCardNumber.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(400, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(99, 21);
            this.txtPhone.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(259, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 21);
            this.txtName.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "未取",
            "已取"});
            this.comboBox1.Location = new System.Drawing.Point(581, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "存酒卡号";
            // 
            // cbxKind
            // 
            this.cbxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKind.FormattingEnabled = true;
            this.cbxKind.Location = new System.Drawing.Point(457, 16);
            this.cbxKind.Name = "cbxKind";
            this.cbxKind.Size = new System.Drawing.Size(81, 20);
            this.cbxKind.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "种类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "存酒日期";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(293, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(722, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "查  询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "添加存酒";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CunJiuId,
            this.QuJiuId,
            this.状态,
            this.存酒日期,
            this.到期日期,
            this.种类,
            this.存酒卡号,
            this.客户姓名,
            this.客户电话,
            this.数量,
            this.录入人,
            this.续存日期,
            this.续存操作人,
            this.取酒操作人,
            this.取酒日期,
            this.过期取酒管理员,
            this.续存,
            this.取酒});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // CunJiuId
            // 
            this.CunJiuId.DataPropertyName = "CunJiuId";
            this.CunJiuId.HeaderText = "CunJiuId";
            this.CunJiuId.Name = "CunJiuId";
            this.CunJiuId.ReadOnly = true;
            this.CunJiuId.Visible = false;
            // 
            // QuJiuId
            // 
            this.QuJiuId.DataPropertyName = "QuJiuId";
            this.QuJiuId.HeaderText = "QuJiuId";
            this.QuJiuId.Name = "QuJiuId";
            this.QuJiuId.ReadOnly = true;
            this.QuJiuId.Visible = false;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "状态";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 80;
            // 
            // 存酒日期
            // 
            this.存酒日期.DataPropertyName = "存酒日期";
            this.存酒日期.HeaderText = "存酒日期";
            this.存酒日期.Name = "存酒日期";
            this.存酒日期.ReadOnly = true;
            this.存酒日期.Width = 80;
            // 
            // 到期日期
            // 
            this.到期日期.DataPropertyName = "到期日期";
            this.到期日期.HeaderText = "到期日期";
            this.到期日期.Name = "到期日期";
            this.到期日期.ReadOnly = true;
            this.到期日期.Width = 80;
            // 
            // 种类
            // 
            this.种类.DataPropertyName = "种类";
            this.种类.HeaderText = "种类";
            this.种类.Name = "种类";
            this.种类.ReadOnly = true;
            this.种类.Width = 80;
            // 
            // 存酒卡号
            // 
            this.存酒卡号.DataPropertyName = "存酒卡号";
            this.存酒卡号.HeaderText = "存酒卡号";
            this.存酒卡号.Name = "存酒卡号";
            this.存酒卡号.ReadOnly = true;
            this.存酒卡号.Width = 80;
            // 
            // 客户姓名
            // 
            this.客户姓名.DataPropertyName = "客户姓名";
            this.客户姓名.HeaderText = "客户姓名";
            this.客户姓名.Name = "客户姓名";
            this.客户姓名.ReadOnly = true;
            this.客户姓名.Width = 80;
            // 
            // 客户电话
            // 
            this.客户电话.DataPropertyName = "客户电话";
            this.客户电话.HeaderText = "客户电话";
            this.客户电话.Name = "客户电话";
            this.客户电话.ReadOnly = true;
            this.客户电话.Width = 80;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 60;
            // 
            // 录入人
            // 
            this.录入人.DataPropertyName = "录入人";
            this.录入人.HeaderText = "录入人";
            this.录入人.Name = "录入人";
            this.录入人.ReadOnly = true;
            this.录入人.Width = 80;
            // 
            // 续存日期
            // 
            this.续存日期.DataPropertyName = "续存日期";
            this.续存日期.HeaderText = "续存日期";
            this.续存日期.Name = "续存日期";
            this.续存日期.ReadOnly = true;
            this.续存日期.Width = 80;
            // 
            // 续存操作人
            // 
            this.续存操作人.DataPropertyName = "续存操作人";
            this.续存操作人.HeaderText = "续存操作人";
            this.续存操作人.Name = "续存操作人";
            this.续存操作人.ReadOnly = true;
            this.续存操作人.Width = 80;
            // 
            // 取酒操作人
            // 
            this.取酒操作人.DataPropertyName = "取酒操作人";
            this.取酒操作人.HeaderText = "取酒操作人";
            this.取酒操作人.Name = "取酒操作人";
            this.取酒操作人.ReadOnly = true;
            this.取酒操作人.Width = 80;
            // 
            // 取酒日期
            // 
            this.取酒日期.DataPropertyName = "取酒日期";
            this.取酒日期.HeaderText = "取酒日期";
            this.取酒日期.Name = "取酒日期";
            this.取酒日期.ReadOnly = true;
            this.取酒日期.Width = 80;
            // 
            // 过期取酒管理员
            // 
            this.过期取酒管理员.DataPropertyName = "过期取酒管理员";
            this.过期取酒管理员.HeaderText = "过期取酒管理员";
            this.过期取酒管理员.Name = "过期取酒管理员";
            this.过期取酒管理员.ReadOnly = true;
            this.过期取酒管理员.Width = 110;
            // 
            // 续存
            // 
            this.续存.HeaderText = "续存";
            this.续存.Name = "续存";
            this.续存.ReadOnly = true;
            this.续存.Text = "续存";
            this.续存.UseColumnTextForButtonValue = true;
            this.续存.Width = 80;
            // 
            // 取酒
            // 
            this.取酒.HeaderText = "取酒";
            this.取酒.Name = "取酒";
            this.取酒.ReadOnly = true;
            this.取酒.Text = "取酒";
            this.取酒.UseColumnTextForButtonValue = true;
            this.取酒.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除选中ToolStripMenuItem
            // 
            this.删除选中ToolStripMenuItem.Name = "删除选中ToolStripMenuItem";
            this.删除选中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除选中ToolStripMenuItem.Text = "删除选中";
            this.删除选中ToolStripMenuItem.Click += new System.EventHandler(this.删除选中ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前用户：";
            // 
            // toolCurrentUser
            // 
            this.toolCurrentUser.Name = "toolCurrentUser";
            this.toolCurrentUser.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 579);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒水管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 种类管理ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 返库管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolCurrentUser;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CunJiuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuJiuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 存酒日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 到期日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 种类;
        private System.Windows.Forms.DataGridViewTextBoxColumn 存酒卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 续存日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 续存操作人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取酒操作人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取酒日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 过期取酒管理员;
        private System.Windows.Forms.DataGridViewButtonColumn 续存;
        private System.Windows.Forms.DataGridViewButtonColumn 取酒;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中ToolStripMenuItem;
    }
}