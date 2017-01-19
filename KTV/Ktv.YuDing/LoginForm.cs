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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kefu = SqlHelper.Query<KeFu>("select * from KeFu where MingCheng='" + txtName.Text + "' and Pwd='" + txtPwd.Text + "'").FirstOrDefault();
            if (kefu != null)
            {
                AppUtil.KeFu = kefu;
                var f = new Form1();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }
    }
}
