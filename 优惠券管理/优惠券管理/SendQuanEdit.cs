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
            mSendQuan = new HHDapperSql().Query<SendQuan>(id);
        }

        public SendQuanEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SendQuanEdit_Load(object sender, EventArgs e)
        {
            if (mId > 0)
            {

            }
        }
    }
}
