using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.core.Base.Base;
using WebApiWithOnion.core.Base.BaseEntity;

namespace WebAPIWithOnion.models.Entity
{
    public class Note : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsPublic { get; set; }
        public DateTime DateCreated { get; set; }
        public int EstudentID { get; set; }
        public Estudent estudent { get; set; }
       
    }
}
