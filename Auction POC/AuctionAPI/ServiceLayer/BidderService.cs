using DomainLayer.Entities;
using Repositories;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BidderService : IBidderService
    {
        private readonly IBidderRepository _bidderRepository;
        public BidderService()
        {
            _bidderRepository = new BidderRepository();
        }

        public List<Bidder> Add(List<Bidder> biddersList)
        {
            return _bidderRepository.Add(biddersList);
        }

        public List<Bidder> List()
        {
            return _bidderRepository.List();
        }
    }
}
