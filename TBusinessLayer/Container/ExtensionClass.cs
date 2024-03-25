using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TBusinessLayer.Abstract.AbstractUnitOfWork;
using TBusinessLayer.Concrete;
using TBusinessLayer.Concrete.UOWConcrete;
using TBusinessLayer.ValidationRules;
using TDataAccesLayer.Abstract;
using TDataAccesLayer.EntityFramework;
using TDataAccesLayer.UnitOfWork;

namespace TBusinessLayer.Container
{
   public static class  ExtensionClass
    {
        public static void ContaninerDependencies( this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfComment>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>(); 
            services.AddScoped<IReservatonService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>(); 
            services.AddScoped<IExcelService, ExcelManager>(); 
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUs, EfContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

        }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
