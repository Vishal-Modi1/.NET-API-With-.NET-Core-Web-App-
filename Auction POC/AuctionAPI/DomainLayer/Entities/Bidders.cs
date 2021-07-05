using System;

namespace DomainLayer.Entities
{
    public class Bidder : BaseIdentity
    {
        public string Name { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
