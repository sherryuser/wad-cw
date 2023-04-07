using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using wiutLMS.Data;
using wiutLMS.Models;
using wiutLMS.Services;

namespace wiutLMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyUserManager _userManager;
        
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext, MyUserManager userManager)
        {
            _userManager = userManager;
        }

        private void addUserNavbar()
        {
            _userManager.AddNavigationBarButtons(ViewBag, User);
        }
        
        public async Task<IActionResult> Index()
        {
            addUserNavbar();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}