using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HotelApi.Models.Interfaces
{
    public interface IUser
    {
        public Task<UserDto> Register(RegisterUserDto data, ModelStateDictionary modelState);
        public Task<UserDto> Login(string username, string password);
    }
}