namespace 优惠券管理
{
    partial class ReceiveQuanEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.JuanKindId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSendDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSendUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "优惠券";
            // 
            // JuanKindId
            // 
            this.JuanKindId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JuanKindId.FormattingEnabled = true;
            this.JuanKindId.Location = new System.Drawing.Point(78, 49);
            this.JuanKindId.Name = "JuanKindId";
            this.JuanKindId.Size = new System.Drawing.Size(207, 20);
            this.JuanKindId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "券编号";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(78, 84);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(207, 21);
            this.txtCode.TabIndex = 2;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "发券时间";
            // 
            // txtSendDate
            // 
            this.txtSendDate.Enabled = false;
            this.txtSendDate.Location = new System.Drawing.Point(78, 131);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.Size = new System.Drawing.Size(207, 21);
            this.txtSendDate.TabIndex = 2;
            this.txtSendDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "发券人";
            // 
            // txtSendUserName
            // 
            this.txtSendUserName.Enabled = false;
            this.txtSendUserName.Location = new System.Drawing.Point(78, 167);
            this.txtSendUserName.Name = "txtSendUserName";
            this.txtSendUserName.Size = new System.Drawing.Size(207, 21);
            this.txtSendUserName.TabIndex = 2;
            this.txtSendUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "发券地点";
            // 
            // txtAddressName
            // 
            this.txtAddressName.Enabled = false;
            this.txtAddressName.Location = new System.Drawing.Point(78, 204);
            this.txtAddressName.Multiline = true;
            this.txtAddressName.Name = "txtAddressName";
            this.txtAddressName.Size = new System.Drawing.Size(207, 61);
            this.txtAddressName.TabIndex = 2;
            this.txtAddressName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "回收时间";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ReceiveQuanEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 357);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddressName);
            this.Controls.Add(this.txtSendUserName);
            this.Controls.Add(this.txtSendDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JuanKindId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiveQuanEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "优惠券回收";
            this.Load += new System.EventHandler(this.ReceiveQuanEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox JuanKindId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSendDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSendUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}