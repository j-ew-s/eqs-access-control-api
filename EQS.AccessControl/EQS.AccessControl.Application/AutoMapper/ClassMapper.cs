﻿using AutoMapper;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Input.RoleInsert;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Domain.Entities;

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
            CreateMap<RoleInsertInput, Role>().ReverseMap();
            
            //Output
            CreateMap<Credential, CredentialOutput>().ReverseMap();
            CreateMap<Person, PersonOutput>().ReverseMap();
            CreateMap<PersonRoleOutput, PersonRoleOutput>().ReverseMap();
            CreateMap<RoleOutput, RoleOutput>().ReverseMap();

        }
    }
}
