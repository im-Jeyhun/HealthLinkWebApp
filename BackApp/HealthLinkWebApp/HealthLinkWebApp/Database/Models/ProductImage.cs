using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class ProductImage : BaseEntity<int> , IAuditable
    {
        public int Order { get; set; }
        public string ImageName { get; set; }
        public string ImageNameInFileSystem { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
