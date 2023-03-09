using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class ProductSize : BaseEntity<int> , IAuditable
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
