namespace Ktv.YuDing
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XingMing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BaoFangHao = new System.Windows.Forms.TextBox();
            this.YuDingTime = new System.Windows.Forms.DateTimePicker();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.FangXing = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HuoDong = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKeFu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "预定号";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(90, 21);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 21);
            this.Code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "预定时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名";
            // 
            // XingMing
            // 
            this.XingMing.Location = new System.Drawing.Point(90, 61);
            this.XingMing.Name = "XingMing";
            this.XingMing.Size = new System.Drawing.Size(100, 21);
            this.XingMing.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "手机号码";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(90, 103);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 21);
            this.Phone.TabIndex = 1;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "房型";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "活动";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "包房号";
            // 
            // BaoFangHao
            // 
            this.BaoFangHao.Location = new System.Drawing.Point(282, 145);
            this.BaoFangHao.Name = "BaoFangHao";
            this.BaoFangHao.Size = new System.Drawing.Size(100, 21);
            this.BaoFangHao.TabIndex = 3;
            // 
            // YuDingTime
            // 
            this.YuDingTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.YuDingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YuDingTime.Location = new System.Drawing.Point(282, 21);
            this.YuDingTime.Name = "YuDingTime";
            this.YuDingTime.Size = new System.Drawing.Size(151, 21);
            this.YuDingTime.TabIndex = 4;
            this.YuDingTime.Value = new System.DateTime(2015, 12, 24, 20, 15, 32, 0);
            // 
            // Sex
            // 
            this.Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Sex.Location = new System.Drawing.Point(282, 64);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(100, 20);
            this.Sex.TabIndex = 5;
            // 
            // FangXing
            // 
            this.FangXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FangXing.FormattingEnabled = true;
            this.FangXing.Items.AddRange(new object[] {
            "小房",
            "中房",
            "大房",
            "大套",
            "V01",
            "V02",
            "V03"});
            this.FangXing.Location = new System.Drawing.Point(282, 103);
            this.FangXing.Name = "FangXing";
            this.FangXing.Size = new System.Drawing.Size(100, 20);
            this.FangXing.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "确  定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HuoDong
            // 
            this.HuoDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoDong.FormattingEnabled = true;
            this.HuoDong.Location = new System.Drawing.Point(90, 146);
            this.HuoDong.Name = "HuoDong";
            this.HuoDong.Size = new System.Drawing.Size(100, 20);
            this.HuoDong.TabIndex = 5;
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "预定未来",
            "客户已来",
            "客户取消"});
            this.Status.Location = new System.Drawing.Point(282, 189);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(100, 20);
            this.Status.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "客服";
            // 
            // txtKeFu
            // 
            this.txtKeFu.Enabled = false;
            this.txtKeFu.Location = new System.Drawing.Point(90, 188);
            this.txtKeFu.Name = "txtKeFu";
            this.txtKeFu.Size = new System.Drawing.Size(100, 21);
            this.txtKeFu.TabIndex = 3;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 290);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HuoDong);
            this.Controls.Add(this.FangXing);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.YuDingTime);
            this.Controls.Add(this.txtKeFu);
            this.Controls.Add(this.BaoFangHao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.XingMing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定信息";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox XingMing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BaoFangHao;
        private System.Windows.Forms.DateTimePicker YuDingTime;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox FangXing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox HuoDong;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKeFu;
    }
}