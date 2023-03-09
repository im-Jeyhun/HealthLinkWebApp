using HealthLinkWebApp.Database.Models.Common;

namespace HealthLinkWebApp.Database.Models
{
    public class Comment : BaseEntity<int>, IAuditable
    {
        public string Mesagge { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int? CommentId { get; set; }
        public List<Comment>? Comments { get; set; }

    }
}
