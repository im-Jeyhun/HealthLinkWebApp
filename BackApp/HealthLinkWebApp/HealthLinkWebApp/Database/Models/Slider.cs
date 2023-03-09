using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Slider : BaseEntity<int>
    {
        public string? Offer { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? BgImageName { get; set; }
        public string? BgImageNameInFileSystem { get; set; }
        public string? ButtonName { get; set; }
        public string? BtnRedirectUrl { get; set; }
        public int Order { get; set; }
    }
}
