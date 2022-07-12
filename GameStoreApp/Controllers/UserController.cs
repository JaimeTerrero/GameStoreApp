using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameStoreApp.Controllers
{

    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(ApplicationContext dbContext)
        {
            _userService = new(dbContext);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginVm)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVm);
            }

            return View();
        }

        public IActionResult Register()
        {
            return View(new SaveUserViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(SaveUserViewModel userVm)
        {
            if (!ModelState.IsValid)
            {
                return View(userVm);
            }

            await _userService.Add(userVm);
            return RedirectToRoute(new { controller = "User", action = "Index" });
        }
    }
}
