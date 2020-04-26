using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork UOW;
        public UserService(IUnitOfWork unitOfWork)
        {
            UOW = unitOfWork;
        }

        public async Task<bool> CreateAsync(UserDTO userDTO)
        {
            User user = new User
            {
                UserName = "User",
                Email = userDTO.Email
            };
           
           var result = await UOW.UserManager.CreateAsync(user, userDTO.Password);
           

            return result.Succeeded;
           
        }

    }
}