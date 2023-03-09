﻿using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class BasketProduct : BaseEntity<int>, IAuditable
    {
        public int BasketId { get; set; }
        public Basket? Basket { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int? SizeId { get; set; }
        public Size? Size { get; set; }

        public int? Quantity { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
