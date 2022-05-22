using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Repositories
{
    public interface IUserRepository
    {
        public List<UserDto> GetUsersList();
    }
}
