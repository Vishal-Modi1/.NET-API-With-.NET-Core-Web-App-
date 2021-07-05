using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    public class BaseIdentity
    {
        [Key]
        public int Id { get; set; }
    }
}
