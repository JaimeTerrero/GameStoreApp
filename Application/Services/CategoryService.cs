using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    //public class CategoryService
    //{
    //    private readonly CategoryService _categoryService;

    //    public CategoryService(ApplicationContext dbContext)
    //    {
    //        _categoryService = new(dbContext);
    //    }

    //    public async Task Add(SaveProductViewModel vm)
    //    {
    //        Product product = new();
    //        product.Name = vm.Name;
    //        product.Price = vm.Price;
    //        product.ImageUrl = vm.ImageUrl;
    //        product.Description = vm.Description;
    //        product.CategoryId = vm.CategoryId;

    //        await _productRepository.AddAsync(product);
    //    }

    //    public async Task Update(SaveProductViewModel vm)
    //    {
    //        Product product = new();
    //        product.Id = vm.Id;
    //        product.Name = vm.Name;
    //        product.Price = vm.Price;
    //        product.ImageUrl = vm.ImageUrl;
    //        product.Description = vm.Description;
    //        product.CategoryId = vm.CategoryId;

    //        await _productRepository.UpdateAsync(product);
    //    }

    //    public async Task Delete(int id)
    //    {
    //        var product = await _productRepository.GetByIdAsync(id);
    //        await _productRepository.DeleteAsync(product);
    //    }

    //    public async Task<SaveProductViewModel> GetByIdViewModel(int id)
    //    {
    //        var product = await _productRepository.GetByIdAsync(id);

    //        SaveProductViewModel vm = new();
    //        vm.Id = product.Id;
    //        vm.Name = product.Name;
    //        vm.Description = product.Description;
    //        vm.CategoryId = product.CategoryId;
    //        vm.Price = product.Price;
    //        vm.ImageUrl = product.ImageUrl;

    //        return vm;
    //    }

    //    public async Task<List<ProductViewModel>> GetAllViewModel()
    //    {
    //        var productList = await _productRepository.GetAllAsync();

    //        return productList.Select(product => new ProductViewModel
    //        {
    //            Name = product.Name,
    //            Description = product.Description,
    //            Id = product.Id,
    //            Price = product.Price,
    //            ImageUrl = product.ImageUrl
    //        }).ToList();
    //    }
    //}
}
