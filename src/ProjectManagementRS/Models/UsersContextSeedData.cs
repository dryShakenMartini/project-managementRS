using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProjectManagementRS.Models
{
    public class UsersContextSeedData
    {
        private readonly UsersContext _context;

        public UsersContextSeedData(UsersContext context)
        {
            _context = context;
        }

        public void SeedInitialData()
        {
            if (!_context.Users.Any())
            {
                var userOne = new User
                {
                    UserName = "kevin.spicey",
                    Name = "Kevin",
                    Surname = "Spicey",
                    Email = "kevin.spacey@darkstar.com",
                    StartDate = new DateTime(2016, 2, 1),
                    PhoneNumber = "00381112526563",
                    IsActive = true,
                    Password = "blabla"
                  };

                _context.Users.Add(userOne);

                var userTwo = new User
                {
                    UserName = "robin.wright",
                    Name = "Robin",
                    Surname = "Wright",
                    Email = "robin.wright@darkstar.com",
                    StartDate = new DateTime(2016, 3, 1),
                    PhoneNumber = "003811188555",
                    IsActive = true,
                    Password = "blablaTwo"
                };

                _context.Users.Add(userTwo);
                _context.TimeSheets.AddRange(userTwo.TimeSheets);

                var userThree = new User
                {
                    UserName = "michael.kelly",
                    Name = "Michael",
                    Surname = "Kelly",
                    Email = "michael.kelly@darkstar.com",
                    StartDate = new DateTime(2016, 4, 1),
                    PhoneNumber = "00381112588563",
                    IsActive = true,
                    Password = "blabla"
                };

                _context.Users.Add(userThree);
                _context.SaveChanges();
            }

            if (!_context.Projects.Any())
            {
                var listOfProjects = new Collection<Project>
                {
                    new Project
                    {
                        Name = "Gucci",
                        StartDate = new DateTime(2015, 12, 1),
                        DueDate = new DateTime(2016, 6, 1),
                        IsActive = true,
                        PlannedHours = 1000,
                        Status = ProjectStatus.Green,
                        Description = "Winter collection"
                    },
                    new Project
                    {
                        Name = "Armani",
                        StartDate = new DateTime(2016, 1, 1),
                        DueDate = new DateTime(2016, 10, 1),
                        IsActive = true,
                        PlannedHours = 1400,
                        Status = ProjectStatus.Green,
                        Description = "Spring collection"
                    },
                    new Project
                    {
                        Name = "Prada",
                        StartDate = new DateTime(2015, 10, 1),
                        DueDate = new DateTime(2016, 5, 1),
                        IsActive = true,
                        PlannedHours = 1100,
                        Status = ProjectStatus.Green,
                        Description = "Winter collection"
                    },
                    new Project
                    {
                        Name = "Chanel",
                        StartDate = new DateTime(2015, 8, 1),
                        DueDate = new DateTime(2016, 7, 1),
                        IsActive = true,
                        PlannedHours = 2000,
                        Status = ProjectStatus.Green,
                        Description = "Summer collection"
                    },
                    new Project
                    {
                        Name = "Dior",
                        StartDate = new DateTime(2015, 12, 1),
                        DueDate = new DateTime(2016, 8, 1),
                        IsActive = true,
                        PlannedHours = 1200,
                        Status = ProjectStatus.Green,
                        Description = "Winter collection"
                    },
                    new Project
                    {
                        Name = "Versace",
                        StartDate = new DateTime(2015, 9, 1),
                        DueDate = new DateTime(2016, 5, 1),
                        IsActive = true,
                        PlannedHours = 1600,
                        Status = ProjectStatus.Green,
                        Description = "Autumn collection"
                    }
                };


                _context.Projects.AddRange(listOfProjects);
                _context.SaveChanges();
            }

            if (!_context.TimeSheets.Any())
            {
                var timeSheets = new Collection<TimeSheet>
                {
                    new TimeSheet {UserId = 1, ProjectId = 1, LogDate = new DateTime(2016, 2, 3), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 2, LogDate = new DateTime(2016, 2, 3), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 3, LogDate = new DateTime(2016, 2, 3), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 1, LogDate = new DateTime(2016, 2, 4), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 2, LogDate = new DateTime(2016, 2, 4), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 3, LogDate = new DateTime(2016, 2, 4), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 1, LogDate = new DateTime(2016, 2, 5), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 2, LogDate = new DateTime(2016, 2, 5), Hours = 8},
                    new TimeSheet {UserId = 1, ProjectId = 3, LogDate = new DateTime(2016, 2, 5), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 4, LogDate = new DateTime(2016, 3, 3), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 5, LogDate = new DateTime(2016, 3, 3), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 6, LogDate = new DateTime(2016, 3, 3), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 4, LogDate = new DateTime(2016, 3, 4), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 5, LogDate = new DateTime(2016, 3, 4), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 6, LogDate = new DateTime(2016, 3, 4), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 4, LogDate = new DateTime(2016, 3, 5), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 5, LogDate = new DateTime(2016, 3, 5), Hours = 8},
                    new TimeSheet {UserId = 2, ProjectId = 6, LogDate = new DateTime(2016, 3, 5), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 3, LogDate = new DateTime(2016, 4, 3), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 5, LogDate = new DateTime(2016, 4, 3), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 6, LogDate = new DateTime(2016, 4, 3), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 3, LogDate = new DateTime(2016, 4, 4), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 5, LogDate = new DateTime(2016, 4, 4), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 6, LogDate = new DateTime(2016, 4, 4), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 3, LogDate = new DateTime(2016, 4, 5), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 5, LogDate = new DateTime(2016, 4, 5), Hours = 8},
                    new TimeSheet {UserId = 3, ProjectId = 6, LogDate = new DateTime(2016, 4, 5), Hours = 8}
                };
                _context.TimeSheets.AddRange(timeSheets);
                _context.SaveChanges();
            }

            if (!_context.UserProjects.Any())
            {
                var userProjects = new Collection<UserProject>
                {
                    new UserProject {UserId = 1, ProjectId = 1},
                    new UserProject {UserId = 1, ProjectId = 2},
                    new UserProject {UserId = 1, ProjectId = 3},
                    new UserProject {UserId = 2, ProjectId = 4},
                    new UserProject {UserId = 2, ProjectId = 5},
                    new UserProject {UserId = 2, ProjectId = 6},
                    new UserProject {UserId = 3, ProjectId = 3},
                    new UserProject {UserId = 3, ProjectId = 5},
                    new UserProject {UserId = 1, ProjectId = 6}
                };
                _context.UserProjects.AddRange(userProjects);
                _context.SaveChanges();
            }

            if (!_context.Roles.Any())
            {
                var roles = new Collection<Role>
                {
                    new Role {RoleType = RoleType.Administrator, Description = "Admin role"},
                    new Role {RoleType = RoleType.User, Description = "User role"}
                };
                _context.Roles.AddRange(roles);
                _context.SaveChanges();
            }
            if (!_context.UserRoles.Any())
            {
                var userRoles = new Collection<UserRole>
                {
                    new UserRole {UserId = 1, RoleId = 1},
                    new UserRole {UserId = 1, RoleId = 2},
                    new UserRole {UserId = 2, RoleId = 2},
                    new UserRole {UserId = 1, RoleId = 2}
                };

                _context.UserRoles.AddRange(userRoles);
                _context.SaveChanges();
            }
        }
    }
}