using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserDto> userList = new List<UserDto>();

        public List<UserDto> GetUsersList()
        {
            return userList;
        }
    }
}
