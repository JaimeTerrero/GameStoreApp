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
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;

        public CategoryService(ApplicationContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepository = new(dbContext);
            _productRepository = new(dbContext);
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        public async Task<SaveCategoryViewModel> Add(SaveCategoryViewModel vm)
        {
            Category category = new();
            category.Name = vm.Name;

            category = await _categoryRepository.AddAsync(category);

            SaveCategoryViewModel categoryVm = new();
            categoryVm.Id = category.Id;
            categoryVm.Name = category.Name;

            return categoryVm;
        }

        public async Task Update(SaveCategoryViewModel vm)
        {
            Category category = await _categoryRepository.GetByIdAsync(vm.Id);
            category.Id = vm.Id;
            category.Name = vm.Name;

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task Delete(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.DeleteAsync(category);
        }

        public async Task<SaveCategoryViewModel> GetByIdViewModel(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            SaveCategoryViewModel vm = new();
            vm.Id = category.Id;
            vm.Name = category.Name;

            return vm;
        }


        // Método para saber cuantos productos hay por categoría 
        public async Task<List<CategoryViewModel>> GetAllViewModel()
        {
            var categoryList = await _categoryRepository.GetAllAsync(new List<string> { "Products"}); 
            //lo que le pasamos entre llaves es el Navigation Property

            return categoryList.Select(category => new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                ProductQuantity = category.Products.Count()
            }).ToList();
        }

        
    }
}
