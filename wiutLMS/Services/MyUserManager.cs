using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using wiutLMS.Data;
using wiutLMS.Models;
using wiutLMS.ViewModels;

namespace wiutLMS.Services
{
    public class MyUserManager : IUserManager
    {
        private readonly ILogger<MyUserManager> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<Person> _userManager;
        private readonly SignInManager<Person> _signInManager;

        public bool isTeacher = false;
        public bool isStudent = false;

        private Person _user;

        public MyUserManager(ApplicationDbContext dbContext, UserManager<Person> userManager,
            SignInManager<Person> signInManager, ILogger<MyUserManager> logger)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public void AddNavigationBarButtons(dynamic ViewBag, ClaimsPrincipal cp)
        {
            if (ViewBag.navbar is null)
                ViewBag.navbar = new List<NavbarButton>();
            var user = GetUser(cp);
            if (user is null)
            {
                ViewBag.navbar.Add(new NavbarButton
                {
                    Title = "Login",
                    Controller = "Users",
                    Action = "Login"
                });

                ViewBag.navbar.Add(new NavbarButton
                {
                    Title = "Signup",
                    Controller = "Users",
                    Action = "SignUp"
                });
                return;
            }

            ViewBag.navbar.Add(new NavbarButton
            {
                Title = "Logout",
                Controller = "Users",
                Action = "Logout"
            });
            ViewBag.navbar.Add(new NavbarButton
            {
                Title = "Profile",
                Controller = "Users",
                Action = "Profile",
                Id = GetUser(cp).Id
            });

        }

        public IdentityResult CreateUser(PersonViewModel person)
        {
            Person p = new Person
            {
                UserName = person.UserName,
                FirstName = person.FirstName,
                LastName = person.LastName,
                IsTeacher = person.PersonMode == PersonViewModel.PersonModes[0].Text //teacher // todo: fix this ...
            };

            var result = _userManager.CreateAsync(p, person.Password).GetAwaiter().GetResult();
            if (!result.Succeeded)
                return result;

 

            return result;
        }


        public bool Login(LoginViewModel login)
        {
            Logout();

            return _signInManager.PasswordSignInAsync(login.Username, login.Password, login.RememberMe, false)
                .GetAwaiter().GetResult().Succeeded;
        }

        public void Logout()
        {
            _signInManager.SignOutAsync().Wait();
        }

        public Person GetUser(ClaimsPrincipal claimsPrincipal)
        {
            if (_user is null)
            {
                _user = _userManager.GetUserAsync(claimsPrincipal).GetAwaiter().GetResult();

                if (_user is not null)
                {
                    if (_user.IsTeacher)
                        isTeacher = true;
                    else
                        isStudent = true;
                }
            }

            return _user;
        }

        public Person GetUser(string id)
        {
            return _dbContext.Users.Where(x => x.Id == id).Include(x => x.Courses).Include(x => x.StudentCourses)
                .FirstOrDefault();
        }

        public Person GetUserByUsername(string username)
        {
            return _dbContext.Users.Where(x => x.UserName == username).Include(x => x.Courses)
                .Include(x => x.StudentCourses)
                .FirstOrDefault();
        }

        public void CheckoutCourse(ClaimsPrincipal claimsPrincipal, Course c, Person user = null)
        {
            user ??= GetUser(claimsPrincipal);

            user.Courses.Add(c);
            StudentCourse sc = new StudentCourse {Course = c, Student = user};
            c.StudentCourses.Add(sc);
            _dbContext.StudentCourses.Add(sc);
            _dbContext.SaveChanges();
        }
    }
}