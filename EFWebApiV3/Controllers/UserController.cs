using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    public class UserController : ControllerBase
    {
        #region Propertirs
        IUserService _UserService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public UserController(IUserService userService, IMapper mapper)
        {
            _UserService = userService;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("Users")]
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
            var models = _UserService.GetAll().ToList();
/*          var config = new MapperConfiguration(mc => mc.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);*/

            return _mapper.Map<List<User>, List<UserDTO>>(models);
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
