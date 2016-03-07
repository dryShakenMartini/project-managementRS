using Microsoft.AspNet.Mvc;

namespace ProjectManagementRS.Controllers.Web
{
    public class ApplicationController: Controller
    {
        public IActionResult Index()
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
    }
}
