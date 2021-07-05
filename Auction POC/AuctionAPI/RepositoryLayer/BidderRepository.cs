using DomainLayer.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class BidderRepository : IBidderRepository
    {
        private DBContext _dBContext;

        public List<Bidder> Add(List<Bidder> biddersList)
        {
            using (_dBContext = new DBContext())
            {
                biddersList.ForEach(p => { p.CreateOn = DateTime.Now; });

                _dBContext.Bidders.AddRange(biddersList);
                _dBContext.SaveChanges();

                return biddersList;
            }
        }

        public List<Bidder> List()
        {
            using (_dBContext = new DBContext())
            {
                List<Bidder> bidders = _dBContext.Bidders.ToList();
                return bidders;
            }
        }
    }
}
