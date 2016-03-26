using System;
using System.Collections.Generic;

namespace ProjectManagementRS.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        ICollection<Project> Projects { get; set; }
        ICollection<Role> UserRoles { get; set; }

        public virtual ICollection<TimeSheet> TimeSheets { get; set; } = new HashSet<TimeSheet>();
    }

   
}