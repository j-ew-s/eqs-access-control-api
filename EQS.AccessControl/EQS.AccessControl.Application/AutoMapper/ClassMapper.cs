using AutoMapper;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Domain.Entities;

namespace EQS.AccessControl.Application.AutoMapper
{
    public class ClassMapper : Profile
    {
        public ClassMapper()
        {
            CreateMap<Credential, CredentialOutput>().ReverseMap();
            CreateMap<Person, PersonOutput>().ReverseMap();
        }
    }
}
