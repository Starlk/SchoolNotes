using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.core.Base.Base;

namespace WebAPIWithOnion.models.Entity
{
    internal class Note :Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsPublic { get; set; }
       
    }
}
