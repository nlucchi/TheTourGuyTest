using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Core.Repositories.Interfaces
{
    public interface IPersonsRepository
    {
        Task AddPersonAsync(Person person);
        Task<List<Person>> GetPersonsByTeamAsync(int? teamId = null);
    }
}