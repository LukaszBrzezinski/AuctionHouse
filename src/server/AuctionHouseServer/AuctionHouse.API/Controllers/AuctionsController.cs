using AuctionHouse.API.DTO;
using AuctionHouse.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionService _auctionService;

        public AuctionsController(IAuctionService auctionService)
        {
            _auctionService = auctionService;
        }

        [HttpPost]
        [Route("add")]
        public bool AddAuction(AuctionCredentials credentials)
        {
            AuctionDto dto = new AuctionDto(credentials);
            return _auctionService.AddAuction(dto);
        }

        [HttpDelete]
        [Route("delete")]
        public bool DeleteAuction(AuctionCredentials credentials)
        {
            AuctionDto dto = new AuctionDto(credentials);
            return _auctionService.DeleteAuction(dto);
        }

        [HttpPatch]
        [Route("buy")]
        public bool BuyAuction(AuctionCredentials credentials)
        {
            AuctionDto dto = new AuctionDto(credentials);
            return _auctionService.BuyAuction(dto);
        }
    }
}
