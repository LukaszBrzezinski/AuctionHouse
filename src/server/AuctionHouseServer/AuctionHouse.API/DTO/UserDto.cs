using AuctionHouse.API.Services;
using System;

namespace AuctionHouse.API.DTO
{
    public class UserDto
    {
        public string Name;
        public Password Password;
        public string Email;
        public string DateOfBirth;
        public UserDto(UserCredentials userCredentials)
        {
            Name = userCredentials.Username;
            Password = userCredentials.Password;
            Email = userCredentials.Email;
            DateOfBirth = userCredentials.Date;
        }
    }
}
