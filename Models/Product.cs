using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public float Price {  get; set; }
    }
}
