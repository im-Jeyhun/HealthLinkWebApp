using HealthLinkWebApp.Database.Models;
using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class User : BaseEntity<Guid> , IAuditable
    {
        public string? Ip { get; set; } = null;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; } = null;
        public string? Password { get; set; }
        public string? ProfilPhotoName { get; set; }
        public string? ProfilPhotoNameInFileSystem { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public ActivationToken? ActivationTokens { get; set; }

        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public Basket? Basket { get; set; }

        public List<Blog>? Blogs { get; set; }



    }
}
