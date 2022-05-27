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
            var element = _auctionRepository.GetAuctionList().Single(item => item.Id == dto.Id);
            element.Status = false;
            return true;
        }

        public bool DeleteAuction(AuctionDto dto)
        {
            var element = _auctionRepository.GetAuctionList().Single(item => item.Id == dto.Id);
            _auctionRepository.GetAuctionList().Remove(element);
            return true;
        }
    }
}
