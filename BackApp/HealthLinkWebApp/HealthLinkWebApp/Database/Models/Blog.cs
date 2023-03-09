using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Blog : BaseEntity<int>, IAuditable
    {
        public string ThumbNailImgName { get; set; }
        public string ThumbNailImgNameInFileSystem { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public int BlogCategoryId { get; set; }
        public BlogCategory? BlogCategory { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<BlogTag>? BlogTags { get; set; }
        public List<BlogImage>? BlogImages { get; set; }
        public List<BlogVideo>? BlogVideos { get; set; }

    }
}
