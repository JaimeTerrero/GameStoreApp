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
    public class InventaryService
    {
        private readonly InventaryRepository _inventaryRepository;
        private readonly ProductRepository _productRepository;
        public InventaryService(ApplicationContext dbContext)
        {
            _inventaryRepository = new(dbContext);
            _productRepository = new(dbContext);
        }
        public async Task<InventaryViewModel> Add(SaveInventaryViewModel vm)
        {
            var inventary = await _inventaryRepository.GetByUserId(vm.UserId);

            Inventary inventaryUser = new();

            inventaryUser.UserId = vm.UserId;

            if (inventary == null)
            {

                inventaryUser.Quantity = 0;

                inventary = await _inventaryRepository.AddAsync(inventaryUser);
            }


            SavingProductsInventary spi = new();

            spi.ProductId = vm.ProductId;
            spi.InventaryId = inventary.Id;

            await _inventaryRepository.AddItemToInventary(spi);
            inventary.Quantity += 1;
            await _inventaryRepository.UpdateItem(inventary.Id, inventary);

            return await GetByIdViewModel(inventary.Id);

        }

        public async Task Delete(int id)
        {
            var inventary = await _inventaryRepository.GetByIdAsync(id);
            await _inventaryRepository.DeleteAsync(inventary);
        }

        public async Task<InventaryViewModel> GetByIdViewModel(int userId)
        {
            var inventary = await _inventaryRepository.GetByUserId(userId);

            if (inventary == null)
            {
                return null;
            }

            var product = await _productRepository.GetAllProducts(inventary.Id);

            InventaryViewModel inventaryViewModel = new();

            inventaryViewModel.Id = inventary.Id;
            inventaryViewModel.Quantity = inventary.Quantity;
            inventaryViewModel.UserId = inventary.UserId;

            var productList = new List<ProductViewModel>();
            foreach (var item in product)
            {
                ProductViewModel pvm = new();
                pvm.Id = item.Id;
                pvm.CategoryId = item.CategoryId;
                pvm.ImageUrl = item.ImageUrl;
                pvm.Description = item.Description;
                pvm.Name = item.Name;
                pvm.Price = item.Price;
                productList.Add(pvm);
            }

            inventaryViewModel.Products = productList;

            //var products = _inventaryRepository.GetAllProductsByInventary(inventary.Id);
            //List<ProductViewModel> =

            return inventaryViewModel;
        }

        public async Task<InventaryViewModel> GetByUserId(int id)
        {
            var inventary = await _inventaryRepository.GetByUserId(id);
            if (inventary == null)
            {
                return null;
            }

            InventaryViewModel ivm = new();
            ivm.Id = inventary.Id;
            ivm.Quantity = inventary.Quantity;
            ivm.UserId = inventary.UserId;


            return ivm;
        }
    }
}
