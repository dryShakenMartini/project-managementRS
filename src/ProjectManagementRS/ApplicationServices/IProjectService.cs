using ProjectManagementRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementRS.ApplicationServices
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects(string UserName);
        IEnumerable<Project>  FindAll();
    }
}
