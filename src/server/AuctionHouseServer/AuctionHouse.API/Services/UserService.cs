using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
    public class UserService: IUserService
    {
        public IUserRepository UserRepository;
            
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        public bool CheckIfCanSetUpAccount(UserDto userdto)
        {
            if (UserRepository.GetUsersList().Exists(item => item.Email == userdto.Email))
            {
                return false;
            }
            if (userdto.Password.Length >= 6)
            {
                return true;
            }
            return false;
        }

        public IUserRepository GetUserRepository()
        {
            return UserRepository;
        }
    }
}
