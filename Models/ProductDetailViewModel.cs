using System.Collections.Generic;

namespace CatputStore.Models
{
    public class ProductDetailViewModel
    {
        public ProductModel Product { get; set; }
        public List<string> Variants { get; set; } = new();
        public int Quantity { get; set; } = 1;
        public List<ProductModel> RelatedProducts { get; set; } = new();
    }
}
