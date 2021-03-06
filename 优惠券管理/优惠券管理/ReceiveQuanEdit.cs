﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.Dapper;
using 优惠券管理.Model;

namespace 优惠券管理
{
    public partial class ReceiveQuanEdit : Form
    {
        private SendQuan sendQuan;
        private long mId, mSendQuanId;
        private ReceiveQuan mReceiveQuan;
        public ReceiveQuanEdit()
        {
            InitializeComponent();
        }

        public void Init(long id)
        {
            mId = id;
            mReceiveQuan = new HHDapperSql().Query<ReceiveQuan>(mId);
            mSendQuanId = mReceiveQuan.SendQuanId;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                getSendQuan();
                button1.Focus();
            }
        }


        private void getSendQuan()
        {

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("编号不能为空");
                return;
            }
            var code = txtCode.Text.TrimStart('0');
            if (string.IsNullOrEmpty(code))
            {
                code = "0";
            }
            var sql = "select * from SendQuan where  " + code +">=IntMinCode and " + code + "<=IntMaxCode";

            sendQuan = new HHDapperSql().Query<SendQuan>(sql).FirstOrDefault();
            if (sendQuan == null)
            {
                //                if (MessageBox.Show("没有找到对应的发券记录,是否继续？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                //                    DialogResult.Cancel)
                //                {
                //
                //                }
                MessageBox.Show("没有找到对应的发券记录");
                txtSendDate.Text = "";
                txtAddressName.Text = "";
                txtSendUserName.Text = "";
                return;
            }

            mSendQuanId = sendQuan.Id;
            txtSendDate.Text = sendQuan.SendDate.ToString("yyyy/MM/dd");
            if (sendQuan.AddressId > 0)
            {
                txtAddressName.Text = new HHDapperSql().Query<Address>(sendQuan.AddressId).DbName;
            }
            if (sendQuan.SendUserId > 0)
            {
                var user = new HHDapperSql().Query<SendUser>(sendQuan.SendUserId);
                if (user != null)
                {
                    txtSendUserName.Text = user.DbName;
                }
            }


        }

        private void ReceiveQuanEdit_Load(object sender, EventArgs e)
        {

            JuanKindId.DataSource = new HHDapperSql().Query<JuanKind>("select * from JuanKind order by Id desc");
            JuanKindId.ValueMember = "Id";
            JuanKindId.DisplayMember = "DbName";

            if (mId > 0)
            {
                dateTimePicker1.Value = mReceiveQuan.ReceiveDate;
                JuanKindId.SelectedValue = mReceiveQuan.JuanKindId;
                txtCode.Text = mReceiveQuan.StrCode;
            }
            if (mSendQuanId > 0)
            {
                sendQuan = new HHDapperSql().Query<SendQuan>(mSendQuanId);
                txtSendDate.Text = sendQuan.SendDate.ToString("yyyy/MM/dd");
                txtAddressName.Text = new HHDapperSql().Query<Address>(sendQuan.AddressId).DbName;
                txtSendUserName.Text = new HHDapperSql().Query<SendUser>(sendQuan.SendUserId).DbName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("编号不能为空");
                return;
            }

            var sqlcount = "select count(Id) from ReceiveQuan where StrCode='" + txtCode.Text.Trim() + "'";
            var rcount = Convert.ToInt32(new HHDapperSql().ExecuteScalar(sqlcount));
            if (rcount > 0)
            {
                MessageBox.Show("优惠券号：" + txtCode.Text.Trim() + "  已经回收过，请注意查真伪", "错误优惠券号", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            var code = txtCode.Text.TrimStart('0');
            if (string.IsNullOrEmpty(code))
            {
                code = "0";
            }
            var sql = "select * from SendQuan where  " + code + ">=IntMinCode and " + code + "<=IntMaxCode";

            sendQuan = new HHDapperSql().Query<SendQuan>(sql).FirstOrDefault();
            if (sendQuan == null)
            {
                MessageBox.Show("没有找到对应的发券记录");
                return;
            }

            mSendQuanId = sendQuan.Id;
            if (mReceiveQuan == null)
            {
                mReceiveQuan = new ReceiveQuan();
                mReceiveQuan.SendQuanId = mSendQuanId;
                mReceiveQuan.ReceiveDate = DateTime.Parse(dateTimePicker1.Text);
                mReceiveQuan.StrCode = txtCode.Text.Trim();
                mReceiveQuan.JuanKindId = long.Parse(JuanKindId.SelectedValue.ToString());
            }
            if (mId > 0)
            {
                new HHDapperSql().Update(mReceiveQuan);
            }
            else
            {
                new HHDapperSql().Insert(mReceiveQuan);
            }
            MessageBox.Show("保存成功");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
