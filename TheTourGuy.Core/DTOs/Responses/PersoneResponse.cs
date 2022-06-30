namespace TheTourGuyTest.Core.DTOs.Responses
{
    public class PersonResponse
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Team { get; set; }
        public string Planet { get; set; }
        public string Climate { get; set; }
        public List<RelationResponse> Relations { get; set; }
    }
}
