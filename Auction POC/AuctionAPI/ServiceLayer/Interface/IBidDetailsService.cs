using DomainLayer.Entities;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IBidDetailsService
    {
        List<BidDetails> Add(List<BidDetails> bidDetails);
    }
}
