using System;
using System.Linq;
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
            return !_userRepository.IsUserExists(userDto.Name, userDto.Email, userDto.Password.password);
        }
       
     }
}
