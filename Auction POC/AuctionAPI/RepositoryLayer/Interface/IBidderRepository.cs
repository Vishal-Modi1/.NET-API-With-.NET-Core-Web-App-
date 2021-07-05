using DomainLayer.Entities;
using System.Collections.Generic;

namespace Repositories.Interface
{
    public interface IBidderRepository
    {
        List<Bidder> Add(List<Bidder> biddersList);

        List<Bidder> List();
    }
}
