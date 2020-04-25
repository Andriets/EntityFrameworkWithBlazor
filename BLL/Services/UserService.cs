using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
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

        public async void CreateAsync(User user)
        {
            await UOW.UserManager.CreateAsync(user);
        }

    }
}