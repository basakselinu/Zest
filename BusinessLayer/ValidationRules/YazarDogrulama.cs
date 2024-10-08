using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class YazarDogrulama : AbstractValidator<Yazar>
    {
        public YazarDogrulama()
        {
            RuleFor(x => x.YazarAd).NotEmpty().WithMessage("Ad ve Soyadı alanı boş bırakılamaz.");
            RuleFor(x => x.YazarMail).NotEmpty().WithMessage("E-posta adresi boş bırakılamaz.");
            RuleFor(x => x.YazarSifre).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(x => x.YazarAd).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.YazarAd).MaximumLength(25).WithMessage("Lütfen en fazla 25 karakterlik girişi yapın.");
        }
    }
}
