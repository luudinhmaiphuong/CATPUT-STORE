using CatputStore.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;                    // Đảm bảo có dòng này
using System.Collections.Generic;
using System.Linq;

namespace CatputStore.Services
{
    public class CartService : ICartService
    {
        private const string CartSessionKey = "Cart";
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession Session => _httpContextAccessor.HttpContext.Session;

        public CartService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor; // Sửa đúng ở đây
        }

        private List<CartItem> GetCartItems()
        {
            var json = Session.GetString(CartSessionKey);
            if (string.IsNullOrEmpty(json))
                return new List<CartItem>();

            return JsonConvert.DeserializeObject<List<CartItem>>(json);
        }

        private void SaveCart(List<CartItem> items)
        {
            Session.SetString(CartSessionKey, JsonConvert.SerializeObject(items));
        }

        public void AddItem(int productId, string name, int price, string imageUrl, int quantity = 1)
        {
            var items = GetCartItems();
            var item = items.FirstOrDefault(x => x.ProductId == productId);

            if (item == null)
            {
                items.Add(new CartItem
                {
                    ProductId = productId,
                    ProductName = name,
                    Price = price,
                    ImageUrl = imageUrl,
                    Quantity = quantity
                });
            }
            else
            {
                item.Quantity += quantity;
            }

            SaveCart(items);
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            var items = GetCartItems();
            var item = items.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                if (quantity <= 0)
                    items.Remove(item);
                else
                    item.Quantity = quantity;
                SaveCart(items);
            }
        }

        public void RemoveItem(int productId)
        {
            var items = GetCartItems();
            items.RemoveAll(x => x.ProductId == productId);
            SaveCart(items);
        }

        public void Clear()
        {
            Session.Remove(CartSessionKey);
        }

        public List<CartItem> GetItems() => GetCartItems();

        public CartViewModel GetCartViewModel()
        {
            return new CartViewModel
            {
                Items = GetItems()
            };
        }
    }
}