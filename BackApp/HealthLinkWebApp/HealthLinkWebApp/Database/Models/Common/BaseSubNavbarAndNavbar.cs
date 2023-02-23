namespace HealthLinkWebApp.Database.Models.Common
{
    public class BaseSubNavbarAndNavbar : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public int RowNumber { get; set; }
    }
}
