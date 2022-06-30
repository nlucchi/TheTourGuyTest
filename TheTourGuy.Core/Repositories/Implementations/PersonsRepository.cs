using Microsoft.EntityFrameworkCore;
using TheTourGuyTest.Core.Repositories.Interfaces;
using TheTourGuyTest.Data;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Core.Repositories.Implementations
{
    public class PersonsRepository : IPersonsRepository
    {
        private readonly TheTourGuyDbContext dbContext;

        public PersonsRepository(TheTourGuyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<Person>> GetPersonsByTeamAsync(int? teamId = null)
        {
            var queryable = dbContext
                .Persons
                .Include(x => x.Team)
                .Include(x => x.Role)
                .Include(x => x.Planet).ThenInclude(x => x.Climate)
                .Include(x => x.RelationsSubjectOf).ThenInclude(x => x.RelationType)
                .Include(x => x.RelationsSubjectOf).ThenInclude(x => x.RelationObject)
                .AsNoTracking()
                .AsQueryable();

            if (teamId.HasValue)
                queryable = queryable.Where(x => x.TeamId == teamId);

            return queryable
                .ToListAsync();
        }

        public async Task AddPersonAsync(Person person)
        {
            await dbContext
                .Persons
                .AddAsync(person);

            await dbContext.SaveChangesAsync();
        }
    }
}
