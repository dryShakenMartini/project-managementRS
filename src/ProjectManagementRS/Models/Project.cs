using System;
using System.Collections.Generic;

namespace ProjectManagementRS.Models
{
    public class Project
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 PlannedHours { get; set; }
        public ProjectStatus Status { get; set; }
        public bool IsActive { get; set; }

        public string Description { get; set; }

        public ICollection<User> Users { get; set; }

        public virtual ICollection<TimeSheet> TimeSheets { get; set; } = new HashSet<TimeSheet>();
    }

    public enum ProjectStatus
    {
        Red,
        Green,
        Blue
    }
}