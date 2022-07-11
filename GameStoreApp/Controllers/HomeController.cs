using Application.Services;
using Application.ViewModels;
using Database;
using GameStoreApp.Models;
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
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        public HomeController(ApplicationContext dbContext)
        {
            _productService = new(dbContext);
            _categoryService = new(dbContext);
        }

        public async Task<IActionResult> Index(FilterProductViewModel filterProductViewModel)
        {
            ProductViewModel vm = new();
            vm.Categories = await _categoryService.GetAllViewModel();
            ViewBag.Categories = vm.Categories;
            return View(await _productService.GetAllViewModelWithFilters(filterProductViewModel));
        }
    }
}
