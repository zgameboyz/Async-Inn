using HotelApi.Models.DTO;
using HotelApi.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HotelApi.Models.Services
{
    public class IdentityUserService : IUser
    {

        private UserManager<ApplicationUser> userManager;

        public IdentityUserService(UserManager<ApplicationUser> manager)
        {
            userManager = manager;
        }

        public async Task<UserDto> Login(string username, string password)
        {
            // 1. Is the user in the database (registered?)
            var user = await userManager.FindByNameAsync(username);

            // Is the password legit?
            if (await userManager.CheckPasswordAsync(user, password))
            {
                return new UserDto
                {
                    Id = user.Id,
                    Username = user.UserName
                };
            }

            return null;
        }

        public async Task<UserDto> Register(RegisterUserDto data, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser
            {
                UserName = data.Username,
                Email = data.Email,
                PhoneNumber = data.PhoneNumber
            };

            var result = await userManager.CreateAsync(user, data.Password);

            if (result.Succeeded)
            {

                return new UserDto
                {
                    Id = user.Id,
                    Username = user.UserName
                };
            }

            foreach (var error in result.Errors)
            {
                var errorKey =
                  error.Code.Contains("Password") ? nameof(data.Password) :
                  error.Code.Contains("Email") ? nameof(data.Email) :
                  error.Code.Contains("UserName") ? nameof(data.Username) :
                  "";

                modelState.AddModelError(errorKey, error.Description);

            }

            return null;


        }

       

        Task<UserDto> IUser.Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetUserAsync(ClaimsPrincipal principal)
        {
            var user = await userManager.GetUserAsync(principal);
            return new UserDto
            {
                Id = user.Id,
                Username = user.UserName
            };
        }
    }

}