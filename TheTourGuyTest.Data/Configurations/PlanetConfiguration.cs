using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Data.Configurations
{
    public class PlanetConfiguration : IEntityTypeConfiguration<Planet>
    {
        public void Configure(EntityTypeBuilder<Planet> builder)
        {
            builder
                .Property(x => x.PlanetName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
