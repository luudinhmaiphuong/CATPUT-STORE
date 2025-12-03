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
                return RedirectToAction("Login");
            }
            return View(model);
        }
    }
}