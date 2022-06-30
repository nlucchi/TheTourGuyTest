namespace TheTourGuyTest.Domain.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int PlanetId { get; set; }
        public Planet Planet { get; set; }
        public ICollection<Relation> RelationsSubjectOf { get; set; }
        public ICollection<Relation> RelationsObjectOf { get; set; }

        public Person()
        {
            RelationsSubjectOf = new HashSet<Relation>();
            RelationsObjectOf = new HashSet<Relation>();
        }
    }
}
