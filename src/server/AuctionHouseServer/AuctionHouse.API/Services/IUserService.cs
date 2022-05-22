using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
    public interface IUserService
    {
        public bool CheckIfCanSetUpAccount(UserDto userdto);
        public IUserRepository GetUserRepository();
    }
}
