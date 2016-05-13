using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 优惠券管理.Model
{
    public  class ReceiveQuan:DbBase
    {
        public long SendQuanId { get; set; }

        public DateTime ReceiveDate { get; set; }

        public long JuanKindId { get; set; }

        public string StrCode { get; set; }

        public long IntCode
        {
            get
            {
                long code;
                var mincode = StrCode.TrimStart('0');
                if (long.TryParse(mincode, out code))
                {
                    return code;
                }
                return code;
            }
        }

    }
}
