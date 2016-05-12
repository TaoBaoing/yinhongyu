using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 优惠券管理
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 地址管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new AddressList();
            f.Show();
        }

        private void 发卷人管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SendUserList();
            f.Show();
        }

        private void 优惠券管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new JuanKindList();
            f.Show();
        }

        private void 新增发放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new SendQuanEdit();
            f.Show();
        }

        private void 发放查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new SendQuanList();
            f.Show();
        }

        private void 登记回收ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new ReceiveQuanEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
