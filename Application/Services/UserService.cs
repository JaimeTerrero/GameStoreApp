using Application.Dtos.Email;
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
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly IEmailService _emailService;

        public UserService(ApplicationContext dbContext, IEmailService emailService)
        {
            _userRepository = new(dbContext);
            _emailService = emailService;
        }

        public async Task<SaveUserViewModel> Add(SaveUserViewModel vm)
        {
            User user = new();
            user.Name = vm.Name;
            user.LastName = vm.LastName;
            user.Email = vm.Email;
            user.Phone = vm.Phone;
            user.Username = vm.Username;
            user.Password = vm.Password;

            user = await _userRepository.AddAsync(user);

            SaveUserViewModel userVm = new();
            userVm.Id = user.Id;
            userVm.Name = user.Name;
            userVm.LastName = user.LastName;
            userVm.Email = user.Email;
            userVm.Phone = user.Phone;
            userVm.Username = user.Username;
            userVm.Password = user.Password;

            await _emailService.SendAsync(new EmailRequest
            {
                To = user.Email,
                Subject = "Bienvenido a nuestra tienda GameStoreApp",
                Body = $"<h1>Sea bienvenido a GameStoreApp.</h1> <p>Su usuario es {user.Username}.</p>"
            });

            return userVm;
        }

        public async Task Update(SaveUserViewModel vm)
        {
            User user = new();
            user.Id = vm.Id;
            user.Name = vm.Name;
            user.LastName = vm.LastName;
            user.Email = vm.Email;
            user.Phone = vm.Phone;
            user.Username = vm.Username;
            user.Password = vm.Password;

            await _userRepository.UpdateAsync(user);
        }

        public async Task<UserViewModel> Login(LoginViewModel loginVm)
        {
            User user = await _userRepository.LoginAsync(loginVm);

            if(user == null)
            {
                return null;
            }

            UserViewModel userVm = new();
            userVm.Id = user.Id;
            userVm.Name = user.Name;
            userVm.LastName = user.LastName;
            userVm.Email = user.Email;
            userVm.Phone = user.Phone;
            userVm.Username = user.Username;
            userVm.Password = user.Password;

            return userVm;
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
            vm.LastName = user.LastName;
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
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                Username = user.Username,
                Password = user.Password
            }).ToList();
        }


    }
}
