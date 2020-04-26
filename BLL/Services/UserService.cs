using AutoMapper;
using BLL;
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
        Information Information = new Information();
        public UserService(IUnitOfWork unitOfWork)
        {
            UOW = unitOfWork;
        }

        public async Task<Information> CreateAsync(UserDTO userDTO)
        {
            User user = new User
            {
                UserName = userDTO.Name,  
                Email = userDTO.Email
            };
            var e = await UOW.UserManager.FindByEmailAsync(user.Email);
            if (e == null)
            {
                var result = await UOW.UserManager.CreateAsync(user, userDTO.Password);
                if (!result.Succeeded)
                {
                    Information.Message += result.Errors;
                    Information.Success = false;
                } 
                else
                {
                    Information.Message += "Success";
                }
            }
            else
            {
                Information.Message += "The user is already registered \n";
                Information.Success = false;
            }

            return Information;
           
        }

    }
}