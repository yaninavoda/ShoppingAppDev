namespace ShoppingAppDev.Models
{
    public class PaginationModel
    {
        public IEnumerable<Supermarket> Supermarkets { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }

}
