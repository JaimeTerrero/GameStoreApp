﻿using Application.Repository;
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
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(ApplicationContext dbContext)
        {
            _userRepository = new(dbContext);
        }

        public async Task Add(SaveUserViewModel vm)
        {
            User user = new();
            user.Name = vm.Name;
            user.Email = vm.Email;
            user.Phone = vm.Phone;
            user.Username = vm.Username;
            user.Password = vm.Password;

            await _userRepository.AddAsync(user);
        }

        public async Task Update(SaveUserViewModel vm)
        {
            User user = new();
            user.Id = vm.Id;
            user.Name = vm.Name;
            user.Email = vm.Email;
            user.Phone = vm.Phone;
            user.Username = vm.Username;
            user.Password = vm.Password;

            await _userRepository.UpdateAsync(user);
        }

        public async Task Delete(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            await _userRepository.DeleteAsync(user);
        }

        public async Task<SaveUserViewModel> GetByIdViewModel(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            SaveUserViewModel vm = new();
            vm.Id = user.Id;
            vm.Name = user.Name;
            vm.Email = user.Email;
            vm.Phone = user.Phone;
            vm.Username = user.Username;
            vm.Password = user.Password;

            return vm;
        }

        public async Task<List<UserViewModel>> GetAllViewModel()
        {
            var userList = await _userRepository.GetAllAsync();

            return userList.Select(user => new UserViewModel
            {
                Name = user.Name,
                Email = user.Email,
                Id = user.Id,
                Phone = user.Phone,
                Username = user.Username,
                Password = user.Password
            }).ToList();
        }
    }
}
