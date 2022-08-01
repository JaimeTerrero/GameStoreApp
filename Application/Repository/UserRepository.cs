using Application.Helpers;
using Application.ViewModels;
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
    public class UserRepository
    {
        private readonly ApplicationContext _dbContext;

        public UserRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> AddAsync(User user)
        {
            user.Password = PasswordEncryption.ComputeSha256Hash(user.Password);
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task UpdateAsync(User user)
        {
            user.Password = PasswordEncryption.ComputeSha256Hash(user.Password);
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            _dbContext.Set<User>().Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbContext.Set<User>().ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Set<User>().FindAsync(id);
        }

        public virtual async Task<List<User>> GetAllWithIncludeAsync(List<string> properties)
        {
            var query = _dbContext.Set<User>().AsQueryable();

            foreach (string property in properties)
            {
                query = query.Include(property);
            }

            return await query.ToListAsync();
        }

        public async Task<User> LoginAsync(LoginViewModel loginVm)
        {
            string passwordEncrypt = PasswordEncryption.ComputeSha256Hash(loginVm.Password);
            User user = await _dbContext.Set<User>()
                .FirstOrDefaultAsync(user => user.Username == loginVm.Username && user.Password == passwordEncrypt);
            return user;
        }
    }
}
