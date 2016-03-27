using Microsoft.AspNet.Mvc;
using ProjectManagementRS.Models;
using System.Linq;

namespace ProjectManagementRS.Controllers.Web
{
    public class ApplicationController: Controller
    {
        private UsersContext _usersContext;

        public ApplicationController(UsersContext context)
        {
            _usersContext = context;
        }

        public IActionResult Index()
        {
            var users = _usersContext.Users.Count();
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
