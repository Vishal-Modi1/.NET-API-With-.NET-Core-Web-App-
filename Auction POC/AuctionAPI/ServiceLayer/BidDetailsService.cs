using DomainLayer.Entities;
using Repositories;
using Repositories.Interface;
using Services.Interface;
using System.Collections.Generic;

namespace Services
{
    public class BidDetailsService : IBidDetailsService
    {
        private readonly IBidDetailsRepository _bidDetailsRepository;
        public BidDetailsService()
        {
            _bidDetailsRepository = new BidDetailsRepository();
        }

        public List<BidDetails> Add(List<BidDetails> bidDetails)
        {
            return _bidDetailsRepository.Add(bidDetails);
        }
    }
}
