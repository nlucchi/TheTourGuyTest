using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Data.Configurations
{
    public class RelationConfiguration : IEntityTypeConfiguration<Relation>
    {
        public void Configure(EntityTypeBuilder<Relation> builder)
        {
            builder.HasKey(e => new { e.RelationTypeId, e.RelationSubjectId, e.RelationObjectId });

            builder
                .HasOne(x => x.RelationSubject)
                .WithMany(x => x.RelationsSubjectOf)
                .HasForeignKey(x => x.RelationSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne(x => x.RelationObject)
                .WithMany(x => x.RelationsObjectOf)
                .HasForeignKey(x => x.RelationObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
