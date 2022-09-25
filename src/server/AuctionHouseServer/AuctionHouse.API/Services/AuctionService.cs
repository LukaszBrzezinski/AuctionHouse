using AuctionHouse.API.DTO;
using AuctionHouse.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Services
{
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository _auctionRepository;

        public AuctionService(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public bool AddAuction(AuctionDto dto)
        {
            _auctionRepository.GetAuctionList().Add(dto);
            return true;
        }

        public bool BuyAuction(AuctionDto dto)
        {
       //     var auction = _auctionRepository.GetAuctionList().Single(item => item.Id == dto.Id);
            throw new NotImplementedException("Brakuje funkcji Buy w AuctionRepository");
            //   auction.Buy();

            return true;
        }

        public bool DeleteAuction(AuctionDto dto)
        {
            throw new NotImplementedException("Brakuje funkcji Delete w AuctionRepository");
          //  var element = _auctionRepository.Delete(dto.Id);
            //.GetAuctionList().Single(item => item.Id == dto.Id);
            //_auctionRepository.GetAuctionList().Remove(element);
            return true;
        }
    }

    public class Auction{
        public int? BoughtByUserId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public void Buy(int byUserId)
        {
            if (BoughtByUserId == null)
            {
                throw new ArgumentException(nameof(byUserId));
            }
            BoughtByUserId = byUserId;
        }

        internal void MarkAsDeleted(int userID)
        {
            if (DeletedAt != null)
            {

            }
            DeletedAt = DateTime.Now;
        }
    }

}
