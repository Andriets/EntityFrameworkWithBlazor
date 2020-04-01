using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Insert(User obj);
        void Update(User obj);
        void Delete(int id);
    }
}
