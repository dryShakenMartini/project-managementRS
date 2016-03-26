using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementRS.Models
{
    public class UserProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
