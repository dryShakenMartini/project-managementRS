using System.Web.Http;
using Microsoft.AspNet.Mvc;
using ProjectManagementRS.ApplicationServices;
using System.Collections.Generic;
using ProjectManagementRS.Models;
using System.Linq;

namespace ProjectManagementRS.Controllers.Api
{
    [Route("api/users")]
    public class UsersApiController : ApiController
    {
        private readonly IUserService _userService;
        public UsersApiController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.FindAll().ToList();
        }
        
        [HttpGet]
        [Route("columns")]
        public List<object> GetUsersColumns()
        {
            return new List<object> {
              new { field= "userName", displayName= "User Name", width = 100 },
              new { field= "name", displayName= "Name", width = 100 },
              new { field= "surname", displayName= "Surname", width = 100 },
              new { field= "email", displayName= "Email", width = 100 },
              new { field= "isActive", displayName= "Is Active", width = 100 },
              new { field= "actions", displayName= "Actions", width = 100,
                  cellTemplate = @"<div class=""glyphicon glyphicon-wrench"" ng-click=editUser()></div> <div class = ""glyphicon glyphicon-trash"" ng-click=deleteUser()></div>" },

            };
        }
    }
}
