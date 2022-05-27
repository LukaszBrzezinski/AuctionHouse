using AuctionHouse.API.DTO;
using System;

namespace AuctionHouse.API.Services
{
    public class UserService : IUserService
    {
        private readonly IRegisterUserService _registerUserService;
        private readonly ILoginUserService _loginUserService;

        public UserService(IRegisterUserService registerUserService, ILoginUserService loginUserService)
        {
            _registerUserService = registerUserService;
            _loginUserService = loginUserService;
        }

        public bool LoginUser(UserDto userDto)
        {
            return _loginUserService.LoginUser(userDto);
        }

        public bool RegisterUser(UserDto userDto)
        {
            return _registerUserService.RegisterUser(userDto);
        }
    }
}
