namespace TheTourGuyTest.Domain.Models
{
    public class Climate
    {
        public int ClimateId { get; set; }
        public string ClimateName { get; set; }
        public ICollection<Planet> Planets { get; set; }

        public Climate()
        {
            Planets = new HashSet<Planet>();
        }
    }
}
