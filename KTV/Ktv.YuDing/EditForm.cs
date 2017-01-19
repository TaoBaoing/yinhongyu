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
    public partial class EditForm : Form
    {
        private long mId = 0;
        private ktv.model.YuDing mYuDing;
        public void Init(long id)
        {
            mId = id;
        }

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            BindHuoDong();

            if (mId > 0)
            {
                var sql = "select * from YuDing where Id=" + mId;
                mYuDing = SqlHelper.Query<ktv.model.YuDing>(sql).FirstOrDefault();
                if (mYuDing == null)
                {
                    MessageBox.Show("参数错误");
                    return;
                }

                Code.Text = mYuDing.Code;
                YuDingTime.Value = mYuDing.YuDingTime;
                XingMing.Text = mYuDing.XingMing;
                Sex.Text = mYuDing.Sex;
                Phone.Text = mYuDing.Phone;
                FangXing.Text = mYuDing.FangXing;
                BaoFangHao.Text = mYuDing.BaoFangHao;
                if (mYuDing.HuoDongId != null)
                {
                    HuoDong.SelectedValue = mYuDing.HuoDongId.ToString();
                    HuoDong.Text = mYuDing.HuoDongName;
                }

                txtKeFu.Text = mYuDing.KeFuName;
                Status.Text = mYuDing.Status;

            }
            else
            {
                txtKeFu.Text = AppUtil.KeFu.MingCheng;
                Status.Text = StatusName.预定未来;
                mYuDing = new ktv.model.YuDing();
                YuDingTime.Value = DateTime.Now;
            }
        }

        private void BindHuoDong()
        {
            var list = SqlHelper.Query<HuoDong>("select * from HuoDong order by Id desc").ToList();

            list.Insert(0, new HuoDong() { Id = 0, MingCheng = "" });
            HuoDong.DataSource = list;
            HuoDong.DisplayMember = "MingCheng";
            HuoDong.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Code.Text))
            {
                MessageBox.Show("预定号不能为空");
                return;
            }
            if (string.IsNullOrEmpty(XingMing.Text))
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (string.IsNullOrEmpty(Phone.Text))
            {
                MessageBox.Show("手机号不能为空");
                return;
            }
            if (string.IsNullOrEmpty(FangXing.Text))
            {
                MessageBox.Show("房型不能为空");
                return;
            }


            mYuDing.Code = Code.Text;
            mYuDing.YuDingTime = Convert.ToDateTime(YuDingTime.Text);
            mYuDing.XingMing = XingMing.Text;
            mYuDing.Sex = Sex.Text;
            mYuDing.Phone = Phone.Text;
            mYuDing.FangXing = FangXing.Text;

            mYuDing.BaoFangHao = BaoFangHao.Text;
            if (HuoDong.SelectedIndex != 0)
            {
                mYuDing.HuoDongId = Convert.ToInt64(HuoDong.SelectedValue);
                mYuDing.HuoDongName = HuoDong.Text;
            }

            mYuDing.KeFuId = AppUtil.KeFu.Id;
            mYuDing.KeFuName = AppUtil.KeFu.MingCheng;

            mYuDing.Status = Status.Text;


            if (mId > 0)
            {
                SqlHelper.Update(mYuDing);
            }
            else
            {
                var today = Convert.ToDateTime(mYuDing.YuDingTime.ToString("yyyy-MM-dd"));
                var tom = today.AddDays(1);
                var maxsql = "select max(TodayId) from YuDing where YuDingTime>='" + today + "' and YuDingTime<'" + tom + "'";
                var maxtid = SqlHelper.ExecuteScalar(maxsql);
                mYuDing.TodayId = Convert.ToInt64(maxtid) + 1;
                SqlHelper.Insert(mYuDing);
            }

            DialogResult = DialogResult.OK;
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            var phone = Phone.Text.Trim();
            if (phone.Length == 11)
            {
                Code.Text = phone.Remove(0, 7);
            }
        }
    }
}
