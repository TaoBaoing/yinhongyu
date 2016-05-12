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
    public partial class SendQuanEdit : Form
    {
        private long mId;
        private SendQuan mSendQuan;
        public void Init(long id)
        {
            mId = id;
        }

        public SendQuanEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StrMinCode.Text))
            {
                MessageBox.Show("起始号不能为空");
                return;
            }
            if (string.IsNullOrEmpty(StrMaxCode.Text))
            {
                MessageBox.Show("结束号不能为空");
                return;
            }

            mSendQuan.SendDate = DateTime.Parse(SendDate.Text);
            mSendQuan.AddressId = long.Parse(AddressId.SelectedValue.ToString());
            mSendQuan.SendUserId = long.Parse(SendUserId.SelectedValue.ToString());
            mSendQuan.JuanKindId = long.Parse(JuanKindId.SelectedValue.ToString());
            mSendQuan.StrMinCode = StrMinCode.Text;
            mSendQuan.StrMaxCode = StrMaxCode.Text;

            if (mId > 0)
            {
                new HHDapperSql().Update(mSendQuan);
            }
            else
            {
                new HHDapperSql().Insert(mSendQuan);
            }
            MessageBox.Show("保存成功");
            DialogResult=DialogResult.OK;
            Close();
        }

        private void SendQuanEdit_Load(object sender, EventArgs e)
        {
            BindDatas();

        }

        private void BindDatas()
        {
            AddressId.DataSource = new HHDapperSql().Query<Address>("select * from Address order by Id desc");
            AddressId.ValueMember = "Id";
            AddressId.DisplayMember = "DbName";

            SendUserId.DataSource = new HHDapperSql().Query<SendUser>("select * from SendUser order by Id desc");
            SendUserId.ValueMember = "Id";
            SendUserId.DisplayMember = "DbName";

            JuanKindId.DataSource = new HHDapperSql().Query<JuanKind>("select * from JuanKind order by Id desc");
            JuanKindId.ValueMember = "Id";
            JuanKindId.DisplayMember = "DbName";

            if (mId > 0)
            {
                mSendQuan = new HHDapperSql().Query<SendQuan>(mId);
                SendDate.Value = mSendQuan.SendDate;
                AddressId.SelectedValue = mSendQuan.AddressId;
                SendUserId.SelectedValue = mSendQuan.SendUserId;
                JuanKindId.SelectedValue = mSendQuan.JuanKindId;
                StrMinCode.Text = mSendQuan.StrMinCode;
                StrMaxCode.Text = mSendQuan.StrMaxCode;
            }
            else
            {
                mSendQuan = new SendQuan();
            }

        }
    }
}
