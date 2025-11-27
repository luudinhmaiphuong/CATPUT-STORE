namespace CatputStore.Models
{
    public class ShopViewModel
    {
        public List<ProductModel> Products { get; set; } = new();
        public List<string> Categories { get; set; } = new();

        // FILTERS
        public List<string> SelectedCategories { get; set; } = new();
        public int PriceRange { get; set; } = 200000;
        public int? SelectedRating { get; set; }
    }
}
