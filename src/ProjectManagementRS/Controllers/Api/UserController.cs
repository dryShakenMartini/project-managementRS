using Microsoft.AspNet.Mvc;

namespace ProjectManagementRS.Controllers.Api
{
    [Route("api/users")]
    public class UserController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new { Name = "Rada" });
        }

    }
}
