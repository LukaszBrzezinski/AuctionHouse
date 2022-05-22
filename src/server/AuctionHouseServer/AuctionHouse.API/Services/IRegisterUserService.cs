using System;
using System.Collections.Generic;
using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public interface IRegisterUserService
    {
        bool RegisterUser(UserDto userdto);
    }
}
