using FluentValidation;
using TheTourGuyTest.Core.DTOs.Requests;

namespace TheTourGuyTest.Core.Validators
{
    public class CreatePersonRequestValidator : AbstractValidator<CreatePersonRequest>
    {
        public CreatePersonRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().MaximumLength(200);
            RuleFor(x => x.Surname).NotNull().MaximumLength(200);
            RuleFor(x => x.TeamId).GreaterThan(0);
            RuleFor(x => x.PlanetId).GreaterThan(0);
            RuleFor(x => x.RoleId).GreaterThan(0);
            RuleForEach(x => x.Relations).SetValidator(new CreateRelationRequestValidator());
        }
    }
}
