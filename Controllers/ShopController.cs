using Microsoft.AspNetCore.Mvc;
using CatputStore.Models;

namespace CatputStore.Models
{
    public class ShopController : Controller
    {
        public IActionResult Index(string category)
        {
            var products = new List<ProductModel>
            {
                new ProductModel {
                    Id = 4,
                    Name = "Bồ Hóng Đội Thúng Đáng Yêu",
                    Category = "Len Mềm",
                    Price = 55000,
                    OldPrice = 69000,
                    Rating = 5,
                    ImageUrl = "/images/bohongdoithung.png",
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

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(x => x.Category == category).ToList();
            }

            ViewBag.Categories = new List<string> { "Đất Màu", "Hạt Cườm", "Len Mềm", "Made4U" };

            return View(products);
        }
    }
}
