using AuctionHouse.API.DTO;
using AuctionHouse.API.Services;
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

        public Auction GetAuction(int auctionId)
        {
            var auction =auctionList.SingleOrDefault(a => a.Id == auctionId && a.DeletedAt != null);
            return auction;
        }

        public void Remove(int auctionId)
        {
            var auction = GetAuction(auctionId);
            auction.MarkAsDeleted();
        }
    }
}
