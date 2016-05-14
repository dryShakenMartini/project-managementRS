using Microsoft.AspNet.Mvc;
using ProjectManagementRS.ApplicationServices;
using ProjectManagementRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProjectManagementRS.Controllers.Api
{
    [Route("api/projects")]
    public class ProjectsApiController: ApiController
    {
        private readonly IProjectService _projectService;
        public ProjectsApiController(IProjectService service)
        {
            _projectService = service;
        }
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _projectService.FindAll().ToList();
        }

        [HttpGet]
        [Route("columns")]
        public List<object> GetUsersColumns()
        {
            return new List<object> {
              new { field= "name", displayName= "Name", width = 100 },
              new { field= "startDate", displayName= "Start Date", width = 100 },
              new { field= "endDate", displayName= "End Date", width = 100 },
              new { field= "plannedHours", displayName= "Planned Hours", width = 100 },
              new { field= "status", displayName= "Status", width = 100 },
              new { field= "actions", displayName= "Actions", width = 100,
                  cellTemplate = @"<div class=""glyphicon glyphicon-wrench"" ng-click=edit()></div> <div class = ""glyphicon glyphicon-trash"" ng-click=delete()></div>" },

            };
        }
    }
}
