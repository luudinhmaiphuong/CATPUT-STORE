using System;
using System.Collections.Generic;

namespace CatputStore.Models
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<ProductModels> FeaturedProducts { get; set; } = new List<ProductModels>();
        public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
        public List<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
    }

    public class Category
    {
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = "#f472b6";
    }

    public class ProductModels
    {
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class BlogPost
    {
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }

    public class Testimonial
    {
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
