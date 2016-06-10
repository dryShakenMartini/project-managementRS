using System.Web.Http;
using Microsoft.AspNet.Mvc;
using ProjectManagementRS.ApplicationServices;
using System.Collections.Generic;
using ProjectManagementRS.Models;
using System.Linq;
using ProjectManagementRS.Dtos;
using System.Net.Http;
using System.Net;

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
              new { field= "startDate", displayName= "StartDate", width = 100 },
              new { field= "endDate", displayName= "EndDate", width = 100 },
              new { field= "email", displayName= "Email", width = 100 },
              new { field= "isActive", displayName= "Is Active", width = 100 },
              new { field= "actions", displayName= "Actions", width = 100,
                  cellTemplate = @"<div class=""glyphicon glyphicon-wrench"" ng-click=""edit()""></div> <div class = ""glyphicon glyphicon-trash"" ng-click=""delete()""></div>" },

            };
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]UserDto userDto)
        {
            var user = AutoMapper.Mapper.Map<UserDto, User>(userDto);
            _userService.Create(user);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
