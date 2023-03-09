using HealthLinkWebApp.Database.Models;
using HealthLinkWebApp.Database.Models.Common;
using HealthLinkWebApp.Database.Models.Enums;

namespace HealthLinkWebApp.Database.Models
{
    public class ActivationToken : BaseEntity<int>
    {
        public string? ActivationUrl { get; set; }
        public string? Token { get; set; }
        public DateTime TokenExpireDate { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public ActivationTokenTypes Type { get; set; }
    }

}
