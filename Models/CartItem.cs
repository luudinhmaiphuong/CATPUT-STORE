namespace CatputStore.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }         // giá hiện tại (sau giảm giá nếu có)
        public string ImageUrl { get; set; }
        public int Quantity { get; set; } = 1;
    }
}