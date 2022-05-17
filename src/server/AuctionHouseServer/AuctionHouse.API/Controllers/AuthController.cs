using AuctionHouse.API.Dtos;
using AuctionHouse.Core;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AuctionHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterUserDto userDto)
        {
            //if (userDto.BirthDate.Year < 2004)
            //{
            //    return BadRequest("User immature");
            //}

            try
            {
                var user = new User()
                {
                    Name = userDto.Name,
                    Email = userDto.Email,
                    BirthDate = userDto.BirthDate,
                    Surname = userDto.Surname
                };
                _authService.Register(user);
            }
            catch (Exception e)
            {

                return BadRequest(new Error(e.Message)
                {
                    Redirect = "auth/login"
                });
            }

            return Ok();
        }

        public class Error
        {
            public string Message { get; set; }
            public string Redirect { get; set; }

            public Error(string message)
            {
                Message = message;
            }
        }
    }
}
