using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace HH.Dapper
{
    public class HHDapper
    {
        protected DbConnection DbConnection { get; set; }

        public HHDapper()
        {
        }

        public HHDapper(DbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }

        public virtual void Update(object model)
        {
            using (DbConnection)
            {
                var sql = GetUpdatesql(model);
                sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "");
                DbConnection.Execute(sql);
            }
        }

        protected string GetUpdatesql(object model)
        {
            var tableName = model.GetType().Name;
            var sb = new StringBuilder("update " + tableName + " set ");
            long id = 0;
            PropertyInfo[] tempInfo = model.GetType().GetProperties();
            foreach (PropertyInfo info in tempInfo)
            {
                if (info.EHasNotMappedAttribute())
                {
                    continue;
                }
                //                var proname = SqlTool.GetColumnTypeName(info);
                string proname = info.EGetColumnTypeName();
                object namevalue = info.GetValue(model, null); //属性的值
                string name = info.Name; //属性的名字
                if (namevalue != null && name.ToLower() != "id")
                {
                    switch (proname.ToLower())
                    {
                        case "int64":
                        case "int32":
                        case "decimal":
                        case "byte":
                        case "double":
                        case "single":
                        case "long":
                            sb.Append("[" + name + "]=" + namevalue + " ,");
                            break;
                        case "bool":
                        case "boolean":
                            if ((bool)namevalue)
                            {
                                sb.Append("[" + name + "]= '1',");
                            }
                            else
                            {
                                sb.Append("[" + name + "]= '0',");
                            }
                            break;
                        case "string":
                            sb.Append(@"[" + name + "]=N'" + namevalue.ToString().Replace('\'', '^') + "'" + " ,");
                            break;
                        case "datetime":
                            sb.Append("[" + name + "]='" + Convert.ToDateTime(namevalue).ToString("yyyy-MM-dd") + "' ,");
                            break;
                        default:
                            sb.Append(name + "='" + namevalue + "' ,");
                            break;
                    }
                }
                if (name.ToLower() == "id")
                {
                    id = long.Parse(info.GetValue(model, null).ToString());
                }
            }
            sb.Remove(sb.Length - 1, 1); //去掉最后一个逗号
            sb.Append("where id=" + id);
            return sb.ToString();
        }

        public virtual long Insert<T>(T dmo)
        {
            using (DbConnection)
            {
                var sql = GetInsertsql(dmo);

                sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "");

                //          using (var sw=new StreamWriter("log.txt",true))
                //          {
                //              sw.WriteLine(sql);
                //          }
                return DbConnection.ExecuteScalar<long>(sql);
            }
        }

        protected string GetInsertsql(object model)
        {
//          MessageBox.Show("1");
            #region 拼凑sql语句
            var tableName = model.GetType().Name;
            var sb = new StringBuilder("insert into " + tableName + "  (");
            PropertyInfo[] tempInfo = model.GetType().GetProperties();
            foreach (PropertyInfo info in tempInfo)
            {
                //如果有NotMapped(不创建) 或者ReferenceToJoin不为空(引用) 则跳过
                if (info.EHasNotMappedAttribute())
                {
                    continue;
                }
                object namevalue = info.GetValue(model, null);
                string name = info.Name;
                if (namevalue != null && name.ToLower() != "id")
                {
                    sb.Append("[" + name + "] ,");
                }
            }
            sb.Remove(sb.Length - 1, 1); //去掉最后一个逗号
            sb.Append(") values (");
            foreach (PropertyInfo info in tempInfo)
            {
                //如果有NotMapped(不创建) 或者ReferenceToJoin不为空(引用) 则跳过
                if (info.EHasNotMappedAttribute())
                {
                    continue;
                }
                string proname = info.EGetColumnTypeName();
                object namevalue = info.GetValue(model, null);
                if (namevalue != null && info.Name.ToLower() != "id")
                {
                    switch (proname.ToLower())
                    {
                        case "int64":
                        case "int32":
                        case "decimal":
                        case "byte":
                        case "double":
                        case "single":
                        case "long":
                            sb.Append(namevalue + " ,");
                            break;
                        case "string":
                            sb.Append(@"N'" + namevalue.ToString().Replace('\'', '^') + "'" + " ,");
                            break;
                        case "datetime":
                            sb.Append(@"'" + Convert.ToDateTime(namevalue).ToString("yyyy-MM-dd")  + "'" + " ,");
                            break;
                        case "bool":
                        case "boolean":
                            if ((bool)namevalue)
                            {
                                sb.Append("'1'" + " ,");
                            }
                            else
                            {
                                sb.Append("'0'" + " ,");
                            }

                            break;
                        default:
                            sb.Append(@"N'" + namevalue + "'" + " ,");
                            break;
                    }
                }
            }
            sb.Remove(sb.Length - 1, 1); //去掉最后一个逗号
            sb.Append(")");
            sb.Append(" SELECT CAST(scope_identity() AS bigint)");
            #endregion

//          MessageBox.Show(sb.ToString());
            return sb.ToString();

        }

        #region  orm 查询
        //var dog = connection.Query<Dog>("select Age = @Age, Id = @Id",new{Age=(int?)null,Id= guid });

        //var sql =
        //@"select * from #Posts p 
        //left join #Users u on u.Id = p.OwnerId 
        //Order by p.Id";
        // var data = connection.Query<Post, User, Post>(sql, (post, user) => { post.Owner = user; return post; });
        public IEnumerable<dynamic> Query(string sql)
        {
            using (DbConnection)
            {
                return DbConnection.Query(sql);
            }
        }

        public T Query<T>(long id) where T : DbBase
        {
            using (DbConnection)
            {
                var tableName = typeof(T).Name;
                var sql = "select * from " + tableName + " where Id=" + id;
                return DbConnection.Query<T>(sql).FirstOrDefault();
            }
        }
        public IEnumerable<T> Query<T>(string sql) where T : DbBase
        {
            using (DbConnection)
            {
                return DbConnection.Query<T>(sql);
            }
        }
        public IEnumerable<T> Query<T>(bool isDesc = true) where T : DbBase
        {
            using (DbConnection)
            {
                var sql = "select * from " + typeof(T).Name + " order by Id";
                if (isDesc)
                {
                    sql += " desc";
                }
                return DbConnection.Query<T>(sql);
            }
        }

        public IEnumerable<T> QueryIdName<T>(bool isDesc = true, string sql = "") where T : DbIdName
        {
            using (DbConnection)
            {
                if (!string.IsNullOrWhiteSpace(sql))
                {
                    return DbConnection.Query<T>(sql);
                }
                else
                {
                    sql = "select * from " + typeof(T).Name + " order by Id ";
                    if (isDesc)
                    {
                        sql += " desc";
                    }
                    return DbConnection.Query<T>(sql);
                }
            }
        }

        #endregion

        #region  执行简单sql


        public int ExecuteNonQuery(string sql)
        {
            using (DbConnection)
            {
                return DbConnection.Execute(sql);
            }
        }
        public object ExecuteScalar(string sql)
        {
            using (DbConnection)
            {
                return DbConnection.ExecuteScalar(sql);
            }
        }
        public T ExecuteScalar<T>(string sql)
        {
            using (DbConnection)
            {
                return DbConnection.ExecuteScalar<T>(sql);
            }
        }
        public virtual IDataReader ExecuteReader(string sql)
        {
            using (DbConnection)
            {
                return DbConnection.ExecuteReader(sql);
            }
        }


        #endregion
    }
}
