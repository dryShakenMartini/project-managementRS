using Microsoft.AspNet.Mvc;
using ProjectManagementRS.Models;
using System.Linq;

namespace ProjectManagementRS.Controllers.Web
{
    public class ApplicationController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            //var users = _usersContext.Users.ToList();
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Time()
        {
            return View();
        }
    }
}
