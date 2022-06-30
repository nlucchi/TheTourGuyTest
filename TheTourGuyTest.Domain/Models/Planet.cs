namespace TheTourGuyTest.Domain.Models
{
    public class Planet
    {
        public int PlanetId { get; set; }
        public string PlanetName { get; set; }
        public int ClimateId { get; set; }
        public Climate Climate { get; set; }
        public ICollection<Person> Persons { get; set; }

        public Planet()
        {
            Persons = new HashSet<Person>();
        }
    }
}
