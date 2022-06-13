using AuctionHouse.API.Services;
using System;
namespace AuctionHouse.API.DTO
{
    public class UserCredentials
    {
        public string Username { get; set; }
        public Password Password { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
    }
}
