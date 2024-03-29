﻿using System;

namespace DaprShop.ShoppingCart.API.Domain
{
    public class ShoppingCartItem
    {
        public string ProductId { get; set; } = String.Empty;
        public string ProductName { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
