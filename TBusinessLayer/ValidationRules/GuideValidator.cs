using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.GuideName).NotEmpty().WithMessage("Lütfen Rehber Adını Giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Açıklamasını Giriniz");
            RuleFor(x => x.image).NotEmpty().WithMessage("Lütfen Rehber Görselini Giriniz");
            RuleFor(x => x.GuideName).MaximumLength(30).WithMessage("Lütfen 30 Karakteri Aşmayınız Giriniz");
           
        }
    }
}
