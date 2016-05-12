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
using 优惠券管理.Model;

namespace 优惠券管理
{
    public partial class SendQuanList : Form
    {
        public SendQuanList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void SendQuanList_Load(object sender, EventArgs e)
        {
            BindDatas();
            BindGridView();
        }

        private void BindDatas()
        {
            var users=new HHDapperSql().Query<SendUser>("select * from SendUser order by Id desc").ToList();
            users.Insert(0,new SendUser() {Id=0,DbName = ""});
            SendUserId.DataSource = users;
            SendUserId.ValueMember = "Id";
            SendUserId.DisplayMember = "DbName";


            var addresses = new HHDapperSql().Query<Address>("select * from Address order by Id desc").ToList();
            addresses.Insert(0, new Address() { Id = 0, DbName = "" });
            AddressId.DataSource = addresses;
            AddressId.ValueMember = "Id";
            AddressId.DisplayMember = "DbName";

            var juanKinds = new HHDapperSql().Query<JuanKind>("select * from JuanKind order by Id desc").ToList();
            juanKinds.Insert(0, new JuanKind() { Id = 0, DbName = "" });
            JuanKindId.DataSource = juanKinds;
            JuanKindId.ValueMember = "Id";
            JuanKindId.DisplayMember = "DbName";


        }

        private void BindGridView()
        {
            var sql =
                "select top 50  sq.Id,sq.SendDate,su.DbName as 'SendUserName',ad.DbName as 'AddressName',jk.DbName as 'JuanKindName', sq.StrMinCode,sq.StrMaxCode,sq.Number from SendQuan sq left join SendUser su on sq.SendUserId=su.Id left join Address ad on sq.AddressId=ad.Id left join JuanKind jk on sq.JuanKindId=jk.Id where 1=1 ";
            if (dateTimePicker1.Checked)
            {
                sql += " and sq.SendDate>='" + DateTime.Parse(dateTimePicker1.Text) + "'";
            }
            if (dateTimePicker2.Checked)
            {
                sql += " and sq.SendDate<='" + DateTime.Parse(dateTimePicker2.Text) + "'";
            }
            if (!string.IsNullOrEmpty(SendUserId.Text))
            {
                sql += " and sq.SendUserId='" + SendUserId.SelectedValue + "'";
            }
            if (!string.IsNullOrEmpty(AddressId.Text))
            {
                sql += " and sq.AddressId='" + AddressId.SelectedValue + "'";
            }
            if (!string.IsNullOrEmpty(JuanKindId.Text))
            {
                sql += " and sq.JuanKindId='" + JuanKindId.SelectedValue + "'";
            }

            dataGridView1.DataSource = new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var f = new SendQuanEdit();
            f.Init(Convert.ToInt64(id));
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
                var sql = "delete from SendQuan where Id in (" + inid + ")";
                new HHDapperSql().ExecuteNonQuery(sql);
                MessageBox.Show("删除成功");
                BindGridView();
            }
        }
    }
}
