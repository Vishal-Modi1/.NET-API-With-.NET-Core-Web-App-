using DomainLayer.Entities;
using System.Collections.Generic;

namespace DomainLayer.ViewModels
{
    public class BidAutionDetailsVM
    {
        public List<Bidder> Bidders { get; set; }
        public ItemDetails ItemDetails { get; set; }

        public List<BidDetailsVM> BidDetails { get; set; }

        public List<BidDetails> BidDetailsList { get; set; }
    }
}
