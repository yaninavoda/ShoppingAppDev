namespace ShoppingAppDev.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public float Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
        public Order Order { get; set; }
    }
}
