using System;

namespace DomainLayer.Entities
{
    public class ItemDetails : BaseIdentity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
