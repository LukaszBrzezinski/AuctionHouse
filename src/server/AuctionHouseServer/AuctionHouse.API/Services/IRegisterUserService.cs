using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public interface IRegisterUserService
    {
        public bool RegisterUser(UserDto userdto);
    }
}
