using System;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    public class Winner : BaseIdentity
    {
        public int BidDetailsId { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
