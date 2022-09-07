using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class PoliclinicValidator:AbstractValidator<Policlinic>
    {
        public PoliclinicValidator()
        {
            RuleFor(x => x.PoliclinicName).NotEmpty().WithMessage("Poliklinik Adı Boş Geçilemez...");
            RuleFor(x => x.PoliclinicName).MinimumLength(3).WithMessage("Poliklinik Adı 3 Karakterden Az Olamaz...");
        }
    }
}
