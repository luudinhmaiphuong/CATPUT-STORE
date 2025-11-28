using Microsoft.AspNetCore.Mvc;
using CatputStore.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CatputStore.Controllers
{
    public class ShopController : Controller
    {
        // Danh sách sản phẩm mock data
        private readonly List<ProductModel> products = new List<ProductModel>
        {
            new ProductModel {
                Id = 4,
                Name = "Bồ Hóng Đội Thúng Đáng Yêu",
                Category = "Len Mềm",
                Price = 55000,
                OldPrice = 69000,
                Rating = 5,
                ImageUrl = "/images/bohongdoithung.png",
                ShortDescription = "Bồ hóng đội thúng len handmade – dễ thương, tinh nghịch, phụ kiện độc đáo.",
                Description = "Thêm vào bộ sưu tập Ghibli của bạn bồ hóng đội thúng len handmade." +
                              "\r\n\r\nThiết kế độc đáo: Bồ hóng được móc len thủ công tạo hình tròn xinh xắn, đội chiếc thúng len nhỏ trên đầu, vừa ngộ nghĩnh vừa đáng yêu." +
                              "\r\n\r\nChất liệu mềm mại: Len cotton cao cấp, an toàn và bền đẹp, có thể trưng bày lâu dài." +
                              "\r\n\r\nỨng dụng linh hoạt: Dùng làm trang trí bàn học, góc làm việc hoặc treo balo, túi xách." +
                              "\r\n\r\nQuà tặng đáng yêu: Lý tưởng dành cho fan Ghibli hoặc những ai yêu thích đồ decor handmade bằng len." +
                              "\r\n\r\nMột sản phẩm nhỏ xinh nhưng đủ để mang lại sự vui tươi và độc đáo cho không gian của bạn.",
            },
            new ProductModel {
                Id = 5,
                Name = "Dây Đeo Điện Thoại Hình Nhân Vật Thiết Kế Theo Yêu Cầu",
                Category = "Made4U",
                Price = 52000,
                OldPrice = 65000,
                Rating = 5,
                ImageUrl = "/images/daydeo.png",
            },
            new ProductModel {
                Id = 6,
                Name = "Bồ Hóng Cài Hoa Xinh Xắn",
                Category = "Len Mềm",
                Price = 42000,
                OldPrice = 49000,
                Rating = 5,
                ImageUrl = "/images/bohongcaihoa.png",
            },
            new ProductModel {
                Id = 1,
                Name = "Vòng Tay Misty Forest",
                Category = "Hạt Cườm",
                Price = 34000,
                OldPrice = 39000,
                Rating = 5,
                ImageUrl = "/images/mistyforest.png",
            },
            new ProductModel {
                Id = 2,
                Name = "Vòng Tay Sakura Bloom",
                Category = "Hạt Cườm",
                Price = 34000,
                OldPrice = 39000,
                Rating = 5,
                ImageUrl = "/images/sakurabloom.png",
            },
            new ProductModel {
                Id = 3,
                Name = "Vòng Tay Deep Blue",
                Category = "Hạt Cườm",
                Price = 33000,
                OldPrice = 38000,
                Rating = 5,
                ImageUrl = "/images/deepblue.png",
            },
            new ProductModel {
                Id = 7,
                Name = "BST Pin Cài Hoạt Hình Ghibli",
                Category = "Đất Màu",
                Price = 89000,
                OldPrice = 95000,
                Rating = 5,
                ImageUrl = "/images/pinghibli.png"
            },
            new ProductModel {
                Id = 8,
                Name = "Vòng Tay Blue Xinh Xắn",
                Category = "Hạt Cườm",
                Price = 32000,
                OldPrice = 38000,
                Rating = 5,
                ImageUrl = "/images/vongtay.png"
            },
            new ProductModel {
                Id = 9,
                Name = "Móc Khóa Hoa Linh Lan",
                Category = "Len Mềm",
                Price = 23000,
                OldPrice = 27000,
                Rating = 5,
                ImageUrl = "/images/linhlan.png"
            },
            new ProductModel {
                Id = 10,
                Name = "Vòng Cổ Blue Lấp Lánh",
                Category = "Hạt Cườm",
                Price = 69000,
                OldPrice = 79000,
                Rating = 5,
                ImageUrl = "/images/vongco.png"
            },
            new ProductModel {
                Id = 11,
                Name = "BST Pin Cài Trái Cây",
                Category = "Đất Màu",
                Price = 95000,
                OldPrice = 99000,
                Rating = 5,
                ImageUrl = "/images/traicay.png",
            },
            new ProductModel {
                Id = 12,
                Name = "Túi Rút Bồ Hóng",
                Category = "Len Mềm",
                Price = 65000,
                OldPrice = 79000,
                Rating = 5,
                ImageUrl = "/images/tuirutbohong.png",
            },
            new ProductModel {
                Id = 13,
                Name = "Bộ đôi Nick & Judy in Zootopia",
                Category = "Len Mềm",
                Price = 199000,
                OldPrice = 219000,
                Rating = 5,
                ImageUrl = "/images/nickjudy.jpg",
            },
            new ProductModel {
                Id = 14,
                Name = "Bồ Hóng Ngồi Xích Đu",
                Category = "Len Mềm",
                Price = 49000,
                OldPrice = 55000,
                Rating = 5,
                ImageUrl = "/images/bohong.png",
                Description = "Bồ hóng ngồi xích đu len handmade – tinh nghịch, độc đáo, phụ kiện dễ thương.",
            },
            new ProductModel {
                Id = 15,
                Name = "BST Pin Cài Chó Mèo Cute",
                Category = "Đất Màu",
                Price = 84000,
                OldPrice = 95000,
                Rating = 5,
                ImageUrl = "/images/pinchomeo.png",
            },
            new ProductModel {
                Id = 16,
                Name = "Pin Cài Hình Nhân Vật Thiết Kế theo yêu cầu",
                Category = "Made4U",
                Price = 68000,
                OldPrice = 79000,
                Rating = 5,
                ImageUrl = "/images/pin.png",
            },
            new ProductModel {
                Id = 17,
                Name = "Smiski - Hipper Gắn Điện Thoại",
                Category = "Đất Màu",
                Price = 48000,
                OldPrice = 55000,
                Rating = 5,
                ImageUrl = "/images/hipper.png",
            },
            new ProductModel {
                Id = 18,
                Name = "Móc Khóa Hoa Tulip",
                Category = "Len Mềm",
                OldPrice = 29000,
                Price = 25000,
                Rating = 5,
                ImageUrl = "/images/tulip.png"
            }
        };

        // Một action Index duy nhất nhận các filter từ querystring/form
        public IActionResult Index(List<string>? categories, int priceRange = 200000, int? rating = null)
        {
            // 1. Lọc sản phẩm
            var filtered = products.Where(p =>
                (categories == null || categories.Count == 0 || categories.Any(c => c.Equals(p.Category, StringComparison.OrdinalIgnoreCase))) &&

                p.Price <= priceRange &&
                (rating == null || p.Rating >= rating)
            ).ToList();

            // 2. Lấy danh sách tất cả danh mục để hiện ra Sidebar
            var allCategories = products.Select(p => p.Category).Distinct().ToList();

            // 3. Xử lý để Checkbox bên trang Shop tự động tích đúng
            var selectedCatsNormalized = new List<string>();
            if (categories != null)
            {
                foreach (var cat in categories)
                {
                    // Tìm tên chuẩn trong database khớp với tên user gửi lên
                    var match = allCategories.FirstOrDefault(c => c.Equals(cat, StringComparison.OrdinalIgnoreCase));
                    if (match != null)
                    {
                        selectedCatsNormalized.Add(match);
                    }
                }
            }

            // 4. Đẩy dữ liệu ra View
            var vm = new ShopViewModel
            {
                Products = filtered,
                Categories = allCategories,
                SelectedCategories = selectedCatsNormalized, // Dùng list đã chuẩn hóa
                PriceRange = priceRange,
                SelectedRating = rating
            };

            return View(vm);
        }

        // Trang chi tiết sản phẩm
        public IActionResult Detail(int id)
        {
            // 1. Tìm sản phẩm chính
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Trả lỗi nếu không có sản phẩm này
            }

            // 2. Tìm các sản phẩm liên quan (Related Products)
            // Lọc sản phẩm cùng Category và không phải sản phẩm hiện tại, lấy tối đa 4
            var relatedProducts = products
                                    .Where(p => p.Category == product.Category && p.Id != id)
                                    .Take(4)
                                    .ToList();

            // 3. Đóng gói dữ liệu vào ViewModel
            var viewModel = new ProductDetailViewModel
            {
                Product = product,
                RelatedProducts = relatedProducts
                // Bạn có thể thêm các thuộc tính khác như Variants, Quantity nếu cần
            };

            // 4. Gửi ViewModel chứa cả sản phẩm chính và sản phẩm liên quan qua View
            return View(viewModel);
        }
    }
}