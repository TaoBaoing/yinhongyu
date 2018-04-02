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
    public partial class CunJiuEdit : Form
    {
        private long mId;
        private CunJiu mDmo;
        public CunJiuEdit()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
        }

        public void Init(long id)
        {
            mId = id;
        }

        private void CunJiuEdit_Load(object sender, EventArgs e)
        {
            dateTimePickerEnd.Value=DateTime.Now.AddMonths(1);
            SqlHelper.SetComboBox<JiuShuiKind>(cboxKind);

            if (mId > 0)
            {
                mDmo=new HHDapperSql().Query<CunJiu>(mId);
                dateTimePickerStart.Text = mDmo.CreateDateTime.ToString();
                dateTimePickerEnd.Text = mDmo.OverDateTime.ToString();
                txtCardNumber.Text = mDmo.CardNumber;
                txtUserName.Text =new HHDapperSql().Query<DbUser>(mDmo.UserId).DbName ;
                txtCunName.Text = mDmo.CunName;
                txtCunPhone.Text = mDmo.CunPhone;
                cboxKind.Text= new HHDapperSql().Query<JiuShuiKind>(mDmo.KindId).DbName;
                txtNumber.Text = mDmo.Number.ToString();
            }
            else
            {
                mDmo=new CunJiu();
                txtUserName.Text = AppUtil.DbUser.DbName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(txtNumber.Text, out number))
            {
                MessageBox.Show("数量必须是整数");
                return;
            }
            if (cboxKind.SelectedIndex == 0)
            {
                MessageBox.Show("没有选择种类");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text)||string.IsNullOrWhiteSpace(txtCunName.Text)||string.IsNullOrWhiteSpace(txtCunPhone.Text)||string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("信息录入不完整");
                return;
            }

            mDmo.KindId = Convert.ToInt64(cboxKind.SelectedValue);
            mDmo.CardNumber = txtCardNumber.Text;
     
            mDmo.CreateDateTime = Convert.ToDateTime(dateTimePickerStart.Text);
            mDmo.OverDateTime = Convert.ToDateTime(dateTimePickerEnd.Text);
//          MessageBox.Show(dateTimePickerStart.Text + "");
      //          mDmo.CreateDateTime = (dateTimePickerStart.Value);
      //            mDmo.OverDateTime = (dateTimePickerEnd.Value);
      if (mId == 0)
            {
                mDmo.UserId = AppUtil.DbUser.Id;
            }
            mDmo.CunName = txtCunName.Text;
            mDmo.CunPhone = txtCunPhone.Text;
            mDmo.Number = number;

            if (mId > 0)
            {
                new HHDapperSql().Update(mDmo);
            }
            else
            {
                new HHDapperSql().Insert(mDmo);
            }
            DialogResult=DialogResult.OK;
            MessageBox.Show("保存成功");
            Close();
        }
    }
}
