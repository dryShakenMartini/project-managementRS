using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementRS.Models
{
    public interface IRoleRepository
    {
        string GetRole(RoleType type);
    }
}
