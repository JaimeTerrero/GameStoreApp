using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameStoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        public CategoryController(ApplicationContext dbContext)
        {
            _categoryService = new(dbContext);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetAllViewModel());
        }

        public IActionResult Create()
        {
            return View("SaveCategory", new SaveCategoryViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveCategoryViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveCategory", vm);
            }

            await _categoryService.Add(vm);
            return RedirectToRoute(new { controller = "Category", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveCategory", await _categoryService.GetByIdViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveCategoryViewModel vm)
        {
            await _categoryService.Update(vm);
            return RedirectToRoute(new { controller = "Category", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _categoryService.GetByIdViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _categoryService.Delete(id);
            return RedirectToRoute(new { controller = "Category", action = "Index" });
        }
    }
}
