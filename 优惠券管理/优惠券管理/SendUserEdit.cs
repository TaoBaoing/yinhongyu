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

namespace 优惠券管理
{
    public partial class SendUserEdit : Form
    {
        private long mId;
        private string mDbName;

        public void Init(long id, string dbName)
        {
            mId = id;
            mDbName = dbName;
        }
        public SendUserEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("不能为空");
                return;
            }
            if (mId == 0)
            {
                var sql = "insert into SendUser (DbName) values ('" + textBox1.Text + "')";
                new HHDapperSql().ExecuteNonQuery(sql);
            }
            else
            {
                var sql = "update SendUser set DbName='" + textBox1.Text + "' where Id=" + mId;
                new HHDapperSql().ExecuteNonQuery(sql);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SendUserEdit_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mDbName))
            {
                textBox1.Text = mDbName;
            }
        }
    }
}
