using DomainLayer.Entities;
using System.Collections.Generic;

namespace Repositories.Interface
{
    public interface IBidDetailsRepository
    {
        List<BidDetails> Add(List<BidDetails> bidDetails);
    }
}
