using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Helpers;
using GameStoreApp.Middlewares;
using System.Linq;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace GameStoreApp.Controllers
{

    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly ValidateUserSession _validateUserSession;
        private readonly ApplicationContext _dbContext;
        private readonly UserViewModel user;

        public UserController(ApplicationContext dbContext, ValidateUserSession validateUserSession, IEmailService emailService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = new(dbContext,emailService);
            _validateUserSession = validateUserSession;
            _dbContext = dbContext;
            user = httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
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

        #region jsonResults
        public JsonResult ValidateUserName(string userData)
        {
            System.Threading.Thread.Sleep(200);
            var SeachData = _dbContext.Users.Where(x => x.Username == userData).FirstOrDefault();
            if (SeachData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }

        public JsonResult ValidateEmailExistence(string emailData)
        {
            System.Threading.Thread.Sleep(200);
            var SearchData = _dbContext.Users.Where(x => x.Email == emailData).FirstOrDefault();
            if(SearchData != null)
            {
                return Json(1);
            }
            //else if(!EmailValidationProccess(emailData)){
            //    return Json(2);
            //}
            else if(emailData == "")
            {
                return Json(3);
            }
            else
            {
                return Json(0);
            }
        }
        public JsonResult ValidatePhoneNumberExistence(string phoneData)
        {
            System.Threading.Thread.Sleep(200);
            var SearchData = _dbContext.Users.Where(x => x.Phone == phoneData).FirstOrDefault();
            if(SearchData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }

        //public JsonResult MatchingPasswords(string password, string confirmPassword)
        //{
        //    System.Threading.Thread.Sleep(200);
        //    var SearchData = _dbContext.Users.Where(x => x.Password == password).FirstOrDefault();
        //    var LookForData = _dbContext.Users.Where(x => x.Password == confirmPassword).FirstOrDefault();
        //    if ( LookForData == SearchData)
        //    {
        //        return Json(1);
        //    }
        //    else
        //    {
        //        return Json(0);
        //    }
        //}
        public static bool EmailValidationProccess(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            return emailRegex.IsMatch(email);
        }
        #endregion

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

        public IActionResult Admin()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View("Admin");
        }
    }
}
