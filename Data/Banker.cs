using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Banker
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}