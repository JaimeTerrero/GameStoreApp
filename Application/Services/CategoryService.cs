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
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(ApplicationContext dbContext)
        {
            _categoryRepository = new(dbContext);
        }

        public async Task Add(SaveCategoryViewModel vm)
        {
            Category category = new();
            category.Name = vm.Name;

            await _categoryRepository.AddAsync(category);
        }

        public async Task Update(SaveCategoryViewModel vm)
        {
            Category category = new();
            category.Id = vm.Id;
            category.Name = vm.Name;

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task Delete(int id)
        {
            var product = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.DeleteAsync(product);
        }

        public async Task<SaveCategoryViewModel> GetByIdViewModel(int id)
        {
            var product = await _categoryRepository.GetByIdAsync(id);

            SaveCategoryViewModel vm = new();
            vm.Id = product.Id;
            vm.Name = product.Name;

            return vm;
        }

        public async Task<List<CategoryViewModel>> GetAllViewModel()
        {
            var productList = await _categoryRepository.GetAllAsync();

            return productList.Select(product => new CategoryViewModel
            {
                Id = product.Id,
                Name = product.Name,
            }).ToList();
        }
    }
}
