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
    public partial class JiuShuiKindEdit : Form
    {
        private long mId;
        private string mName;
        public void Init(long id,string name)
        {
            mId = id;
            mName = name;
        }

        public JiuShuiKindEdit()
        {
            InitializeComponent();
            AppUtil.SetCommonInitForm(this);
        }

        private void JiuShuiKindEdit_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mName))
            {
                textBox1.Text = mName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kind=new JiuShuiKind();
            kind.DbName = textBox1.Text;
            if (mId > 0)
            {
                kind.Id = mId;
                new HHDapperSql().Update(kind);
            }
            else
            {
                new HHDapperSql().Insert(kind);
            }

            DialogResult=DialogResult.OK;
            Close();
        }
    }
}
