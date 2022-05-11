using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.bl.Dtos
{
    public class NoteDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsPublic { get; set; }
    }
}
