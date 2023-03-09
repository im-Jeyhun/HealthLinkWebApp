using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class About : BaseEntity<int>, IAuditable
    {
        public string MainTitle { get; set; }
        public string SecondTitle { get; set; }
        public string Content { get; set; }

        public string LeftImageName { get; set; }
        public string LeftImageNameInFileSystem { get; set; }

        public string RightImageName { get; set; }
        public string RightImageNameInFileSystem { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
