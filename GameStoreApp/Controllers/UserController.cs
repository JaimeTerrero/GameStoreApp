using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Helpers;
using GameStoreApp.Middlewares;
using System.Linq;

namespace GameStoreApp.Controllers
{

    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly ValidateUserSession _validateUserSession;

        private readonly ApplicationContext _User;

        public UserController(ApplicationContext dbContext, ValidateUserSession validateUserSession, IEmailService emailService)
        {
            _userService = new(dbContext,emailService);
            _validateUserSession = validateUserSession;
        }
        public IActionResult Index()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginVm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                return View(loginVm);
            }

            UserViewModel userVm = await _userService.Login(loginVm);

            if(userVm != null)
            {
                HttpContext.Session.Set<UserViewModel>("user", userVm);
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                /*Este error se mostrará en la vista de Index en la parte de @Html.ValidationSummary */
                ModelState.AddModelError("userValidation", "Datos de acceso incorrectos");
            }

            return View(loginVm);
        }

        public IActionResult Register()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View(new SaveUserViewModel());
        }

        public JsonResult ValidateUserName(string userdata)
        {
            System.Threading.Thread.Sleep(200);
            var SeachData = _User.Users.Where(x => x.Username == userdata).SingleOrDefault();
            if (SeachData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(SaveUserViewModel userVm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                return View(userVm);
            }

            await _userService.Add(userVm);
            return RedirectToRoute(new { controller = "User", action = "Index" });
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "User", action = "Index" });
        }

        public async Task<IActionResult> SeeAllUsers()
        {
            return View(await _userService.GetAllViewModel());
        }

        public async Task<IActionResult> EditUserInfo(int id)
        {
            SaveUserViewModel vm = await _userService.GetByIdViewModel(id);
            return View("EditUserInfo", vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserInfo(SaveUserViewModel vm)
        {
            await _userService.Update(vm);

            return RedirectToRoute(new { controller = "User", action = "SeeAllUsers" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _userService.GetByIdViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _userService.Delete(id);

            return RedirectToRoute(new { controller = "User", action = "SeeAllUsers" });
        }
    }
}
