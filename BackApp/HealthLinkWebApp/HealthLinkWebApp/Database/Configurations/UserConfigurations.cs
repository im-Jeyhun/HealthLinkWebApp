using HealthLinkWebApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HealthLinkWebApp.Database.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
               .ToTable("Users");

            builder
               .HasOne(u => u.Basket)
               .WithOne(b => b.User)
               .HasForeignKey<Basket>(u => u.UserId);

            builder
               .HasOne(u => u.Role)
               .WithMany(r => r.Users)
               .HasForeignKey(u => u.RoleId);

            builder
               .HasOne(u => u.ActivationTokens)
               .WithOne(ua => ua.User)
               .HasForeignKey<ActivationToken>(ua => ua.UserId);
        }
    }
}
