using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Size : BaseEntity<int>, IAuditable
    {
        public string Title { get; set; }
        public List<ProductSize>? ProductSizes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
