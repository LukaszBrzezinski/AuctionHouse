using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
   public interface ICreateUserService
    {
        public void AddUser(UserCredentials userCredentials);
    }
}
