using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TheTourGuyTest.Core.DTOs.Requests;
using TheTourGuyTest.Core.DTOs.Responses;
using TheTourGuyTest.Core.Services.Interfaces;

namespace TheTourGuyTest.Controllers
{
    [ApiController]
    [Route("persons")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsService personsService;
        private IValidator<CreatePersonRequest> createPersonRequestValidator;

        public PersonsController(IPersonsService personsService, IValidator<CreatePersonRequest> createPersonRequestValidator)
        {
            this.personsService = personsService;
            this.createPersonRequestValidator = createPersonRequestValidator;
        }

        [HttpGet]
        public Task<List<PersonResponse>> Get([FromQuery] int? teamId = null)
        {
            return personsService.GetPersonsAsync(teamId);
        }

        [HttpPost]
        public async Task<CreatePersonResponse> Post([FromBody]CreatePersonRequest request)
        {
            var validationResult = await createPersonRequestValidator.ValidateAsync(request);

            if (!validationResult.IsValid)
                Results.ValidationProblem(validationResult.ToDictionary());

            return await personsService.CreatePersonAsync(request);
        }
    }
}