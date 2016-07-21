using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒水寄存
{
    public partial class OverDateManage : Form
    {
        public string AdminName { get; set; }
        public OverDateManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("不能为空");
                return;
            }
            AdminName = textBox1.Text;
            DialogResult=DialogResult.OK;
            Close();
        }
    }
}
