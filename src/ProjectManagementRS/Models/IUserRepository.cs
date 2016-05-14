using System.Collections.Generic;

namespace ProjectManagementRS.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
        User FindById(int Id);
        User FindUserByUserName(string UserName);
        User FindUser(string UserName, string Password);
        void Add(User User);
        bool TryCreate(User user, string password);
    }
}