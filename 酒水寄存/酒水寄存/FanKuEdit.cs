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
    public partial class FanKuEdit : Form
    {
        private long mId;
        private FanKu mFanKu;
        public FanKuEdit()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
        }

        public void Init(long id)
        {
            mId = id;
        }

        private void FanKuEdit_Load(object sender, EventArgs e)
        {
            
            if (mId > 0)
            {
                mFanKu=new HHDapperSql().Query<FanKu>(mId);
                dateTimePickerStart.Value = mFanKu.CreateDateTime;
                txtUserName.Text=new HHDapperSql().Query<DbUser>(mFanKu.UserId).DbName;
                txtPinMing.Text = mFanKu.PinMing;

                txtNumber.Text = mFanKu.Number.ToString();
            }
            else
            {
                mFanKu=new FanKu();
                txtUserName.Text = AppUtil.DbUser.DbName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(txtNumber.Text, out number))
            {
                MessageBox.Show("数量不是整数");
                return;
            }
            mFanKu.CreateDateTime = Convert.ToDateTime(dateTimePickerStart.Text);
           
            if (mId < 1)
            {
                mFanKu.UserId = AppUtil.DbUser.Id;
            }

            mFanKu.PinMing = txtPinMing.Text.Trim();
            mFanKu.Number = Convert.ToInt32(number);

            if (mId > 0)
            {
               new HHDapperSql().Update(mFanKu);
            }
            else
            {
                new HHDapperSql().Insert(mFanKu);
            }
            DialogResult=DialogResult.OK;
            Close();
        }
    }
}
