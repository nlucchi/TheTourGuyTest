using TheTourGuyTest.Domain.Enums;

namespace TheTourGuyTest.Core.DTOs.Responses
{
    public class RelationResponse
    {
        public RelationTypeEnum RelationTypeId { get; set; }
        public string RelationTypeName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectSurname { get; set; }
    }
}
