using FluentValidation;
using TheTourGuyTest.Core.DTOs.Requests;

namespace TheTourGuyTest.Core.Validators
{
    public class CreateRelationRequestValidator : AbstractValidator<CreateRelationRequest>
    {
        public CreateRelationRequestValidator()
        {
            RuleFor(x => x.RelationObjectId).GreaterThan(0);
        }
    }
}
