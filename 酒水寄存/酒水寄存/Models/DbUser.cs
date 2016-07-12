using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 酒水寄存.Models
{
   public class DbUser:DbIdName
    {
       public string Pwd { get; set; }
       public string UserType { get; set; }

    }

    public class UserType
    {
        public static string 库管 = "库管";
        public static string 客户 = "客户";
        public static string 管理员 = "管理员";

    }
}
