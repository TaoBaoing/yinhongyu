using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 酒水寄存.Models
{
    public class QuJiu:DbBase
    {
        public DateTime CreateDateTime { get; set; }
        public long QiuUserId { get; set; }
        public long CunJiuId { get; set; }
        public string OverAdminName { get; set; }
    }
}
