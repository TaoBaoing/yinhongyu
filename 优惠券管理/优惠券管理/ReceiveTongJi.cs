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

namespace 优惠券管理
{
    public partial class ReceiveTongJi : Form
    {
        public ReceiveTongJi()
        {
            InitializeComponent();
        }

        private void ReceiveTongJi_Load(object sender, EventArgs e)
        {
            cbxYear.Items.Add(DateTime.Now.Year);
            cbxYear.Items.Add(DateTime.Now.Year-1);
            cbxYear.Text = DateTime.Now.Year.ToString();

            cbxMonth.Text = DateTime.Now.Month+ "月";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var minDate = new DateTime(int.Parse(cbxYear.Text),int.Parse(cbxMonth.Text.Replace("月","")),1);
            var maxDate = new DateTime(int.Parse(cbxYear.Text),int.Parse(cbxMonth.Text.Replace("月","")),1).AddMonths(1);

            var sendNumberSql = "select  sum(Number) from SendQuan where SendDate>='" + minDate + "' and SendDate<'" +
                             maxDate + "'";

            var receiveNumberSql = "select count(Id) from ReceiveQuan  where ReceiveDate>='" + minDate +
                                "' and ReceiveDate<'" +
                                maxDate + "'";

            var sendNumber = new HHDapperSql().ExecuteScalar<int>(sendNumberSql);
            var receiveNumber = new HHDapperSql().ExecuteScalar<int>(receiveNumberSql);

            var lv =Math.Round(((1.0) * receiveNumber / sendNumber * 100),2) ;

            textBox1.Text = sendNumber.ToString();
            textBox2.Text = receiveNumber.ToString();
            textBox3.Text = lv + "%";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
