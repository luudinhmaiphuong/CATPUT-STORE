using Microsoft.AspNetCore.Mvc;
using CatputStore.Models;
using CatputStore.Services;
using Microsoft.AspNetCore.Antiforgery; // Thêm dòng này

namespace CatputStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IAntiforgery _antiforgery; // Để tạo token nếu cần

        public CartController(ICartService cartService, IAntiforgery antiforgery)
        {
            _cartService = cartService;
            _antiforgery = antiforgery;
        }

        // 1. Lấy số lượng giỏ hàng cho badge header
        [HttpGet]
        public IActionResult GetCartCount()
        {
            var count = _cartService.GetItems().Sum(x => x.Quantity);
            return Json(new { count });
        }

        // 2. Trang giỏ hàng
        public IActionResult Index()
        {
            var model = _cartService.GetCartViewModel();
            return View(model);
        }

        // 3. THÊM VÀO GIỎ HÀNG – CHẠY 100% TỪ TRANG CHI TIẾT
        [HttpPost]
        [ValidateAntiForgeryToken] // BẮT BUỘC PHẢI CÓ DÒNG NÀY!!!
        public IActionResult Add(int productId, string productName, int price, string imageUrl, int quantity = 1)
        {
            // Kiểm tra dữ liệu đầu vào cơ bản (tránh lỗi)
            if (productId <= 0 || string.IsNullOrEmpty(productName) || price < 0 || string.IsNullOrEmpty(imageUrl))
            {
                return Json(new { success = false, message = "Dữ liệu không hợp lệ!" });
            }

            // Thêm vào giỏ
            _cartService.AddItem(productId, productName, price, imageUrl, quantity);

            // Trả về kết quả thành công
            return Json(new
            {
                success = true,
                message = $"Đã thêm \"{productName}\" × {quantity} vào giỏ hàng!",
                count = _cartService.GetItems().Sum(x => x.Quantity) // trả thêm số lượng mới cho badge
            });
        }

        // 4. Cập nhật số lượng trong giỏ
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int productId, int quantity)
        {
            _cartService.UpdateQuantity(productId, quantity);
            var cart = _cartService.GetCartViewModel();

            return Json(new
            {
                subtotal = cart.Subtotal,
                shipping = cart.ShippingFee,
                total = cart.Total,
                isFreeShipping = cart.IsFreeShipping,
                count = cart.Items.Sum(x => x.Quantity)
            });
        }

        // 5. Xóa sản phẩm khỏi giỏ
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int productId)
        {
            _cartService.RemoveItem(productId);
            var cart = _cartService.GetCartViewModel();

            return Json(new
            {
                success = true,
                subtotal = cart.Subtotal,
                total = cart.Total,
                itemCount = cart.Items.Count,
                count = cart.Items.Sum(x => x.Quantity)
            });
        }
    }
}