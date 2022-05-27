using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public interface IUserService
    {
        public bool RegisterUser(UserDto userDto);
        public bool LoginUser(UserDto userDto);
    }
}
