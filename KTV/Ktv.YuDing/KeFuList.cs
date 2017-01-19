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
    public partial class KeFuList : Form
    {
        public KeFuList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void 添加客服ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new KeFuEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }
        private void BindGridView()
        {
            var sql = "select * from KeFu order by MingCheng ";
            var list = SqlHelper.Query<KeFu>(sql);
            dataGridView1.DataSource = list;
        }

        private void KeFuList_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value;

            var f = new KeFuEdit();
            f.Init(Convert.ToInt64(id), name.ToString());
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
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
                var sql = "delete from KeFu where Id in (" + inid + ")";
                SqlHelper.Execute(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }
    }
}
