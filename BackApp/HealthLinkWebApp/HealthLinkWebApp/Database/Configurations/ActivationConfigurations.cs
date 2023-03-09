using HealthLinkWebApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HealthLinkWebApp.Database.Configurations
{
    public class ActivationConfigurations : IEntityTypeConfiguration<ActivationToken>
    {
        public void Configure(EntityTypeBuilder<ActivationToken> builder)
        {
            builder
               .ToTable("ActivationTokens");
        }
    }
}
