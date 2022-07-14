using Application.Repository;
using Application.ViewModels;
using Database;
using Database.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Helpers;

namespace Application.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;

        public ProductService(ApplicationContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _productRepository = new(dbContext);
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user"); /* userViewModel 
                                                                                                  sirve para
                                                                                                  guardar el usuario
                                                                                                  que está guardado en
                                                                                                  en la sección. */
        }

        public async Task<SaveProductViewModel> Add(SaveProductViewModel vm)
        {
            Product product = new();
            product.Name = vm.Name;
            product.Price = vm.Price;
            product.ImageUrl = vm.ImageUrl;
            product.Description = vm.Description;
            product.CategoryId = vm.CategoryId;
            product.UserId = userViewModel.Id;

            product = await _productRepository.AddAsync(product);

            SaveProductViewModel productVm = new();
            productVm.Id = product.Id;
            productVm.Name = product.Name;
            productVm.Price = product.Price;
            productVm.ImageUrl = product.ImageUrl;
            productVm.Description = product.Description;
            productVm.CategoryId = product.CategoryId;

            return productVm;
        }

        public async Task Update(SaveProductViewModel vm)
        {
            Product product = await _productRepository.GetByIdAsync(vm.Id);
            product.Id = vm.Id;
            product.Name = vm.Name;
            product.Price = vm.Price;
            product.ImageUrl = vm.ImageUrl;
            product.Description = vm.Description;
            product.CategoryId = vm.CategoryId;

            await _productRepository.UpdateAsync(product);
        }

        public async Task Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
        }

        public async Task<SaveProductViewModel> GetByIdViewModel(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            SaveProductViewModel vm = new();
            vm.Id = product.Id;
            vm.Name = product.Name;
            vm.Description = product.Description;
            vm.CategoryId = product.CategoryId;
            vm.Price = product.Price;
            vm.ImageUrl = product.ImageUrl;

            return vm;
        }

        public async Task<List<ProductViewModel>> GetAllViewModel()
        {
            var productList = await _productRepository.GetAllAsync();

            var productAlgo = productList.Select(product => new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
                Id = product.Id,
                Price = product.Price,
                ImageUrl = product.ImageUrl
            }).ToList();

            return productAlgo;
        }

        public async Task<List<ProductViewModel>> GetAllViewModelWithFilters(FilterProductViewModel filters)
        {
            var productList = await _productRepository.GetAllWithIncludeAsync(new List<string> { "Category" });

            var listViewModels = productList.Select(product => new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
                Id = product.Id,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.Category.Id
            }).ToList();

            if (filters.CategoryId != null)
            {
                listViewModels = listViewModels.Where(product => product.CategoryId == filters.CategoryId.Value).ToList();
            }

            return listViewModels;
        }
    }
}
