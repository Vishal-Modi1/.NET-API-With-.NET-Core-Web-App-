using System;

namespace DomainLayer.Entities
{
    public class BidDetails : BaseIdentity
    {
        public int ItemId { get; set; }
        
        public int BidderId { get; set; }

        public decimal BidAmount { get; set; }

        public decimal Profit { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
