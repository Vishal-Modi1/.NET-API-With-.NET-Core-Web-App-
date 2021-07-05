using DomainLayer.Entities;
using Repositories;
using Repositories.Interface;
using Services.Interface;
using System.Collections.Generic;

namespace Services
{
    public class ItemDetailsService : IItemDetailsService
    {
        private readonly IItemDetailsRepository _itemDetailsRepository;
        public ItemDetailsService()
        {
            _itemDetailsRepository = new ItemDetailsRepository();
        }

        public ItemDetails Add(ItemDetails itemDetails)
        {
           return _itemDetailsRepository.Add(itemDetails);
        }

        public List<ItemDetails> List()
        {
            return _itemDetailsRepository.List();
        }
    }
}
