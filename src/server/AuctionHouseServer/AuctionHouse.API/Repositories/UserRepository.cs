using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserDto> userList = new List<UserDto>();


        public IReadOnlyCollection<UserDto> GetUsersList()
        {
            return userList.AsReadOnly();
        }

        private bool IsUserNameExists(string userName, string email)
        {
            return userList.Exists(item => item.Name == userName) ||
               userList.Exists(item => item.Email == email);
        }

        public bool IsUserExists(string userName, string email, string password)
        {
            return IsUserNameExists(userName, email) &&
            userList.Exists(item => item.Password.password == password);
        }
        public bool Add(UserDto userDto)
        {
            if ((!IsUserNameExists(userDto.Name, userDto.Email)) && userDto.Password.IsCorrectPassword() == "")
            {
                userList.Add(userDto);
                return true;
            }
            else
            {
                return false;
            }


        }



    }
}
