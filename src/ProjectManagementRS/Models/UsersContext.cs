using Microsoft.Data.Entity;

namespace ProjectManagementRS.Models
{
    public sealed class UsersContext: DbContext
    {
        public UsersContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<TimeSheet> TimeSheets { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserProject> UserProjects { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Startup.Configuration["Data:UsersContextConnection"];
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProject>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.UserProjects)
                .HasForeignKey(pt => pt.UserId);

            modelBuilder.Entity<UserProject>()
                .HasOne(pt => pt.Project)
                .WithMany(t => t.UserProjects)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<UserRole>()
            .HasOne(pt => pt.User)
            .WithMany(p => p.UserRoles)
            .HasForeignKey(pt => pt.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(pt => pt.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(pt => pt.RoleId);
        }
    }
}
