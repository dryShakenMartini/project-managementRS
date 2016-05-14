using Microsoft.AspNet.Mvc;
using ProjectManagementRS.Models;

namespace ProjectManagementRS.Controllers.Web
{
    public class ApplicationController: Controller
    {
        private IUserRepository _userRepository;

        public ApplicationController(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public IActionResult Index()
        {
            var users = _userRepository.FindAll();
            return View();
        }

        public IActionResult Home()
        {
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

        public IActionResult UserDialog()
        {
            return View();
        }
    }
}
