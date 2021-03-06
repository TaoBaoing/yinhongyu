﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.Dapper;
using 优惠券管理.Model;

namespace 优惠券管理
{
    public partial class SendUserList : Form
    {
        public SendUserList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
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
                var sql = "delete from SendUser where Id in (" + inid + ")";
                new HHDapperSql().ExecuteNonQuery(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }
        private void BindGridView()
        {
            IEnumerable<SendUser> datas = new HHDapperSql().Query<SendUser>("select * from SendUser order by Id desc");
            dataGridView1.DataSource = datas;
        }
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SendUserEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }

        private void SendUserList_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var dbName = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            var f = new SendUserEdit();
            f.Init(Convert.ToInt64(id), dbName.ToString());
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }
    }
}
