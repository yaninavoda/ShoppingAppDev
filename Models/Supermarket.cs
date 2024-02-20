using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Supermarket
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} must be less than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} must be less than 100 characters.")]
        public string Address { get; set; }
    }
}
