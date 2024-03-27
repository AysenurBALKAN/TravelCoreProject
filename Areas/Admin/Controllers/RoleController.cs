
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEntityLayer.Concrete;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [AllowAnonymous]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager = null)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            AppRole appRole = new AppRole()
            {
                Name = createRoleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(appRole);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleID = values.Id,
                RoleName = values.Name
            };
            return View(updateRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> GetRole(UpdateRoleViewModel updateRoleView)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleView.RoleID);
            values.Name = updateRoleView.RoleName;
            await _roleManager.UpdateAsync(values);
            return RedirectToAction("Index");
        }


        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["Userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
          List<RoleAssignViewModel> roleAssignViewModel = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleID = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignViewModel.Add(model);
             
            }
            return View(roleAssignViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userId =(int)TempData["Userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }

               
            }
            return RedirectToAction("UserList");
        }
    }
}
