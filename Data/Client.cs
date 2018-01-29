using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Client
    {
        [Key]
        public string Id { get; set; }
        public string RelatedBankerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal NetWorth { get; set; }
    }
}