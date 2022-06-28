using Application.Repository;
using Application.ViewModels;
using Database;
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
    }
}
