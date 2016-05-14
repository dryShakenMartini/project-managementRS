using System.Collections.Generic;
using ProjectManagementRS.Models;

namespace ProjectManagementRS.ApplicationServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repositroy;
        public UserService(IUserRepository repository)
        {
            _repositroy = repository;
        }
        public IEnumerable<User> FindAll()
        {
           return _repositroy.FindAll();
        }
    }
}
