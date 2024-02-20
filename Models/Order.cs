using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Supermarket")]
        public int SupermarketId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
