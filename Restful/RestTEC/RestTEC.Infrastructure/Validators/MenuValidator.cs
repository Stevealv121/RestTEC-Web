using FluentValidation;
using RestTEC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestTEC.Infrastructure.Validators
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(menu => menu.Name)
                .NotNull()
                .Length(4, 50);
        }
    }
}
