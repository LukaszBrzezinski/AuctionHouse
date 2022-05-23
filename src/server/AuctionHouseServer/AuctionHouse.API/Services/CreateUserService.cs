using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
    public class CreateUserService : ICreateUserService
    {
     
        public IUserRepository UserRepository;

        public CreateUserService(IUserRepository userRepository)
        {
            
            UserRepository = userRepository;
        }
        public void AddUser(UserCredentials userCredentials)
        {
            UserDto userDto = new UserDto(userCredentials);
           
            UserRepository.GetUsersList().Add(userDto);
           


        }
    }
}
