using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CatputStore.Models;

namespace CatputStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Categories
            var categories = new List<Category>
            {
                new Category { Name="Len mềm", Color="#f472b6" },
                new Category { Name="Đất màu", Color="#fbbf24" },
                new Category { Name="Hạt cườm", Color="#60a5fa" },
                new Category { Name="Make4U", Color="#34d399" }
            };

            // Featured Products
            var featuredProducts = new List<ProductModels>
            {
                new ProductModels { Name="Bồ hóng", Image="~/images/bohong.png", Price=150000 },
                new ProductModels { Name="Móc khóa Linh Lan", Image="~/images/linhlan.png", Price=180000 },
                new ProductModels { Name="Pin Cài Ghibli", Image="~/images/pinghibli.png", Price=200000 },
                new ProductModels { Name="Dây Đeo", Image="~/images/daydeo.png", Price=50000 },
            };

            // Blog posts
            var blogPosts = new List<BlogPost>
            {
                new BlogPost { Title="🌸 Flower Core – Khi những sợi len hóa thành cánh hoa nhỏ xinh 🌿\r\n", Image="~/images/pflowercore.webp" },
                new BlogPost { Title="🌿 Đất Màu – Khi phụ kiện không chỉ là trang sức, mà là câu chuyện của riêng bạn", Image="~/images/pdatmau.webp" },
                new BlogPost { Title="🚂✨ Choo choo~ Chuyến tàu nhà Ghibli đã sẵn sàng khởi hành!", Image="~/images/pbohong.webp" },
            };

            // Testimonials
            var testimonials = new List<Testimonial>
            {
                new Testimonial { Name="Mai Anh", Content="Mình đặt một chiếc móc khóa đất sét ở Catput để tặng bạn thân, nhận hàng mà mê luôn! Món quà nhỏ nhưng được gói rất cẩn thận, chi tiết làm thủ công tinh tế, nhìn là thấy tâm huyết. Cảm giác đúng kiểu “small but sweet” luôn đó " },
                new Testimonial { Name="Khánh Linh", Content="Shop làm đồ dễ thương cực, đặc biệt là mấy món vòng tay len và phụ kiện hạt cườm. Mình mua để tặng sinh nhật bạn, ai cũng khen xinh. Giao hàng nhanh, có thiệp viết tay nhỏ xíu đáng yêu nữa, cảm thấy rất ấm lòng 🥰" },
                new Testimonial { Name="Thanh Vy", Content="Bó hoa len mini quá dễ thương, cầm trên tay mới thấy tỉ mỉ và tinh tế. Hàng thủ công nhưng hoàn thiện rất đẹp. Giao hàng nhanh, shop tư vấn nhiệt tình. Nhất định sẽ ủng hộ thêm nè 🥰" },
            };

            var model = new HomeViewModel
            {
                Categories = categories,
                FeaturedProducts = featuredProducts,
                BlogPosts = blogPosts,
                Testimonials = testimonials
            };

            return View(model);
        }
        //Action About
        public IActionResult About()
        {
            return View();
        }
    }
}
