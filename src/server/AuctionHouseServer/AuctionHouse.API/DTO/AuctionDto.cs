using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.API.DTO
{
    public class AuctionDto
    {
        public int Id;
        public string Name;
        public string Price;
        public string Date;
        public string Description;
        public bool Status;
        public AuctionDto(AuctionCredentials auctionCredentials)
        {
            Id = auctionCredentials.Id;
            Name = auctionCredentials.Name;
            Price = auctionCredentials.Price;
            Date = auctionCredentials.Date;
            Description = auctionCredentials.Description;
            Status = auctionCredentials.Status;
        }
    }
}
