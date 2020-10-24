using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportsManagementSystem.Models;

namespace SportsManagementSystem.Controllers
{
    public class DevController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public DevController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult SetUserRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SetUserRole(SetUserRoleModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);

            var result = await userManager.AddToRoleAsync(user, model.RoleName);

            return View();
        }
    }
}
