using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ServiceValidation
{
    public class CreateServiceValidator : AbstractValidator<Service>
    {
        public CreateServiceValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Başlık en fazla 30 karakter olmalıdır");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Açıklama en az 10 karakter olmalıdır");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Açıklama en fazla 200 karakter olabilir");

        }
    }
}
