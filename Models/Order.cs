using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int SupermarketId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public Customer Customer { get; set; }

        [Required]
        public Supermarket Supermarket { get; set; }
    }
}
