using CatputStore.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. ĐĂNG KÝ CÁC SERVICE TRƯỚC KHI BUILD APP
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddAntiforgery();// cần cho Session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(7);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();                     // bạn dùng trong CartService
builder.Services.AddScoped<ICartService, CartService>();       // đăng ký CartService

var app = builder.Build();

// 2. CẤU HÌNH MIDDLEWARE (thứ tự rất quan trọng!)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// BẬT SESSION Ở ĐÂY, TRƯỚC UseAuthorization
app.UseSession();                     // QUAN TRỌNG!!!

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();