namespace CatputStore.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }

        // mô tả chi tiết
        public string Description { get; set; }
    }
}