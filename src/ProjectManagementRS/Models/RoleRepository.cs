using System.Linq;

namespace ProjectManagementRS.Models
{
    public class RoleRepository : IRoleRepository
    {
        private readonly UsersContext _context;
        public RoleRepository(UsersContext context)
        {
            _context = context;
        }
        public string GetRole(RoleType type)
        {
            return _context.Roles.Where(x => x.RoleType == type).SingleOrDefault().Description;
        }
    }
}
