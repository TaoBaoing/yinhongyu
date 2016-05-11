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
    }
}
