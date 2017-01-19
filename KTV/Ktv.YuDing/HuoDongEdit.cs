using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using ktv.model;

namespace Ktv.YuDing
{
    public partial class HuoDongEdit : Form
    {
        private long mId = 0;
        private string mName = "";
        private string mHid = "";
        public void Init(long id, string name,string hid)
        {
            mId = id;
            mName = name;
            mHid = hid;
        }
        public HuoDongEdit()
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
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("活动号不能为空");
                return;
            }

            if (mId > 0)
            {
                var sql = "update HuoDong set MingCheng='" + textBox1.Text + "',HuoDongId='"+txtId.Text+"' where Id=" + mId;
                SqlHelper.Execute(sql);
            }
            else
            {
                var sql = "insert into HuoDong (MingCheng,HuoDongId) values ('" + textBox1.Text + "',"+ txtId.Text + ")";
                SqlHelper.Execute(sql);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void HuoDongEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = mName;
            txtId.Text = mHid;
        }
    }
}
