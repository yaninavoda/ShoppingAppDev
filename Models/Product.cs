using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} must be less than 50 characters.")]
        public string Name { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "{0} must not be less than 0.")]
        public float Price {  get; set; }
    }
}
