using System.ComponentModel.DataAnnotations;

namespace MarketingDomain.Data
{
    public class Client
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
