using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class KategoriDogrulama : AbstractValidator<Kategori>
    {
        public KategoriDogrulama()
        {
            RuleFor(x => x.KategoriAd).NotEmpty().WithMessage
                ("Kategori adını boş bırakamazsınız");
            RuleFor(x => x.KategoriTanimlama).NotEmpty().WithMessage
                ("Kategori açıklamasını boş bırakamazsınız");
            RuleFor(x => x.KategoriAd).NotEmpty().MaximumLength(50).WithMessage
                ("Kategori adı en fazla 50 karakter olmalıdır");
            RuleFor(x => x.KategoriAd).NotEmpty().MinimumLength(2).WithMessage
                ("Kategori adı en az 2 karakter olmalıdır");
        }
    }
}
