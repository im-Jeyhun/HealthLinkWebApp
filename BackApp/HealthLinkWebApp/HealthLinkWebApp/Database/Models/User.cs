using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class User : BaseEntity<Guid> , IAuditable
    {
        public string Ip { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
