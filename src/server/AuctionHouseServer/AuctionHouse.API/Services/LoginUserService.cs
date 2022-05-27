using System;
using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;

namespace AuctionHouse.API.Services
{
    public class LoginUserService : ILoginUserService
    {
        private readonly IUserRepository _userRepository;

        public LoginUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool LoginUser(UserDto userDto)
        {
            if((_userRepository.GetUsersList().Exists(item => item.Name == userDto.Name) ||
                _userRepository.GetUsersList().Exists(item => item.Email == userDto.Email)) &&
                _userRepository.GetUsersList().Exists(item => item.Password == userDto.Password))
            {
                return true;
            }
            return false;
        }
    }
}
