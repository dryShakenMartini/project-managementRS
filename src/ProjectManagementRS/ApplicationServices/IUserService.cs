using ProjectManagementRS.Models;
using System.Collections.Generic;

namespace ProjectManagementRS.ApplicationServices
{
    public interface IUserService
    {
        IEnumerable<User> FindAll();
        void Create(User entity);
    }
}