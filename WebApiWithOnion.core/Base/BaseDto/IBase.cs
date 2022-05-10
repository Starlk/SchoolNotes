using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.core.Base.Base
{
    public interface IBase
    {
        public int Id { get; set; }
        public bool isDelete {get;set;}
    }
}
