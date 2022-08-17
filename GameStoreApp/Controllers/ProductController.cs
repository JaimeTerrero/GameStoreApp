using Application.Helpers;
using Application.Services;
using Application.ViewModels;
using Database;
using GameStoreApp.Middlewares;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GameStoreApp.Controllers
{

    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly ValidateUserSession _validateUserSession;
        private readonly InventaryService _inventaryService;
        private readonly UserViewModel user;
        public ProductController(ApplicationContext dbContext, ValidateUserSession validateUserSession, IHttpContextAccessor httpContextAccessor)
        {
            _productService = new(dbContext, httpContextAccessor);
            _categoryService = new(dbContext, httpContextAccessor);
            _validateUserSession = validateUserSession;
            _inventaryService = new(dbContext);
            user = httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }
        public async Task<IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
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

            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            SaveProductViewModel vm = new(); 
            vm.Categories = await _categoryService.GetAllViewModel();
            return View("SaveProduct", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveProductViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                vm.Categories = await _categoryService.GetAllViewModel();
                return View("SaveProduct", vm);
            }
            SaveProductViewModel productVm = await _productService.Add(vm);
            if(productVm != null && productVm.Id != 0)
            {
                productVm.ImageUrl = UploadFile(vm.File, productVm.Id);
                await _productService.Update(productVm);
            }
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

            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            SaveProductViewModel vm = await _productService.GetByIdViewModel(id); 
            vm.Categories = await _categoryService.GetAllViewModel();
            return View("SaveProduct", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveProductViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                vm.Categories = await _categoryService.GetAllViewModel();
                return View("SaveProduct", vm);
            }

            SaveProductViewModel productVm = await _productService.GetByIdViewModel(vm.Id);
            vm.ImageUrl = UploadFile(vm.File, productVm.Id,true,productVm.ImageUrl);

            
            await _productService.Update(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            /*Aquí no tuvimos que retornar el nombre de la vista porque el
             nombre del método es el mismo que el de la vista*/
            return View(await _productService.GetByIdViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            await _productService.Delete(id);



            // get directory path
            string basePath = $"/Images/Products/{id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");


            /*
             En esta parte lo que hacemos basicamente es borrar todo, desde directorios
             hasta folders.

            Primero se borran los archivos.
            Segundo se borran los folder.
            Tercero se borran los directorios.
             */
            if (Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                foreach(FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                }

                foreach (DirectoryInfo folder in directoryInfo.GetDirectories())
                {
                    folder.Delete(true);
                }

                Directory.Delete(path);
            }

            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        
        public async Task<IActionResult> ShowProduct(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            SaveProductViewModel vm = await _productService.GetByIdViewModel(id);
            return View("ShowProduct", vm);
        }

        [HttpPost]
        public async Task<IActionResult> ShowProductPost(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            SaveProductViewModel vm = await _productService.GetByIdViewModel(id);

            return View("ShowProduct", vm);
        }

        //Carrito de compras
        public async Task<IActionResult> ProductDetails(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

             
            return View("ProductDetails", await _inventaryService.GetByIdViewModel(user.Id));
        }


        public async Task<IActionResult> AddToCart(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            var cart = await _inventaryService.GetByUserId(user.Id);
            SaveInventaryViewModel sivm = new();
            if (cart == null || cart.Id == 0)
            {
                sivm.UserId = user.Id;
                sivm.ProductId = id;

                await _inventaryService.Add(sivm);
            }
            else
            {
                sivm.UserId = user.Id;
                sivm.InventaryId = cart.Id;
                sivm.ProductId = id;

                await _inventaryService.Add(sivm);
            }

            
            return RedirectToAction("ProductDetails", sivm.InventaryId);
        }

        public async Task<IActionResult> DeleteFromCart(int id) {

            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            return View(await _inventaryService.GetByIdViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFromCartPost(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            await _inventaryService.DeleteFromCart(id);

            return RedirectToRoute(new { controller = "Product", action = "ProductDetails" });
        }

        #region private methods
        private string UploadFile(IFormFile file, int id, bool isEditMode = false, string imageUrl = "")
        {
            /*Decimos que si estamos editando y por alguna razón no se pone
             un archivo, el programa devolverá el mismo archivo que se encontraba
            anteriormente. */
            if(isEditMode && file == null)
            {
                return imageUrl;
            }

            // get directory path
            string basePath = $"/Images/Products/{id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            // create a folder if not exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //El Guid nos sirve para generar un Id único a cada imagen
            // get file path
            Guid guid = Guid.NewGuid();

            FileInfo fileInfo = new(file.FileName);
            string fileName = guid + fileInfo.Extension;

            string filenameWithPath = Path.Combine(path, fileName);

            // pa subirlo
            using(var stream = new FileStream(filenameWithPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }


            // En esta parte borramos la imagen vieja, para así no llenar las carpetas
            if (isEditMode)
            {
                // El split es para divirlo por slashs (/)
                string[] oldImagePart = imageUrl.Split('/');
                string oldImageName = oldImagePart[^1]; //^1 significa la última posición
                string completeImageOldPath = Path.Combine(path, oldImageName);

                //se coloca el nombre completo del paquete porque ya tenemos una definición de File
                //y para evitar de que traiga ese método
                //de HTTPContext ya que poseen el mismo nombre, y no es ese que se necesita
                if (System.IO.File.Exists(completeImageOldPath))
                {
                    System.IO.File.Delete(completeImageOldPath);
                }
            }

            return $"{basePath}/{fileName}";
        }
        #endregion
    }
}
