namespace 优惠券管理
{
    partial class MainForm
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
            this.地址管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卷人管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优惠券管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优惠券发放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增发放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发放查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登记回收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendUserId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JuanKindId = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxCode = new System.Windows.Forms.TextBox();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发券日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发券人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.优惠券 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卷编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回收日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.地址管理ToolStripMenuItem,
            this.发卷人管理ToolStripMenuItem,
            this.优惠券管理ToolStripMenuItem,
            this.优惠券发放ToolStripMenuItem,
            this.登记回收ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 地址管理ToolStripMenuItem
            // 
            this.地址管理ToolStripMenuItem.Name = "地址管理ToolStripMenuItem";
            this.地址管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.地址管理ToolStripMenuItem.Text = "地址管理";
            this.地址管理ToolStripMenuItem.Click += new System.EventHandler(this.地址管理ToolStripMenuItem_Click);
            // 
            // 发卷人管理ToolStripMenuItem
            // 
            this.发卷人管理ToolStripMenuItem.Name = "发卷人管理ToolStripMenuItem";
            this.发卷人管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.发卷人管理ToolStripMenuItem.Text = "发卷人管理";
            this.发卷人管理ToolStripMenuItem.Click += new System.EventHandler(this.发卷人管理ToolStripMenuItem_Click);
            // 
            // 优惠券管理ToolStripMenuItem
            // 
            this.优惠券管理ToolStripMenuItem.Name = "优惠券管理ToolStripMenuItem";
            this.优惠券管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.优惠券管理ToolStripMenuItem.Text = "优惠券管理";
            this.优惠券管理ToolStripMenuItem.Click += new System.EventHandler(this.优惠券管理ToolStripMenuItem_Click);
            // 
            // 优惠券发放ToolStripMenuItem
            // 
            this.优惠券发放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增发放ToolStripMenuItem,
            this.发放查询ToolStripMenuItem});
            this.优惠券发放ToolStripMenuItem.Name = "优惠券发放ToolStripMenuItem";
            this.优惠券发放ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.优惠券发放ToolStripMenuItem.Text = "登记发放";
            // 
            // 新增发放ToolStripMenuItem
            // 
            this.新增发放ToolStripMenuItem.Name = "新增发放ToolStripMenuItem";
            this.新增发放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增发放ToolStripMenuItem.Text = "新增发放";
            this.新增发放ToolStripMenuItem.Click += new System.EventHandler(this.新增发放ToolStripMenuItem_Click);
            // 
            // 发放查询ToolStripMenuItem
            // 
            this.发放查询ToolStripMenuItem.Name = "发放查询ToolStripMenuItem";
            this.发放查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.发放查询ToolStripMenuItem.Text = "发放查询";
            this.发放查询ToolStripMenuItem.Click += new System.EventHandler(this.发放查询ToolStripMenuItem_Click);
            // 
            // 登记回收ToolStripMenuItem
            // 
            this.登记回收ToolStripMenuItem.Name = "登记回收ToolStripMenuItem";
            this.登记回收ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.登记回收ToolStripMenuItem.Text = "添加登记回收";
            this.登记回收ToolStripMenuItem.Click += new System.EventHandler(this.登记回收ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.JuanKindId);
            this.splitContainer1.Panel1.Controls.Add(this.AddressId);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.SendUserId);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaxCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtMinCode);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(887, 521);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "回收查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "→";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "回收日期";
            // 
            // txtMinCode
            // 
            this.txtMinCode.Location = new System.Drawing.Point(394, 8);
            this.txtMinCode.Name = "txtMinCode";
            this.txtMinCode.Size = new System.Drawing.Size(109, 21);
            this.txtMinCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "发卷人";
            // 
            // SendUserId
            // 
            this.SendUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendUserId.FormattingEnabled = true;
            this.SendUserId.Location = new System.Drawing.Point(394, 35);
            this.SendUserId.Name = "SendUserId";
            this.SendUserId.Size = new System.Drawing.Size(109, 20);
            this.SendUserId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "地点";
            // 
            // AddressId
            // 
            this.AddressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddressId.FormattingEnabled = true;
            this.AddressId.Location = new System.Drawing.Point(58, 35);
            this.AddressId.Name = "AddressId";
            this.AddressId.Size = new System.Drawing.Size(269, 20);
            this.AddressId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "优惠券";
            // 
            // JuanKindId
            // 
            this.JuanKindId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JuanKindId.FormattingEnabled = true;
            this.JuanKindId.Location = new System.Drawing.Point(546, 35);
            this.JuanKindId.Name = "JuanKindId";
            this.JuanKindId.Size = new System.Drawing.Size(121, 20);
            this.JuanKindId.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.发券日期,
            this.发券人,
            this.地址,
            this.优惠券,
            this.卷编号,
            this.回收日期});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "卷编号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "→";
            // 
            // txtMaxCode
            // 
            this.txtMaxCode.Location = new System.Drawing.Point(546, 9);
            this.txtMaxCode.Name = "txtMaxCode";
            this.txtMaxCode.Size = new System.Drawing.Size(121, 21);
            this.txtMaxCode.TabIndex = 6;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "Id";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Visible = false;
            // 
            // 发券日期
            // 
            this.发券日期.DataPropertyName = "SendDate";
            this.发券日期.HeaderText = "发券日期";
            this.发券日期.Name = "发券日期";
            this.发券日期.ReadOnly = true;
            // 
            // 发券人
            // 
            this.发券人.DataPropertyName = "SendUserName";
            this.发券人.HeaderText = "发券人";
            this.发券人.Name = "发券人";
            this.发券人.ReadOnly = true;
            // 
            // 地址
            // 
            this.地址.DataPropertyName = "AddressName";
            this.地址.HeaderText = "地址";
            this.地址.Name = "地址";
            this.地址.ReadOnly = true;
            this.地址.Width = 200;
            // 
            // 优惠券
            // 
            this.优惠券.DataPropertyName = "JuanKindName";
            this.优惠券.HeaderText = "优惠券";
            this.优惠券.Name = "优惠券";
            this.优惠券.ReadOnly = true;
            // 
            // 卷编号
            // 
            this.卷编号.DataPropertyName = "StrCode";
            this.卷编号.HeaderText = "卷编号";
            this.卷编号.Name = "卷编号";
            this.卷编号.ReadOnly = true;
            // 
            // 回收日期
            // 
            this.回收日期.DataPropertyName = "ReceiveDate";
            this.回收日期.HeaderText = "回收日期";
            this.回收日期.Name = "回收日期";
            this.回收日期.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 546);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "优惠券管理";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 地址管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发卷人管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 优惠券管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 优惠券发放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增发放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发放查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登记回收ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinCode;
        private System.Windows.Forms.ComboBox SendUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddressId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JuanKindId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发券日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发券人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 优惠券;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卷编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回收日期;
    }
}