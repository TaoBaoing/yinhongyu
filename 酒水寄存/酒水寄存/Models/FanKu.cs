using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 酒水寄存.Models
{
    public class FanKu : DbBase
    {
        public DateTime CreateDateTime { get; set; }

        public long UserId { get; set; }

        public long KindId { get; set; }

        public string PinMing { get; set; }

        public int Number { get; set; }

    }
}
