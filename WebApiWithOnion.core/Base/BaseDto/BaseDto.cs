using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.core.Base.BaseDtop
{
    public class BaseDto
    {
        public virtual int? Id { get; set; }
        public virtual bool isDeletet { get; set; } 
    }
}
