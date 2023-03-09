using HealthLinkWebApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HealthLinkWebApp.Database.Configurations
{
    public class ProductSizeConfigurations : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder
               .ToTable("PlantSizes")
               .HasOne(pc => pc.Product)
               .WithMany(p => p.ProductSizes)
               .HasForeignKey(pc => pc.ProductId);

            builder
               .HasOne(pc => pc.Size)
               .WithMany(c => c.ProductSizes)
               .HasForeignKey(pc => pc.SizeId);
        }
    }
}
