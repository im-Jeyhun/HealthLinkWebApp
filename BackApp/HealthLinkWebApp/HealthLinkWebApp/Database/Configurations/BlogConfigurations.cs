using HealthLinkWebApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HealthLinkWebApp.Database.Configurations
{
    public class BlogConfigurations : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder
            .ToTable("Blogs")
               .HasOne(b => b.User)
               .WithMany(u => u.Blogs)
               .HasForeignKey(b => b.UserId);

            builder
                .HasOne(b => b.BlogCategory)
               .WithMany(c => c.Blogs)
               .HasForeignKey(b => b.BlogCategoryId);
        }
    }
}
