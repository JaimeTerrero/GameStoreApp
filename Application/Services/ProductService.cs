using Application.Repository;
using Application.ViewModels;
using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ApplicationContext dbContext)
        {
            _productRepository = new(dbContext);
        }

        public async Task Add(SaveProductViewModel vm)
        {
            Product product = new();
            product.Name = vm.Name;
            product.Price = vm.Price;
            product.ImageUrl = vm.ImageUrl;
            product.Description = vm.Description;
            product.CategoryId = vm.CategoryId;

            await _productRepository.AddAsync(product);
        }

        public async Task Update(SaveProductViewModel vm)
        {
            Product product = new();
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

            return productList.Select(product => new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
                Id = product.Id,
                Price = product.Price,
                ImageUrl = product.ImageUrl
            }).ToList();
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
