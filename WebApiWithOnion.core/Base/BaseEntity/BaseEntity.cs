using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.core.Base.Base;


namespace WebApiWithOnion.core.Base.Base
{
    public class BaseEntity : IBase
    {
        public int Id { get; set; }
        public bool isDelete { get; set; }
    }
}
