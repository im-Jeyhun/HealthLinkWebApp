using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class SubNavbar : BaseSubNavbarAndNavbar, IAuditable
    {

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int NavbarId { get; set; }
        public Navbar? Navbar { get; set; }
    }
}
