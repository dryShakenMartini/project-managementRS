using Microsoft.Data.Entity;
using System;
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

        public User FindUserByUserName(string UserName)
        {
            return _context.Users.Where(x => x.UserName == UserName).SingleOrDefault();
        }

        public User FindUser(string UserName, string Password)
        {
            return _context.Users.Where(x => x.UserName == UserName && x.Password == Password).SingleOrDefault();
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User FindById(int Id)
        {
            return FindAllEagerly().Where(x => x.Id == Id).SingleOrDefault();
        }

        public bool TryCreate(User user, string password)
        {
            var userExists = _context.Users.Where(u => u.UserName == user.UserName && u.IsActive == true).SingleOrDefault();
            if (userExists != null)
            {
                return false;
            }
            else
            {
                user.Password = password;
                Add(user);
                return true;
            }
        }

        public IEnumerable<User> FindAllEagerly()
        {
            return _context.Users.Include(x => x.UserProjects).Include(y => y.UserRoles).Include(z => z.TimeSheets);
        }
    }
}
