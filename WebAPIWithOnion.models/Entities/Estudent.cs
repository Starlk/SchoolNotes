using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.core.Base.Base;
using WebApiWithOnion.core.Base.BaseEntity;

namespace WebAPIWithOnion.models.Entity
{
    public class Estudent : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string codde { get; set; }
        public DateTime DateRegister { get; set; }
    

    }
}
