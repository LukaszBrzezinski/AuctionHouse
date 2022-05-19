using System;
namespace AuctionHouse.API.DTO
{
    public class UserDto
    {
        private string _name;
        private string _password;
        private string _email;
        private string _dateOfBirth;
        public UserDto(UserCredentials userCredentials)
        {
            _name = userCredentials.Username;
            _password = userCredentials.Password;
            _email = userCredentials.Email;
            _dateOfBirth = userCredentials.Date;
        }

        public string getEmail()
        {
            return _email;
        }
    }
}
