using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class DoctorValidator:AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleFor(x => x.DoctorName).NotEmpty().WithMessage("Doktor Adı Boş Geçilemez...");
            RuleFor(x => x.DoctorName).MinimumLength(3).WithMessage("Doktor Adı 3 Karakterden Az Olamaz...");

            RuleFor(x => x.DoctorSurname).NotEmpty().WithMessage("Doktor Soyadı Boş Geçilemez....");
            RuleFor(x => x.DoctorSurname).MinimumLength(3).WithMessage("Doktor Soyadı 3 Karakterden Az Olamaz....");
        }
    }
}
