using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SportsManagementSystem.Controllers
{
    public class ReportsController : Controller
    {
        [Authorize(Roles = "EventManager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
