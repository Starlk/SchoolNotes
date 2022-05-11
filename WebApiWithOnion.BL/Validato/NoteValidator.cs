using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.bl.Dtos;

namespace WebApiWithOnion.bl.Validato
{
    public class NoteValidator : BaseValidator<NoteDto>
    {
        public NoteValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty();
            RuleFor(x => x.IsPublic)
                .NotEmpty();
        }
    }
}
