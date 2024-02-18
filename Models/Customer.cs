﻿namespace ShoppingAppDev.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
