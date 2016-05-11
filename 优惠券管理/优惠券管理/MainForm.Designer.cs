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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.地址管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卷人管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优惠券管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.优惠券发放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增发放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发放查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登记回收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增回收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回收查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(878, 25);
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
            this.新增发放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增发放ToolStripMenuItem.Text = "新增发放";
            // 
            // 发放查询ToolStripMenuItem
            // 
            this.发放查询ToolStripMenuItem.Name = "发放查询ToolStripMenuItem";
            this.发放查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.发放查询ToolStripMenuItem.Text = "发放查询";
            // 
            // 登记回收ToolStripMenuItem
            // 
            this.登记回收ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增回收ToolStripMenuItem,
            this.回收查询ToolStripMenuItem});
            this.登记回收ToolStripMenuItem.Name = "登记回收ToolStripMenuItem";
            this.登记回收ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.登记回收ToolStripMenuItem.Text = "登记回收";
            // 
            // 新增回收ToolStripMenuItem
            // 
            this.新增回收ToolStripMenuItem.Name = "新增回收ToolStripMenuItem";
            this.新增回收ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增回收ToolStripMenuItem.Text = "新增回收";
            // 
            // 回收查询ToolStripMenuItem
            // 
            this.回收查询ToolStripMenuItem.Name = "回收查询ToolStripMenuItem";
            this.回收查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.回收查询ToolStripMenuItem.Text = "回收查询";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 新增回收ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回收查询ToolStripMenuItem;
    }
}