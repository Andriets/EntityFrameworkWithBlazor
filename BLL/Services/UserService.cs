using AutoMapper;
using BLL;
using BLL.DTO;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork UOW;
        private readonly ApplicationSettings _appSettings;
        public UserService(IUnitOfWork unitOfWork, IOptions<ApplicationSettings> appSettings)
        {
            UOW = unitOfWork;
            _appSettings = appSettings.Value;
        }

        public async Task<Information> CreateAsync(UserDTO userDTO)
        {
            User user = new User
            {
                UserName = userDTO.Name,  
                Email = userDTO.Email
            };
            Information Information = new Information();
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
                    //var role = await UOW.UserManager.AddToRoleAsync(user, userDTO.Role);
                }
            }
            else
            {
                Information.Message += "The user is already registered \n";
                Information.Success = false;
            }
            return Information;        
        }

        public async Task<Information> SignInAsync(UserDTO userDTO)
        {
            User user = await UOW.UserManager.FindByEmailAsync(userDTO.Email);
            Information Information = new Information();
            if (user != null)
            {
                var res = await UOW.SignInManager.PasswordSignInAsync(user, userDTO.Password, false, false);
                if (!res.Succeeded)
                {
                    Information.Message += "Failed";
                    Information.Success = false;
                }
                else
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("UserID", user.Id.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(15),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    Information.Message += "Success";
                    Information.Token = token;
                }
            }
            else
            {
                Information.Success = false;
                Information.Message += "NULL";
            }
            
            return Information;
        }

        public void Logout()
        {
            UOW.SignInManager.SignOutAsync();
        }

    }
}