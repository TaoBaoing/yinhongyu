using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 酒水寄存.Models
{
   public  class CunJiu:DbBase
    {
       public DateTime CreateDateTime { get; set; }
        public DateTime OverDateTime { get; set; }
        public long UserId { get; set; }
        public long KindId { get; set; }

       public int Number { get; set; }

       public string CunName { get; set; }
       public string CunPhone { get; set; }

        public DateTime? XuCunDateTime { get; set; }
        public long? XuCunUserId { get; set; }

        public string CardNumber { get; set; }

    }
}
