using System;

namespace AuctionHouse.API.Dtos
{
    public class RegisterUserDto
    {
        public string Email { get; set; }
        public string Paswwrod { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
