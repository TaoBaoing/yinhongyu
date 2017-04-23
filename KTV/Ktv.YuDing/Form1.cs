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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            var minTime = DateTime.Today.AddDays(-7);

            var sql = "select * from YuDing where 1=1 ";
            if (!string.IsNullOrEmpty(txtXingMing.Text))
            {
                sql += " and XingMing like '%" + txtXingMing.Text + "%'";
            }
            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                sql += " and Phone like '%" + txtPhone.Text + "%'";
            }
            if (dateTimePicker1.Checked)
            {
                sql += " and YuDingTime >= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm") + "'";
            }
            else
            {
                sql += " and  YuDingTime >= '" + minTime + "'";
            }
            if (dateTimePicker2.Checked)
            {
                sql += " and YuDingTime <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm") + "'";
            }
            if (!string.IsNullOrEmpty(FangXing.Text))
            {
                sql += " and FangXing='" + FangXing.Text + "'";
            }

            sql +=" order by YuDingTime desc";
            sql=  sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "").Replace(" 00", "");
//            MessageBox.Show(sql);
                dataGridView1.DataSource = SqlHelper.Query<ktv.model.YuDing>(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f=new EditForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
               BindGridView();
            }
        }

        private void 活动管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new HuoDongList();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDefaultGridView();
            if (AppUtil.KeFu.UserType == "客服")
            {
                客服管理ToolStripMenuItem.Visible = false;
            }
            else if (AppUtil.KeFu.UserType == "管理员")
            {
                客服管理ToolStripMenuItem.Visible = true;
            }
        }

        private void BindDefaultGridView()
        {
            var minTime = DateTime.Today.AddDays(-7);
            var sql = "select * from YuDing where YuDingTime>='"+ minTime + "' order by YuDingTime desc";
            var list = SqlHelper.Query<ktv.model.YuDing>(sql).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var f=new EditForm();
            f.Init(Convert.ToInt64(id));
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DateTime time = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string status = (dataGridView1.Rows[e.RowIndex].Cells[11].Value).ToString();
            if (DateTime.Now <= time.AddMinutes(15) && status == StatusName.预定未来)
            {
            
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Red;
            }
//            if (DateTime.Now > time.AddMinutes(15)&& status==StatusName.预定未来)
//            {
//                //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
//                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
//                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor=Color.Red;
//            }
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
                var sql = "delete from YuDing where Id in (" + inid + ")";
                SqlHelper.Execute(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }

        private void 客服管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new KeFuList();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGridView();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //        DateTime time = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        //        dataGridView1.Rows[e.RowIndex].Cells[3].Value = time.ToString("yyyy/MM/dd hh:mm");

    }
}
