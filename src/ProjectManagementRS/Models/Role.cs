using System;
using System.Collections.Generic;

namespace ProjectManagementRS.Models
{
    public class Role
    {
        public Int32 Id { get; set; }
        public UserRole RoleType { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }

    public enum UserRole
    {
        Administrator,
        User
    }
}
