using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Duyuru İçeriği Boş Geçilemez.");
        }
    }
}
