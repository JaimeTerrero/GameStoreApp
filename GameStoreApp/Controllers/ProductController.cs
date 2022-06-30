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
        public ProductController(ApplicationContext dbContext)
        {
            _productService = new(dbContext);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAllViewModel());
        }

        public IActionResult Create()
        {
            /*
             * Se coloca el nombre de la vista para que el método lo pueda reconocer
             * Se coloca como modelo la clase SaveProductViewModel porque eso es lo 
             * que está esperando la vista de lo contrario dara error.*/
            return View("SaveProduct", new SaveProductViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveProductViewModel vm)
        {
            await _productService.Add(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }
    }
}
