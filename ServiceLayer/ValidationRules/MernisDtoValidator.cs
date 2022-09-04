using CoreLayer.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ValidationRules
{
    public class MernisDtoValidator : AbstractValidator<MernisDto>
    {
        public MernisDtoValidator()
        {
            RuleFor(x => x.TCKNo).NotEmpty().GreaterThan(10000000000);
            RuleFor(x => x.BirthYear).NotEmpty().GreaterThan(1923);
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.Surname).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);

        }
    }
}
