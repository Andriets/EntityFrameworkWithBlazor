using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    public class UserController : Controller
    {
        #region Propertirs
        IUserService _UserService;
        private readonly IMapper _mapper;
        IGenericRepository<User> repo;
        #endregion

        #region Constructors
        public UserController(IUserService sqlOrderService, IMapper mapper)
        {
            _UserService = sqlOrderService;
            _mapper = mapper;  
        }
        #endregion
        public IActionResult Index()
        {
            // Populate the user details from DB
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserView>());
            var mapper = new Mapper(config);

            var users = mapper.Map<List<UserView>>(repo.GetAll());

            return View(users);
        }
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
