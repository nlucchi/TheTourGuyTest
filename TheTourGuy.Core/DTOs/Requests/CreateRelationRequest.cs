using TheTourGuyTest.Domain.Enums;

namespace TheTourGuyTest.Core.DTOs.Requests
{
    public class CreateRelationRequest
    {
        public RelationTypeEnum RelationTypeId { get; set; }
        public int RelationObjectId { get; set; }
    }
}
