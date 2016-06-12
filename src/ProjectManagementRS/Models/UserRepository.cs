using Microsoft.Data.Entity;
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
            return _context.Users.SingleOrDefault(x => x.UserName == userName);
        }

        public User FindUser(string userName, string password)
        {
            return _context.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User FindById(int id)
        {
            return FindAllEagerly().SingleOrDefault(x => x.Id == id);
        }

        public bool TryCreate(User user, string password)
        {
            var userExists = _context.Users.SingleOrDefault(u => u.UserName == user.UserName && u.IsActive);
            if (userExists != null)
            {
                return false;
            }
            user.Password = password;
            Add(user);
            return true;
        }

        public IEnumerable<User> FindAllEagerly()
        {
            return _context.Users.Include(x => x.UserProjects).Include(y => y.UserRoles).Include(z => z.TimeSheets);
        }
    }
}
