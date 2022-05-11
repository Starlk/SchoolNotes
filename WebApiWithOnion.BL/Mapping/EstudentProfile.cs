using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.bl.Dto;
using WebApiWithOnion.bl.Dtos;
using WebAPIWithOnion.models.Entity;

namespace WebApiWithOnion.bl.Mapping
{
    public class EstudentProfile : Profile
    {
        public EstudentProfile()
        {
            CreateMap<Estudent, EstudentDto>();
            CreateMap<Note, NoteDto>();
        }
    }
}
