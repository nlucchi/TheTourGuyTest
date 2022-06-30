using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Data
{
    public class TheTourGuyDbContext : DbContext
    {
        public virtual DbSet<Climate> Climates { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<RelationType> RelationTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        public TheTourGuyDbContext(DbContextOptions<TheTourGuyDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly assemblyWithConfigurations = GetType().Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
        }

        public void Migrate()
        {
            Database.Migrate();
        }
    }
}
