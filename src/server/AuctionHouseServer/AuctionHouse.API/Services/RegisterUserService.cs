using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;

namespace AuctionHouse.API.Services
{
    public class RegisterUserService: IRegisterUserService
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        bool CheckIfCanSetUpAccount(UserDto userDto)
        {
            if (_userRepository.GetUsersList().Exists(item => item.Email == userDto.Email) ||
                _userRepository.GetUsersList().Exists(item => item.Name == userDto.Name))
            {
                return false;
            }
            else if (userDto.Password.Length >= 6)
            {
                return true;
            }
            return false;
        }

        public bool RegisterUser(UserDto userDto)
        {
            if (CheckIfCanSetUpAccount(userDto))
            {
                _userRepository.GetUsersList().Add(userDto);
                return true;
            }
            else return false;
        }
    }
}
