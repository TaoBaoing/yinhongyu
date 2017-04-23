using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.Dapper
{
    public class HHDapperSql : HHDapper
    {
        public HHDapperSql(string connectionStr) : base(new SqlConnection(connectionStr))
        {
        }

        public HHDapperSql()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            DbConnection = new SqlConnection(connectionStr);
        }

        public override IDataReader ExecuteReader(string sqlString)
        {
            return (SqlDataReader)base.ExecuteReader(sqlString);
        }

        public DataSet ExecuteDataSet(string sqlString)
        {
            sqlString= sqlString.Replace(" 00:00 00", "").Replace(" 0:00:00", "");
            using (DbConnection)
            {
                var ds = new DataSet();
                var sda = new SqlDataAdapter(sqlString, (SqlConnection)DbConnection);
                sda.Fill(ds);
                return ds;
            }
        }
    }
}
