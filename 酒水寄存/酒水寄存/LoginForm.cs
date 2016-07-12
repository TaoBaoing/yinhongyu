using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.Dapper;
using 酒水寄存.Models;

namespace 酒水寄存
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new HHDapperSql().Query<DbUser>("select * from DbUser where DbName='" + txtName.Text + "' and Pwd='" + txtPwd.Text + "'").FirstOrDefault();
            if (user != null)
            {
                AppUtil.DbUser = user;

                var f = new MainForm();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
