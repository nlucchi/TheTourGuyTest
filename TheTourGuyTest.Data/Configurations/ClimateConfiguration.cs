using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Data.Configurations
{
    public class ClimateConfiguration : IEntityTypeConfiguration<Climate>
    {
        public void Configure(EntityTypeBuilder<Climate> builder)
        {
            builder
                .Property(x => x.ClimateName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
