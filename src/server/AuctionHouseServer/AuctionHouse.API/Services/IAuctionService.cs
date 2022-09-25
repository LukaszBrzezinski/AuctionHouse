using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
    public interface IAuctionService
    {
        public bool AddAuction(AuctionDto dto);
        public bool DeleteAuction(AuctionDto dto);
        public bool BuyAuction(AuctionDto dto);
    }
}
