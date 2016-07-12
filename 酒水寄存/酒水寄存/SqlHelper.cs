using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.Dapper;

namespace 酒水寄存
{
    public class SqlHelper
    {
        public static void SetComboBox<T>(ComboBox box) where T:DbIdName ,new()
        {
            var dmos = new HHDapperSql().QueryIdName<T>().ToList();
            dmos.Insert(0, new T() { Id = 0, DbName = "" });
            box.DataSource = dmos;
            box.ValueMember = "Id";
            box.DisplayMember = "DbName";
        }
    }
}
