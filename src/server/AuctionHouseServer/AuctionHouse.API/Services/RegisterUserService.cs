using System;
using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public class RegisterUserService: IRegisterUserService
    {
        public RegisterUserService()
        {
        }

        public bool RegisterUser(UserDto userdto)
        {
            //check if user with such credential exists in the database;
            //if so return false;
            //if not add him to database and return true;
            return true;
        }
    }
}
