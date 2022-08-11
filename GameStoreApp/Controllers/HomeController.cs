using Application.Services;
using Application.ViewModels;
using Database;
using GameStoreApp.Middlewares;
using GameStoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApp.Controllers
{
    public class HomeController : Controller
    {

        // sensacion del blok
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly ValidateUserSession _validateUserSession;

        public HomeController(ApplicationContext dbContext, ValidateUserSession validateUserSession, IHttpContextAccessor httpContextAccessor)
        {
            _productService = new(dbContext, httpContextAccessor);
            _categoryService = new(dbContext, httpContextAccessor);
            _validateUserSession = validateUserSession;
        }

        public async Task<IActionResult> Index(FilterProductViewModel filterProductViewModel)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            ProductViewModel vm = new();
            vm.Categories = await _categoryService.GetAllViewModel();
            ViewBag.Categories = vm.Categories;
            return View(await _productService.GetAllViewModelWithFilters(filterProductViewModel));
        }

        public IActionResult Admin()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            return View();
        }
    }
}
