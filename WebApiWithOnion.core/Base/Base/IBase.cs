using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.core.Base.Base
{
    public interface IBase
    {
      int Id { get; set; }
       bool isDelete {get;set;}
    }
}
