using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class HospitalValidator : AbstractValidator<Hospital>
    {
        public HospitalValidator()
        {
            RuleFor(x => x.HospitalName).NotEmpty().WithMessage("Hastane Adı Boş Geçilemez...");
            RuleFor(x => x.HospitalName).MinimumLength(3).WithMessage("Hastane Adı 3 Karakterden Az Olamaz...");

        }
    }
}
