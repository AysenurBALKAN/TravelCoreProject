using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBusinessLayer.ValidationRules
{
 public   class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.EMail).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler Uyumlu değil");
        }
    }
}
