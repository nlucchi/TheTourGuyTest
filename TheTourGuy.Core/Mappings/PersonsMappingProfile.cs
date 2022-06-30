using AutoMapper;
using TheTourGuyTest.Core.DTOs.Requests;
using TheTourGuyTest.Core.DTOs.Responses;
using TheTourGuyTest.Domain.Models;

namespace TheTourGuyTest.Core.Mappings
{
    public class PersonsMappingProfile : Profile
    {
        public PersonsMappingProfile()
        {
            #region REQUESTS

            CreateMap<CreateRelationRequest, Relation>();

            CreateMap<CreatePersonRequest, Person>()
                .ForMember(dest => dest.RelationsSubjectOf, opt => opt.MapFrom(source => source.Relations));

            #endregion

            #region RESPONSE

            CreateMap<Relation, RelationResponse>()
                .ForMember(dest => dest.RelationTypeName, opt => opt.MapFrom(source => source.RelationType.RelationName))
                .ForMember(dest => dest.ObjectName, opt => opt.MapFrom(source => source.RelationObject.Name))
                .ForMember(dest => dest.ObjectSurname, opt => opt.MapFrom(source => source.RelationObject.Surname));

            CreateMap<Person, PersonResponse>()
                .ForMember(dest => dest.Climate, opt => opt.MapFrom(source => source.Planet.Climate.ClimateName))
                .ForMember(dest => dest.Team, opt => opt.MapFrom(source => source.Team.TeamName))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(source => source.Role.RoleName))
                .ForMember(dest => dest.Planet, opt => opt.MapFrom(source => source.Planet.PlanetName))
                .ForMember(dest => dest.Relations, opt => opt.MapFrom(source => source.RelationsSubjectOf));

            #endregion
        }
    }
}
