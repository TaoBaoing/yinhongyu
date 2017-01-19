using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ktv.model
{
    public class YuDing
    {
        public long Id { get; set; }

        //当天单号
        public long TodayId { get; set; }

        //[Display(Name = "预定号")]
        public string Code { get; set; }

       // [Display(Name = "预定时间")]
        public DateTime YuDingTime { get; set; }

        //[Display(Name = "姓名")]
        public string XingMing { get; set; }

       // [Display(Name = "性别")]
        public string Sex { get; set; }

       // [Display(Name = "手机号码")]
        public string Phone { get; set; }

        //[Display(Name = "房型")]
        public string FangXing { get; set; }

       // [Display(Name = "包房号")]
        public string BaoFangHao { get; set; }

        //[Display(Name = "活动")]
      //  [ForeignKey("HuoDong")]
        public long? HuoDongId { get; set; }

        public string HuoDongName { get; set; }

        public long? KeFuId { get; set; }
        public string KeFuName { get; set; }

       // [Display(Name = "状态")]
        public string Status { get; set; } = StatusName.预定未来;

    }


}
