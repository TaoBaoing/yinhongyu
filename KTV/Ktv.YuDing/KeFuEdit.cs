using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ktv.model;

namespace Ktv.YuDing
{
    public partial class KeFuEdit : Form
    {
        private long mId = 0;
        private string mName = "";
     
        public void Init(long id, string name )
        {
            mId = id;
            mName = name;
        }
        public KeFuEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("名称不能为空");
                return;
            }
            if (string.IsNullOrEmpty(cbxUserType.Text))
            {
                MessageBox.Show("请选择类型");
                return;
            }

            if (mId > 0)
            {
                var sql = "update KeFu set MingCheng='" + textBox1.Text + "',Pwd='"+txtPwd.Text+"',UserType='"+cbxUserType.Text+"'  where Id=" + mId;
                SqlHelper.Execute(sql);
            }
            else
            {
                var sql = "insert into KeFu (MingCheng,Pwd,UserType) values ('" + textBox1.Text + "','" + txtPwd.Text + "','" + cbxUserType.Text + "')";
                SqlHelper.Execute(sql);
            }
            DialogResult = DialogResult.OK;
            Close();

        }

        private void KeFuEdit_Load(object sender, EventArgs e)
        {
            if (mId > 0)
            {
                textBox1.Enabled = false;
                var kefu = SqlHelper.Query<KeFu>("select * from KeFu where Id="+mId).First() ;
                //                if (dbUser.UserType == UserType.管理员 && AppUtil.DbUser.UserType == UserType.客服)
                //                {
                //                    MessageBox.Show("客服不允许修改管理员信息");
                //                    Close();
                //                }
                textBox1.Text = kefu.MingCheng;
                txtPwd.Text = kefu.Pwd;
                cbxUserType.Text = kefu.UserType;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
    }
}
