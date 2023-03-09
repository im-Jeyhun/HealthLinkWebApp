using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Product : BaseEntity<int> , IAuditable
    {
        public string MainImageName { get; set; }
        public string MainImageNameInFileSystem { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string ProducerCountry { get; set; }
        public string Composition { get; set; }
        public string Opposition { get; set; }
        public string Unit { get; set; }
        public string Content { get; set; }
        public int RemindCount { get; set; }
        public decimal Price { get; set; } 
        public decimal DiscountPrice { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int PorductCategoryId { get; set; }
        public PorductCategory? PorductCategory { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public List<ProductSize>? ProductSizes { get; set; }

        public List<BasketProduct>? BasketProducts { get; set; }
        public List<ProductImage>? ProductImages { get; set; }

        public int? DiscountId { get; set; }
        public Discount? Discount { get; set; }

        //public List<OrderProduct>? OrderProducts { get; set; }
    }
}
