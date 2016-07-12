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
    public partial class UserEdit : Form
    {
        private long mId;
        private DbUser dbUser;
        public void Init(long id)
        {
            mId = id;
        }

        public UserEdit()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxUserType.SelectedIndex == 0)
            {
                MessageBox.Show("必须选择用户类型");
                return;
            }
            dbUser.DbName=  txtName.Text ;
            dbUser.Pwd = txtPwd.Text;
            dbUser.UserType = cbxUserType.Text;
            if (mId > 0)
            {
                new HHDapperSql().Update(dbUser);
            }
            else
            {
                new HHDapperSql().Insert(dbUser);
            }
            DialogResult=DialogResult.OK;
            Close();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            if (mId > 0)
            {
                txtName.Enabled = false;
                dbUser=new HHDapperSql().Query<DbUser>(mId);
                if (dbUser.UserType == UserType.客户 && AppUtil.DbUser.UserType == UserType.管理员)
                {
                    MessageBox.Show("客服不允许修改管理员信息");
                    Close();
                }
                txtName.Text = dbUser.DbName;
                txtPwd.Text = dbUser.Pwd;
                cbxUserType.Text = dbUser.UserType;
            }
            else
            {
                txtName.Enabled = true;
                dbUser =new DbUser();
            }
        }
    }
}
