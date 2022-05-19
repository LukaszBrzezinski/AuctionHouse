using AuctionHouse.API.DTO;
using AuctionHouse.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRegisterUserService _registerUser;

        public UsersController(IRegisterUserService registerUser)
        {
            _registerUser = registerUser;
        }

        [HttpPost]
        public bool Post([FromBody] UserCredentials userCredentials)
        {
            UserDto dto = new UserDto(userCredentials);

            if (_registerUser.RegisterUser(dto))
            {
                _registerUser.GetUserList().Add(dto);
                return true;
            }
            return false;
        }

        [HttpGet]
        public bool Get([FromBody] string email)
        {
            return _registerUser.GetUserList().Exists(item => item.getEmail() == email);
        }
    }
}
