using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Navbar : BaseSubNavbarAndNavbar, IAuditable 
    {

        public bool IsFooter { get; set; }

        public bool IsHeader { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<SubNavbar>? SubNavbars { get; set; }
    }
}
