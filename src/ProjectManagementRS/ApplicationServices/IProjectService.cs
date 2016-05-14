using ProjectManagementRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementRS.ApplicationServices
{
    interface IProjectService
    {
        IEnumerable<Project> FindProjectsByUser(string userName);
    }
}
