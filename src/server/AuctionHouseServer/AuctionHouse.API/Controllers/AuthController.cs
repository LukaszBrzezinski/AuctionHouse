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
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("register")]
        public bool Register([FromBody] UserCredentials userCredentials)
        {
            UserDto dto = new UserDto(userCredentials);
            return _userService.RegisterUser(dto);
        }

        [HttpPost]
        [Route("login")]
        public bool Login([FromBody] UserCredentials userCredentials)
        {
            UserDto dto = new UserDto(userCredentials);
            return _userService.LoginUser(dto);
        }
    }
}
