using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Discount : BaseEntity<int>, IAuditable
    {
        public string Title { get; set; }
        public decimal Percent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime ExpireDate { get; set; }
        public List<Product>? Products { get; set; }
    }
}
