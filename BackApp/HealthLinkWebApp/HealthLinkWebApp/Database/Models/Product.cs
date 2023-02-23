using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Product : BaseEntity<int> , IAuditable
    {
        public int Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
