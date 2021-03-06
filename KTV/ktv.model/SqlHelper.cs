﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Dapper;
using ktv.model;

namespace ktv.model
{
  public class SqlHelper
  {
    //北行
    //        private static string strCon = "server=192.168.0.28;database=KtvYuDing;uid=sa;pwd=123";

    //珍惜现在
    private static string strCon = @"Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=KtvYuDing;Data Source=.";
    //        private static string strCon = @"server=.;database=KtvYuDing;uid=sa;pwd=bwp2011!@#";



    //        private static string strCon = @"Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=KtvYuDing;Data Source=.\SQLEXPRESS";

    public static int Execute(string sql)
    {
//      sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "").Replace(" 00", "");
      using (var con = new SqlConnection(strCon))
      {
        return con.Execute(sql, null);
      }
    }

    public static object ExecuteScalar(string sql)
    {
//      sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "").Replace(" 00", "");
      using (var con = new SqlConnection(strCon))
      {
        return con.ExecuteScalar(sql, null, null, null, null);
      }
    }

    public static IEnumerable<T> Query<T>(string sql)
    {
//      sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "").Replace(" 00", "");
      using (var con = new SqlConnection(strCon))
      {
        return con.Query<T>(sql, null);
      }
    }

    public static long Insert<T>(T dmo)
    {
      using (var con = new SqlConnection(strCon))
      {
        var sql = GetInsertsql(dmo);
//        MessageBox.Show(sql);
//        sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "").Replace(" 00", "");
        return Convert.ToInt64(con.ExecuteScalar(sql, null, null, null, null));
      }
    }

    protected static string GetInsertsql(object model)
    {
      #region 拼凑sql语句
      var tableName = model.GetType().Name;
      var sb = new StringBuilder("insert into " + tableName + "  (");
      PropertyInfo[] tempInfo = model.GetType().GetProperties();
      foreach (PropertyInfo info in tempInfo)
      {

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
              sb.Append(@"'" + Convert.ToDateTime(namevalue).ToString("yyyy-MM-dd HH:mm") + "'" + " ,");
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
      return sb.ToString();
    }


    public static void Update(object model)
    {
      using (var con = new SqlConnection(strCon))
      {
        var sql = GetUpdatesql(model);
        sql = sql.Replace(" 00:00 00", "").Replace(" 0:00:00", "").Replace(" 00", "");
        con.Execute(sql, null, null, null, null);
      }
    }

    protected static string GetUpdatesql(object model)
    {
      var tableName = model.GetType().Name;
      var sb = new StringBuilder("update " + tableName + " set ");
      long id = 0;
      PropertyInfo[] tempInfo = model.GetType().GetProperties();
      foreach (PropertyInfo info in tempInfo)
      {
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
              sb.Append("[" + name + "]='" + Convert.ToDateTime(namevalue).ToString("yyyy-MM-dd HH:mm") + "' ,");
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


  }
}
