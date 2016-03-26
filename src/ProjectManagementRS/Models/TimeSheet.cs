using System;

namespace ProjectManagementRS.Models
{
    public class TimeSheet
    {
        public Int32 Id { get; set; }

        public Int32 UserId { get; set; }
        public virtual User User { get; set; }

        public Int32 ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public DateTime LogDate { get; set; }
        public Int32 Hours { get; set; }
        public string Comment { get; set; }
    }
}
