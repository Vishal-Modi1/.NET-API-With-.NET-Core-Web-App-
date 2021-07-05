using DomainLayer.Entities;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IBidderService
    {
        List<Bidder> Add(List<Bidder> biddersList);

        List<Bidder> List();
    }
}
