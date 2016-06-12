using System.Collections.Generic;

namespace ProjectManagementRS.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
        IEnumerable<User> FindAllEagerly();
        User FindById(int id);
        User FindUserByUserName(string userName);
        User FindUser(string userName, string password);
        void Add(User user);
        bool TryCreate(User user, string password);
    }
}