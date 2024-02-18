using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
        public int Discount { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
