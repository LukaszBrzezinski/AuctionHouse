using System;
using System.Collections.Generic;
using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public class RegisterUserService: IRegisterUserService
    {
        private readonly IUserService _userService;

        public RegisterUserService(IUserService userService)
        {
            _userService = userService;
        }

        public bool RegisterUser(UserDto userdto)
        {
            if (_userService.CheckIfCanSetUpAccount(userdto))
            {
                _userService.GetUserRepository().GetUsersList().Add(userdto);
                return true;
            }
            else return false;
        }
    }
}
