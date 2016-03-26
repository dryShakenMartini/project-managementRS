using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementRS.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 PlannedHours { get; set; }
        public ProjectStatus Status { get; set; }
        public bool IsActive { get; set; }

        public string Description { get; set; }

        public ICollection<UserProject> UserProjects { get; set; }

        public virtual ICollection<TimeSheet> TimeSheets { get; set; } = new HashSet<TimeSheet>();
    }

    public enum ProjectStatus
    {
        Red,
        Green,
        Blue
    }
}