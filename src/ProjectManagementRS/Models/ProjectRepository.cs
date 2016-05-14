using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementRS.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly UsersContext _context;

        public ProjectRepository(UsersContext context)
        {
            _context = context;
        }
        public void Add(Project Project)
        {
            _context.Projects.Add(Project);

        }

        public IEnumerable<Project> FindAll()
        {
            return _context.Projects;

        }

        public IEnumerable<Project> FindAllEagerly()
        {
            return _context.Projects.Include(x => x.UserProjects).Include(y => y.TimeSheets);

        }

        public Project FindById(int Id)
        {
            return FindAllEagerly().Where(x => x.Id == Id).SingleOrDefault();
        }

        public IEnumerable<Project> FindProjectsByUserName(string UserName)
        {
            return FindAllEagerly().Where(x => x.UserProjects.Any(z => z.User.UserName == UserName));
        }
    }
}
