using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class InventaryRepository
    {
        private readonly ApplicationContext _dbContext;

        public InventaryRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Inventary> AddAsync(Inventary inventary)
        {
            await _dbContext.Inventaries.AddAsync(inventary);
            await _dbContext.SaveChangesAsync();
            return inventary;
        }

        public async Task AddItemToInventary(SavingProductsInventary savingProductsInventary)
        {
            await _dbContext.SavingProductsInventaries.AddAsync(savingProductsInventary);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateItem(int id, Inventary inventary)
        {
            var entry = await _dbContext.Set<Inventary>().FindAsync(id);
            _dbContext.Entry(entry).CurrentValues.SetValues(inventary);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Inventary inventary)
        {
            _dbContext.Set<Inventary>().Remove(inventary);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Inventary>> GetAllAsync()
        {
            return await _dbContext.Set<Inventary>().ToListAsync();
        }

        public async Task<Inventary> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Inventary>().FindAsync(id);
        }

        public async Task<Inventary> GetByUserId(int id)
        {
            var result = await _dbContext.Set<Inventary>().ToListAsync();
            return result.Where(x => x.UserId == id).FirstOrDefault();
        }

        public virtual async Task<List<Inventary>> GetAllWithIncludeAsync(List<string> properties)
        {
            var query = _dbContext.Set<Inventary>().AsQueryable();

            foreach (string property in properties)
            {
                query = query.Include(property);
            }

            return await query.ToListAsync();
        }
    }
}
