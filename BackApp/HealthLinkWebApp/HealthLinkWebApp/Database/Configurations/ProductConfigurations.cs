using HealthLinkWebApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HealthLinkWebApp.Database.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
               .ToTable("Products");

            builder
            .HasOne(p => p.Brand)
            .WithMany(b => b.Products)
            .HasForeignKey(p => p.BrandId);

            builder
            .HasOne(p => p.PorductCategory)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.PorductCategoryId);

            builder
            .HasOne(p => p.Discount)
            .WithMany(d => d.Products)
            .HasForeignKey(p => p.DiscountId);
        }
    }
}
