using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementRS.Models
{
    public class UserRepository : IUserRepository
    {

        private readonly UsersContext _context;

        public UserRepository(UsersContext context)
        {
            _context = context;
        }

        public IEnumerable<User> FindAll()
        {
            return _context.Users;
        }

        public User FindUserByUserName(string userName)
        {
           return _context.Users.Where(x => x.UserName == userName).SingleOrDefault();
        }
    }
}
