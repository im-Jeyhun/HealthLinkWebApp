using HealthLinkWebApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HealthLinkWebApp.Database.Configurations
{
    public class BlogVideoConfigurations : IEntityTypeConfiguration<BlogVideo>
    {
        public void Configure(EntityTypeBuilder<BlogVideo> builder)
        {
            builder
            .ToTable("BlogVideos")
             .HasOne(bv => bv.Blog)
               .WithMany(b => b.BlogVideos)
               .HasForeignKey(bv => bv.BlogId);
        }
    }
}
