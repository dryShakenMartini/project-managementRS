using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementRS.Models
{
    public interface IProjectRepository
    {
        IEnumerable<Project> FindAll();
        IEnumerable<Project> FindAllEagerly();
        Project FindById(int Id);
        IEnumerable<Project> FindProjectsByUserName(string UserName);
        void Add(Project Project);
    }
}
