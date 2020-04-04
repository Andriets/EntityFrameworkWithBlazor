using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    public class UserController : ControllerBase
    {
        #region Propertirs
        IUserService _UserService;
        #endregion

        #region Constructors
        public UserController(IUserService sqlOrderService)
        {
            _UserService = sqlOrderService;
        }
        #endregion

        #region APIs
        [Route("Users")]
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _UserService.GetAll();
        }

        [Route("User/{Id}")]
        [HttpGet]
        public Task<User> Get(int Id)
        {
            return _UserService.GetById(Id);
        }

        [Route("User")]
        [HttpPost]
        public void Post([FromBody]User user)
        {
            _UserService.Insert(user);
        }

        [Route("User/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _UserService.Delete(id);
        }

        #endregion
    }
}
