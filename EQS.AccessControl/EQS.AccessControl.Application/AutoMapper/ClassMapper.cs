using System.Linq;
using AutoMapper;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Register;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.ObjectValue;

namespace EQS.AccessControl.Application.AutoMapper
{
    public class ClassMapper : Profile
    {
        public ClassMapper()
        {
            //Input
            CreateMap<CredentialInput, Credential>().ReverseMap();
            CreateMap<PersonInput, Person>().ReverseMap();
            CreateMap<PersonRoleInput, PersonRole>().ReverseMap();
            CreateMap<RoleInput, Role>().ReverseMap();
            CreateMap<RoleUpdateInput, Role>().ReverseMap();
            CreateMap<SearchObjectInput, SearchObject>().ReverseMap();
            

            //Output
            CreateMap<Credential, CredentialOutput>().ReverseMap();
            CreateMap<Person, PersonOutput>().ReverseMap();
            CreateMap<PersonRole, PersonRoleOutput>().ReverseMap();
            CreateMap<Role, RoleOutput>().ReverseMap();

            CreateMap<Role, RegisterRoleOutput>().ReverseMap();
            CreateMap<Credential, RegisterCredentialOutput>().ReverseMap();
            CreateMap<Person, RegisterPersonOutput>().ForMember(dest => dest.Roles,
                opt => opt.MapFrom(src => src.PersonRoles.Select(s => s.Roles))); ;
            CreateMap<Person, LoginOutput>().ForMember(dest => dest.PersonOutput,
                opt => opt.MapFrom(src => src));


        }
    }
}
