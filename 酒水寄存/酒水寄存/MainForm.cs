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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ColumnHeadersHeightSizeMode= DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        }

        private void SetVisiable()
        {
            if (AppUtil.DbUser.UserType == UserType.库管)
            {
                用户管理ToolStripMenuItem.Visible = false;
                种类管理ToolStripMenuItem.Visible = false;
                button1.Visible = false;
                dataGridView1.Columns["续存"].Visible = false;
                dataGridView1.Columns["取酒"].Visible = false;
                返库管理ToolStripMenuItem.Visible = false;
            }
            else if (AppUtil.DbUser.UserType == UserType.客户)
            {
                用户管理ToolStripMenuItem.Visible = false;
            }
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new UserList();
            f.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 种类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new JiuShuiKindList();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f=new CunJiuEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlHelper.SetComboBox<JiuShuiKind>(cbxKind);

            BindGridView();
            SetVisiable();
            toolCurrentUser.Text = AppUtil.DbUser.DbName;

            var maxDate = DateTime.Today.AddMonths(-6);
            var delSql = "delete from CunJiu where CreateDateTime<'" + maxDate + "'";
            new HHDapperSql().ExecuteNonQuery(delSql);
            delSql= "delete from QuJiu where CreateDateTime<'" + maxDate + "'";
            new HHDapperSql().ExecuteNonQuery(delSql);
            delSql = "delete from FanKu where CreateDateTime<'" + maxDate + "'";
            new HHDapperSql().ExecuteNonQuery(delSql);
        }

        private void BindGridView()
        {
            var sql =
                "select top 1000 c.Id 'CunJiuId',q.Id 'QuJiuId', (case when q.Id is null then '未取' else '已取' end) as '状态',c.CreateDateTime '存酒日期',c.OverDateTime '到期日期',k.DbName '种类',c.Number '数量', c.CardNumber '存酒卡号',c.CunName '客户姓名',c.CunPhone '客户电话',u.DbName '录入人',c.XuCunDateTime '续存日期',xu.DbName '续存操作人',qu.DbName '取酒操作人',q.CreateDateTime '取酒日期',q.OverAdminName '过期取酒管理员' from CunJiu c  left join JiuShuiKind k on c.KindId=k.Id left join DbUser u on c.UserId=u.Id left join DbUser xu on c.XuCunUserId=xu.Id left join QuJiu q on c.Id=q.CunJiuId left join DbUser qu on q.QiuUserId=qu.Id where 1=1 ";

            if (dateTimePicker1.Checked)
            {
                sql += " and c.CreateDateTime>='" + Convert.ToDateTime(dateTimePicker1.Text) + "'";
            }
            if (dateTimePicker2.Checked)
            {
                sql += " and c.CreateDateTime<'" + Convert.ToDateTime(dateTimePicker1.Text).AddDays(1) + "'";
            }
            if (cbxKind.SelectedIndex > 0)
            {
                sql += " and c.KindId='" + cbxKind.SelectedValue + "'";
            }
            if (comboBox1.Text == "未取")
            {
                sql += " and q.Id is null";
            }
            else if (comboBox1.Text == "已取")
            {
                sql += " and q.Id is not null";
            }
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                sql += " and c.CunName like '%"+ txtName.Text.Trim()+ "%'";
            }
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                sql += " and c.CunPhone = '" + txtPhone.Text.Trim()+ "'";
            }
            if (!string.IsNullOrWhiteSpace(txtCardNumber.Text))
            {
                sql += " and c.CardNumber = '" + txtCardNumber.Text.Trim()+ "'";
            }

            sql += " order by c.CreateDateTime desc";
            dataGridView1.DataSource=new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    if (column.Name == "续存")
                    {
                        if (MessageBox.Show("确定续存一个月吗？", "续存", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                            DialogResult.OK)
                        {
                            var cunjiuid =(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                            var sql = "update CunJiu set XuCunDateTime='" + DateTime.Now + "',XuCunUserId='" +
                                      AppUtil.DbUser.Id + "',OverDateTime=dateadd(m,1,OverDateTime) where Id=" + cunjiuid;
                            new HHDapperSql().ExecuteNonQuery(sql);
                            BindGridView();
                        }
                    }
                    else if (column.Name == "取酒")
                    {
                        if (dataGridView1[e.ColumnIndex, e.RowIndex].Value == null ||dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == "已取")
                        {
                            return;
                        }
                        if(MessageBox.Show("确定取酒吗？", "取酒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                            DialogResult.OK)
                        {
                            var cunjiuid =Convert.ToInt64((dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                            var cunjiu=new HHDapperSql().Query<CunJiu>(cunjiuid);
                            if (DateTime.Today > cunjiu.OverDateTime)
                            {
                                var f=new OverDateManage();
                                if (f.ShowDialog() == DialogResult.OK)
                                {
                                    var qujiu = new QuJiu();
                                    qujiu.CreateDateTime = DateTime.Now;
                                    qujiu.CunJiuId = cunjiuid;
                                    qujiu.QiuUserId = AppUtil.DbUser.Id;
                                    qujiu.OverAdminName = f.AdminName;
                                    new HHDapperSql().Insert(qujiu);
                                }
                            }
                            else
                            {
                                var qujiu = new QuJiu();
                                qujiu.CreateDateTime = DateTime.Now;
                                qujiu.CunJiuId = cunjiuid;
                                qujiu.QiuUserId = AppUtil.DbUser.Id;
                                new HHDapperSql().Insert(qujiu);
                            }

                        }
                        BindGridView();
                    }
                    //这里可以编写你需要的任意关于按钮事件的操作~
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

//        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
//        {
//            if (e.RowIndex>0)
//            {
//                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
//                if (column is DataGridViewButtonColumn)
//                {
//                    if (column.Name == "续存")
//                    {
//                        column.ReadOnly = true;
//                    }
//                    //dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly = true;
//                }
//            }
//        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除之后无法恢复", "确认删除?", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }
            if (dataGridView1.Rows.Count < 1)
            {
                return;
            }
            var inid = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var id = Convert.ToInt64(row.Cells[0].Value);
                inid = inid + "," + id;
            }
            inid = inid.Remove(0, 1);
            var sql = "delete from CunJiu where Id in (" + inid + ")";
            var sqlq = "delete from QuJiu where CunJiuId in ("+inid+")";
            new HHDapperSql().ExecuteNonQuery(sql);
            new HHDapperSql().ExecuteNonQuery(sqlq);
            MessageBox.Show("删除成功");
            BindGridView();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var status =dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (status == "已取" )
            {
                if (dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor != Color.Green)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Green;
                    dataGridView1["取酒", e.RowIndex] = new DataGridViewTextBoxCell();
                    dataGridView1["取酒", e.RowIndex].Value = "已取";
                }
            }
            else
            {
                DateTime time = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                if (DateTime.Now > time && dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor != Color.Red)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void 返库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new FanKuList();
            f.Show();
        }
    }
}
