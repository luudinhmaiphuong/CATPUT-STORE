using CatputStore.Models;
using System.Collections.Generic;

namespace CatputStore.Services
{
    public interface ICartService
    {
        void AddItem(int productId, string name, int price, string imageUrl, int quantity = 1);
        void RemoveItem(int productId);
        void UpdateQuantity(int productId, int quantity);
        void Clear();
        List<CartItem> GetItems();
        CartViewModel GetCartViewModel();
    }
}