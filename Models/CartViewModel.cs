using System.Collections.Generic;

namespace CatputStore.Models
{
    public class CartViewModel
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public int Subtotal => Items.Sum(i => i.Price * i.Quantity);
        public int ShippingFee => Subtotal >= 441000 ? 0 : 32400;
        public int Total => Subtotal + ShippingFee;
        public bool IsFreeShipping => Subtotal >= 441000;
    }
}