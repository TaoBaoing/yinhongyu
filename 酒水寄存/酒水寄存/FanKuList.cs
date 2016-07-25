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
    public partial class FanKuList : Form
    {
        public FanKuList()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
            AppUtil.SetDataGridView(dataGridView1);
        }

        private void FanKuList_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            var sql =
                "select f.CreateDateTime,u.DbName 'UName',k.DbName 'KName',Number from FanKu f left join DbUser u on f.UserId=u.Id left join JiuShuiKind k on f.KindId=k.Id where 1=1 ";
            if (dateTimePicker1.Checked)
            {
                sql += " and f.CreateDateTime>='" + Convert.ToDateTime(dateTimePicker1.Text + "'");
            }
            if (dateTimePicker2.Checked)
            {
                sql += " and f.CreateDateTime<'" + Convert.ToDateTime(dateTimePicker2.Text + "'").AddDays(1);
            }
            if (cbxKind.SelectedIndex > 0)
            {
                sql += " and f.KindId='" + cbxKind.SelectedValue + "'";
            }
            var table = new HHDapperSql().ExecuteDataSet(sql).Tables[0];
            dataGridView1.DataSource= table.DefaultView;

            int number = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var n = Convert.ToInt32(table.Rows[i]["Number"]);
                number += n;
            }
            label5.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f=new FanKuEdit();
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
                var sql = "delete from FanKu where Id in (" + inid + ")";
                new HHDapperSql().ExecuteNonQuery(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }
    }
}
