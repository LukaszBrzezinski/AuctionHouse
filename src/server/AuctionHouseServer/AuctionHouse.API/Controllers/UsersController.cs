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
    [Route("api")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRegisterUserService _registerUser;
        private readonly ICreateUserService _createUserService;
        //Można zrobić tak public UsersController(IRegisterUserService registerUser)
        public UsersController(IRegisterUserService registerUser, ICreateUserService createUserService)
        {
            _registerUser = registerUser;
            _createUserService = createUserService;
        }

        [HttpPost]
        public bool Post([FromBody] UserCredentials userCredentials)
        {
            UserDto dto = new UserDto(userCredentials);
            return _registerUser.RegisterUser(dto);
        }
        [HttpPost]
        [Route("AddUser")]
        public void AddUser([FromBody] UserCredentials userCredentials)
        {
           _createUserService.AddUser(userCredentials);
        }

        [HttpGet]
        public string Get()
        {
            return "XD";
        }
    }
}
