using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 优惠券管理.Model
{
    public class SendQuan:DbBase
    {
        public DateTime SendDate { get; set; }

        public long SendUserId { get; set; }//发卷人
        public long AddressId { get; set; }//发卷地点

        public long JuanKindId { get; set; }//优惠券种类

        public string StrMinCode { get; set; }
        public string StrMaxCode { get; set; }

        public long IntMinCode {
            get
            {
                long code;
                var mincode = StrMinCode.TrimStart('0');
                if (long.TryParse(mincode,out code))
                {
                    return code;
                }
                return code;
            }
         }
        public long IntMaxCode
        {
            get
            {
                long code;
                var mincode = StrMaxCode.TrimStart('0');
                if (long.TryParse(mincode, out code))
                {
                    return code;
                }
                return code;
            }
        }

        public long Number => IntMaxCode - IntMinCode + 1;


    }
}
