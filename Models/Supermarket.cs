using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Supermarket
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
    }
}
