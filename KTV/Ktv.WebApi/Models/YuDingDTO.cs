using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ktv.WebApi.Models
{
    public class YuDingDTO
    {
        public string Id { get; set; }
     
        public string Code { get; set; }
    
        public string YuDingTime { get; set; }
     
        public string XingMing { get; set; }
     
        public string Sex { get; set; }
       
        public string Phone { get; set; }
      
        public string FangXing { get; set; }
      
        public string BaoFangHao { get; set; }
     
        public string HuoDongId { get; set; }

        public string HuoDongName { get; set; }

        public string Status { get; set; } 
    }
}