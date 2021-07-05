using DomainLayer.Entities;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IItemDetailsService
    {
        ItemDetails Add(ItemDetails itemDetails);

        List<ItemDetails> List();
    }
}
