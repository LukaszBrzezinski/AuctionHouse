using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Repositories
{
    public interface IUserRepository
    {
        IReadOnlyCollection<UserDto> GetUsersList();
        bool IsUserExists(string userName, string email, string password);
        bool Add(UserDto userDto);
    }
}
