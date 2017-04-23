using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.Dapper
{
    [Serializable]
   public abstract class DbBase
    {
       public long Id { get; set; } 
    }

    [Serializable]
    public abstract class DbIdName: DbBase
    {
        public string DbName { get; set; }
    }
}
