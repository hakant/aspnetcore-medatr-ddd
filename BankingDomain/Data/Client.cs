using System.ComponentModel.DataAnnotations;

namespace BankingDomain.Data
{
    public class Client
    {
        [Key]
        public string Id { get; set; }
        public string RelatedBankerId { get; set; }
        public string Name { get; set; }
        public decimal NetWorth { get; set; }
    }
}
