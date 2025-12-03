namespace CatputStore.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }        
        public string ImageUrl { get; set; }
        public int Quantity { get; set; } = 1;
    }
}