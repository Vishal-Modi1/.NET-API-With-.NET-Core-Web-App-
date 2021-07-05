using DomainLayer.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class BidDetailsRepository : IBidDetailsRepository
    {
        private DBContext _dBContext;

        public List<BidDetails> Add(List<BidDetails> bidDetails)
        {
            using (_dBContext = new DBContext())
            {
                bidDetails.ForEach(p => { p.CreateOn = DateTime.Now; });
                _dBContext.BidDetails.AddRange(bidDetails);
                _dBContext.SaveChanges();

                return bidDetails;
            }
        }
    }
}
