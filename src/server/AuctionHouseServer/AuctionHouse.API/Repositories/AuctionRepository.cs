using AuctionHouse.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Repositories
{
    public class AuctionRepository : IAuctionRepository
    {
        private List<AuctionDto> auctionList = new List<AuctionDto>();

        public List<AuctionDto> GetAuctionList()
        {
            return auctionList;
        }
    }
}
