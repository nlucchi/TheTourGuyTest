using TheTourGuyTest.Core.DTOs.Requests;
using TheTourGuyTest.Core.DTOs.Responses;

namespace TheTourGuyTest.Core.Services.Interfaces
{
    public interface IPersonsService
    {
        Task<CreatePersonResponse> CreatePersonAsync(CreatePersonRequest request);
        Task<List<PersonResponse>> GetPersonsAsync(int? teamId = null);
    }
}