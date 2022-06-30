namespace TheTourGuyTest.Domain.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public ICollection<Person> Persons { get; set; }

        public Team()
        {
            Persons = new HashSet<Person>();
        }
    }
}
