using TheTourGuyTest.Domain.Enums;

namespace TheTourGuyTest.Domain.Models
{
    public class Relation
    {
        public RelationTypeEnum RelationTypeId { get; set; }
        public RelationType RelationType { get; set; }
        public int RelationSubjectId { get; set; }
        /// <summary>
        /// For ex.: In a relation like "Anakin Skywalker PartnerOf Padme Amidala" Anakin Skywalker is the RelationSubject
        /// </summary>
        public Person RelationSubject { get; set; }
        public int RelationObjectId { get; set; }
        /// <summary>
        /// For ex.: In a relation like "Anakin Skywalker PartnerOf Padme Amidala" Padme Amidala is the RelationObject
        /// </summary>
        public Person RelationObject { get; set; }
    }
}
