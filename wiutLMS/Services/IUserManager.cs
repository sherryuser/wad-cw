using Microsoft.AspNetCore.Identity;
using wiutLMS.Models;
using wiutLMS.ViewModels;

namespace wiutLMS.Services
{
    public interface IUserManager
    {
        IdentityResult CreateUser(PersonViewModel person);
        //bool AddToRole(Person person, string role);
        bool Login(LoginViewModel login);
        void Logout();
        Person GetUser(System.Security.Claims.ClaimsPrincipal x);
        Person GetUser(string id);
        public Person GetUserByUsername(string username);
    }
}