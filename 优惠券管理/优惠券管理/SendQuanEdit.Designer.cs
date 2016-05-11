namespace 优惠券管理
{
    partial class SendQuanEdit
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
            this.SendDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SendUserId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StrMinCode = new System.Windows.Forms.TextBox();
            this.StrMaxCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // SendDate
            // 
            this.SendDate.Location = new System.Drawing.Point(72, 19);
            this.SendDate.Name = "SendDate";
            this.SendDate.Size = new System.Drawing.Size(157, 21);
            this.SendDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "发券地点";
            // 
            // SendUserId
            // 
            this.SendUserId.FormattingEnabled = true;
            this.SendUserId.Location = new System.Drawing.Point(325, 22);
            this.SendUserId.Name = "SendUserId";
            this.SendUserId.Size = new System.Drawing.Size(195, 20);
            this.SendUserId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "发券人";
            // 
            // AddressId
            // 
            this.AddressId.FormattingEnabled = true;
            this.AddressId.Location = new System.Drawing.Point(72, 68);
            this.AddressId.Name = "AddressId";
            this.AddressId.Size = new System.Drawing.Size(448, 20);
            this.AddressId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "券起始号";
            // 
            // StrMinCode
            // 
            this.StrMinCode.Location = new System.Drawing.Point(72, 113);
            this.StrMinCode.Name = "StrMinCode";
            this.StrMinCode.Size = new System.Drawing.Size(157, 21);
            this.StrMinCode.TabIndex = 4;
            // 
            // StrMaxCode
            // 
            this.StrMaxCode.Location = new System.Drawing.Point(325, 116);
            this.StrMaxCode.Name = "StrMaxCode";
            this.StrMaxCode.Size = new System.Drawing.Size(195, 21);
            this.StrMaxCode.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "券结束号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "保  存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendQuanEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StrMaxCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StrMinCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddressId);
            this.Controls.Add(this.SendUserId);
            this.Controls.Add(this.SendDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendQuanEdit";
            this.Text = "登记发放";
            this.Load += new System.EventHandler(this.SendQuanEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SendDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SendUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddressId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StrMinCode;
        private System.Windows.Forms.TextBox StrMaxCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}