using Microsoft.AspNetCore.Mvc;
using CatputStore.Models;

namespace CatputStore.Controllers
{
    public class AccountController : Controller
    {
        // 1. Hiện trang Đăng nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Xử lý khi bấm nút Đăng nhập
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Code xử lý kiểm tra database ở đây
                // Tạm thời giả lập thành công -> Về trang chủ
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // 2. Hiện trang Đăng ký
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Xử lý khi bấm nút Đăng ký
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Code lưu user vào database ở đây
                return RedirectToAction("Login");
            }
            return View(model);
        }
    }
}