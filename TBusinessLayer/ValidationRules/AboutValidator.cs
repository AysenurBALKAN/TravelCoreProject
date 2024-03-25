using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.ValidationRules
{
   public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
            RuleFor(x => x.image1).NotEmpty().WithMessage("Lütfen Görsel Yükleyiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen En az 50 Karakter Giriniz");
            RuleFor(x => x.Description).MaximumLength(5000).WithMessage("Lütfen Açıklamayı Kısaltınız");
        }
    }
}
