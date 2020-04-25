using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IUserService
    {
        void CreateAsync(User user);
    }
}
