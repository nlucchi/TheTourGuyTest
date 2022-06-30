using AutoMapper;
using TheTourGuyTest.Core.DTOs.Requests;
using TheTourGuyTest.Core.DTOs.Responses;
using TheTourGuyTest.Core.Repositories.Interfaces;
using TheTourGuyTest.Core.Services.Interfaces;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Core.Services.Implementations
{
    public class PersonsService : IPersonsService
    {
        private readonly IPersonsRepository personsRepository;
        private readonly IMapper mapper;

        public PersonsService(IPersonsRepository personsRepository, IMapper mapper)
        {
            this.personsRepository = personsRepository;
            this.mapper = mapper;
        }

        public async Task<List<PersonResponse>> GetPersonsAsync(int? teamId = null)
        {
            var persons = await personsRepository.GetPersonsByTeamAsync(teamId);
            return mapper.Map<List<PersonResponse>>(persons);
        }

        public async Task<CreatePersonResponse> CreatePersonAsync(CreatePersonRequest request)
        {
            var person = mapper.Map<Person>(request);
            await personsRepository.AddPersonAsync(person);
            return new CreatePersonResponse(person.PersonId);
        }
    }
}
