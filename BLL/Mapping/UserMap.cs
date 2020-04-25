using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using Microsoft.AspNetCore.Identity;

namespace BLL.Mapping
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
