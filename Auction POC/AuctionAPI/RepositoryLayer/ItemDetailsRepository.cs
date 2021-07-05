using DomainLayer.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class ItemDetailsRepository : IItemDetailsRepository
    {
        private DBContext _dBContext;

        public ItemDetails Add(ItemDetails itemDetails)
        {
            using (_dBContext = new DBContext())
            {
                itemDetails.CreateOn = DateTime.Now;
                _dBContext.ItemDetails.Add(itemDetails);
                _dBContext.SaveChanges();

                return itemDetails;
            }
        }

        public List<ItemDetails> List()
        {
            using (_dBContext = new DBContext())
            {
                List<ItemDetails> itemDetailsList = _dBContext.ItemDetails.ToList();
                return itemDetailsList;
            }
        }
    }
}
