
namespace ktv.model
{
    public class HuoDong
    {
        public long Id { get; set; }

        public long HuoDongId { get; set; }
        public string MingCheng { get; set; }

        public string NeiRong { get; set; }
    }
    public class KeFu
    {
        public long Id { get; set; }

        public string MingCheng { get; set; }

        public string Pwd { get; set; }
        public string UserType { get; set; }
       
    }
    
}
