using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>

    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Author Name Cannot Be Blank");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Email Address Cannot Be Empty");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter at least 2 characters");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Please enter data of up to 50 characters");

        }
    }
}
