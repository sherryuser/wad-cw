using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using wiutLMS.Models;
using wiutLMS.Services;
using wiutLMS.ViewModels;

namespace wiutLMS.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context, MyUserManager usermanager,
            IServiceProvider services)
        {
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();

            // Make sure the database is created
            // We already did this in the previous step
            context.Database.EnsureCreated();

            if (context.Courses.Any())
            {
                logger.LogInformation("The database was already seeded");
                return;
            }

            logger.LogInformation("Start seeding the database.");



            usermanager.CreateUser(new PersonViewModel
            {
                FirstName = "u1_firstname",
                LastName = "u1_lastname",
                Password = "!2Qwerty",
                ConfirmPassword = "!2Qwerty",
                PersonMode = "Teacher",
                UserName = "user1"
            });

            var teacher = usermanager.GetUserByUsername("user1");
            Lecture[] lectures = new[]
            {
                new Lecture
                {
                    Title = "lec1",
                    Content = "lecture content ...",
                    Attachment = new File
                    {
                        Path = "uploads/pic1.png",
                        Description = "temp picture file ..."
                    }
                },
                new Lecture
                {
                    Title = "lec2",
                    Content = "lecture content2 ...",
                    Attachment = new File
                    {
                        Path = "uploads/pic2.png",
                        Description = "temp picture file2 ..."
                    }
                }
            };

            context.Courses.Add(
                new Course
                {
                    Category = new Category
                    {
                        Name = "cat 1"
                    },
                    Description = "template course",
                    Teacher = teacher,
                    Price = 10,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(10),
                    Name = "course1",
                    Lectures = lectures.ToList()
                }
            );


            usermanager.CreateUser(new PersonViewModel
            {
                FirstName = "u2_firstname",
                LastName = "u2_lastname",
                Password = "!2Qwerty",
                ConfirmPassword = "!2Qwerty",
                PersonMode = "Student",
                UserName = "user2"
            });

            context.SaveChanges();

            logger.LogInformation("Finished seeding the database.");
        }
    }
}