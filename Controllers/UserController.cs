using AutoMapper;
using BankAPI.DTOs;
using BankAPI.Handler;
using BankAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UserController : Controller
    {
        private readonly IUserHandler _userHandler;
        readonly IMapper _mapper;
        public UserController(IUserHandler userHandler, IMapper mapper)
        {
            _userHandler = userHandler;
            _mapper = mapper;
        }
        [HttpGet] public IActionResult Get()=> Ok(_userHandler.Get());

        [HttpPost] 
        public  IActionResult AddUser(UserDTO addUser)
        {
            var model=_mapper.Map<Bank>(addUser);
            _userHandler.Add(model);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateUser(UserDTO updateUser)
        {
            _userHandler.Update(updateUser);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            _userHandler.Delete(_userHandler.GetById(id));
            return Ok();
        }
    }
}
