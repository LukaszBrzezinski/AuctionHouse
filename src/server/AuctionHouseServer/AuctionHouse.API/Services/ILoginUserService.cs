using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public interface ILoginUserService
    {
        public bool LoginUser(UserDto userDto);
    }
}
