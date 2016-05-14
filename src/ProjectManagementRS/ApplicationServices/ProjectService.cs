using ProjectManagementRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementRS.ApplicationServices
{
    public class ProjectService: IProjectService
    {
        private readonly IProjectRepository _repositroy;

        public ProjectService(IProjectRepository repository)
        {
            _repositroy = repository;
        }

        public IEnumerable<Project> FindProjectsByUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
