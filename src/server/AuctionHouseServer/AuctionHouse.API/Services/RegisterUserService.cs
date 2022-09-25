using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;

namespace AuctionHouse.API.Services
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool RegisterUser(UserDto userDto)
        {
            return _userRepository.Add(userDto);
        }
    }
}
