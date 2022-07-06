using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameStoreApp.Controllers
{

    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        public ProductController(ApplicationContext dbContext)
        {
            _productService = new(dbContext);
            _categoryService = new(dbContext);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAllViewModel());
        }

        public async Task<IActionResult> Create()
        {
            /*
              -Se le pasa en el return la vista de SaveProduct debido a que tiene un nombre diferente
               que el método, ya que esa vista es la que posee la variable editMode que nos dice si estamos
               editando o creando, es decir en esa vista se utilizan los 2 métodos, tanto el Edit como el
               Create.

              -Se coloca como modelo la clase SaveProductViewModel porque eso es lo 
              que está esperando la vista de lo contrario dara error.*/

            SaveProductViewModel vm = new(); 
            vm.Categories = await _categoryService.GetAllViewModel();
            return View("SaveProduct", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveProductViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Categories = await _categoryService.GetAllViewModel();
                return View("SaveProduct", vm);
            }
            await _productService.Add(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            /*
             -Se le pasa en el return la vista de SaveProduct debido a que tiene un nombre diferente
             que el método, ya que esa vista es la que posee la variable editMode que nos dice si estamos
             editando o creando, es decir en esa vista se utilizan los 2 métodos, tanto el Edit como el
             Create.

             -Se le pasa el Id para que busque el determinado producto en la base de datos y nos lo enseñe
             */

            SaveProductViewModel vm = await _productService.GetByIdViewModel(id); 
            vm.Categories = await _categoryService.GetAllViewModel();
            return View("SaveProduct", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveProductViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Categories = await _categoryService.GetAllViewModel();
                return View("SaveProduct", vm);
            }

            /*Aquí se hace lo mismo que en el Create, lo único que se le cambio fue el método que proviene
             del servicio*/
            await _productService.Update(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            /*Aquí no tuvimos que retornar el nombre de la vista porque el
             nombre del método es el mismo que el de la vista*/
            return View(await _productService.GetByIdViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _productService.Delete(id);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        public async Task<IActionResult> ShowProduct(int id)
        {
            SaveProductViewModel vm = await _productService.GetByIdViewModel(id);
            return View("ShowProduct", vm);
        }
    }
}
