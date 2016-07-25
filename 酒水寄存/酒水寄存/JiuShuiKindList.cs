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
    public partial class JiuShuiKindList : Form
    {
        public JiuShuiKindList()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
            AppUtil.SetDataGridView(dataGridView1);
        }

        private void JiuShuiKindList_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            dataGridView1.DataSource = new HHDapperSql().Query<JiuShuiKind>();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new JiuShuiKindEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            var f = new JiuShuiKindEdit();
            f.Init(Convert.ToInt64(id), name.ToString());
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }

        }

        private void 删除选中ToolStripMenuItem_Click(object sender, EventArgs e)
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
                var sql = "delete from JiuShuiKind where Id in (" + inid + ")";
                new HHDapperSql().ExecuteNonQuery(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }
    }
}
