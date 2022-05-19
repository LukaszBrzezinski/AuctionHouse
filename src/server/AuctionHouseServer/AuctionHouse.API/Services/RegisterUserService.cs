using System;
using System.Collections.Generic;
using AuctionHouse.API.DTO;

namespace AuctionHouse.API.Services
{
    public class RegisterUserService: IRegisterUserService
    {
        private List<UserDto> userList = new List<UserDto>();

        public List<UserDto> GetUserList()
        {
            return userList;
        }

        public bool RegisterUser(UserDto userdto)
        {
            //check if user with such credential exists in the database;
            //if so return false;
            //if not add him to database and return true;
            if(userList.Exists(item => item.getEmail() == userdto.getEmail()))
            {
                return false;
            }
            userList.Add(userdto);
            return true;
        }
    }
}
