using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Data.Configurations
{
    public class RelationTypeConfiguration : IEntityTypeConfiguration<RelationType>
    {
        public void Configure(EntityTypeBuilder<RelationType> builder)
        {
            builder
                .Property(x => x.RelationTypeId)
                .ValueGeneratedNever();

            builder
                .Property(x => x.RelationName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
