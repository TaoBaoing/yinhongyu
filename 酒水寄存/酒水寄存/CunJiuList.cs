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

namespace 酒水寄存
{
    public partial class CunJiuList : Form
    {
        public CunJiuList()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
        }

        private void CunJiuList_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BindGridView()
        {

        }

        private void 删除选中项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除选中行吗？", "删除", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count < 1)
                {
                    return;
                }
                var inid = "";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var id = Convert.ToInt64(row.Cells[0].Value);
                    inid = inid + "," + id;
                }
                inid = inid.Remove(0, 1);
                var sql = "delete from CunJiu where Id in (" + inid + ")";
                new HHDapperSql().ExecuteNonQuery(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }
    }
}
