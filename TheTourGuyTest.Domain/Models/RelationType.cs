using TheTourGuyTest.Domain.Enums;

namespace TheTourGuyTest.Domain.Models
{
    public class RelationType
    {
        public RelationTypeEnum RelationTypeId { get; set; }
        public string RelationName { get; set; }
        public ICollection<Relation> Relations { get; set; }

        public RelationType()
        {
            Relations = new HashSet<Relation>();
        }
    }
}
