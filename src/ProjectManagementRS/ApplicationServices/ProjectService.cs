using ProjectManagementRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementRS.ApplicationServices
{
    public class ProjectService: IProjectService
    {
        private readonly IProjectRepository _repository;

        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Project> FindAll()
        {
           return _repository.FindAll();
        }

        public IEnumerable<Project> GetProjects(string UserName)
        {
            return _repository.FindProjectsByUserName(UserName);
        }
    }
}
