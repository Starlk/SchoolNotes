using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.bl.Dto;

namespace WebApiWithOnion.bl.Validato
{
    public class EstudentValidator : BaseValidator<EstudentDto>
    {
        public EstudentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
            RuleFor(x => x.code)
                .NotEmpty();
            RuleFor(x => x.LastName)
                .NotEmpty();
            RuleFor(x => x.DateRegister)
                .NotEmpty();    
        }
    }
}
