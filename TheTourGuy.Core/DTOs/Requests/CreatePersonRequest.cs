namespace TheTourGuyTest.Core.DTOs.Requests
{
    public class CreatePersonRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int TeamId { get; set; }
        public int PlanetId { get; set; }
        public int RoleId { get; set; }
        public List<CreateRelationRequest> Relations { get; set; }
    }
}
