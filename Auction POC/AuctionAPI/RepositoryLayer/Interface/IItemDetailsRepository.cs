using DomainLayer.Entities;
using System.Collections.Generic;

namespace Repositories.Interface
{
    public interface IItemDetailsRepository
    {
        ItemDetails Add(ItemDetails itemDetails);

        List<ItemDetails> List();
    }
}
