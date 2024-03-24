using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Abstract.AbstractUnitOfWork;
using TEntityLayer.Concrete;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
          var valueSender=  _accountService.TGetById(model.SenderID);
            var valueReceiver = _accountService.TGetById(model.ReceiverID);
            valueSender.Balance -= model.Amount;
            valueReceiver.Balance += model.Amount;
            List<Account> modifedAccount = new List<Account>()
            {
                valueReceiver,valueSender

            };
            _accountService.TMultiUpdate(modifedAccount);
            return View();
        }
    }
}
