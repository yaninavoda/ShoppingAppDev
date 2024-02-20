using System.ComponentModel.DataAnnotations;

namespace ShoppingAppDev.Models
{
    public class Customer
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "{0} must be less than 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} must be less than 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0} must be less than 50 characters.")]
        public string Address { get; set; }
        public int Discount { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        //public ICollection<Order?> Orders { get; set; }
    }
}
