using System;
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

        public void Create(User entity)
        {
            _repositroy.Add(entity);
        }

        public IEnumerable<User> FindAll()
        {
           return _repositroy.FindAll();
        }
    }
}
