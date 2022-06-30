using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .Property(x => x.RoleName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
