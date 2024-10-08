using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogDogrulama : AbstractValidator<Blog>
    {
        public BlogDogrulama()
        {
            RuleFor(x => x.BlogBaslik).NotEmpty().WithMessage("Başlığı boş bırakamazsınız");
            RuleFor(x => x.Blogİcerik).NotEmpty().WithMessage("İçeriği boş bırakamazsınız");
            RuleFor(x => x.BlogResim).NotEmpty().WithMessage("Resim alanını boş bırakamazsınız");
            RuleFor(x => x.BlogBaslik).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın");
            RuleFor(x => x.BlogBaslik).MinimumLength(5).WithMessage("Lütfen 4 karakterden daha fazla veri girişi yapın");

        }
    }
}
