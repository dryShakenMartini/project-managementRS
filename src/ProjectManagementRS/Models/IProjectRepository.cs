using System.Collections.Generic;

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
