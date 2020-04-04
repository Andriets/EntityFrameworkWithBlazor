using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        Task<User> GetById(int id);
        void Insert(User obj);
        void Update(User obj);
        void Delete(int id);
    }
}
