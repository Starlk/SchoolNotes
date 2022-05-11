using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.bl.Dto
{
    public class EstudentDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string code { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
