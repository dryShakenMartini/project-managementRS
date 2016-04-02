using System.Collections.Generic;

namespace ProjectManagementRS.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
        User FindUserByUserName(string userName);
    }
}