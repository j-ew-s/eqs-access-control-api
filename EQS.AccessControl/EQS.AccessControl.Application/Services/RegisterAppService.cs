using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.Application.ViewModels.Output.Register;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services;

namespace EQS.AccessControl.Application.Services
{
    public class RegisterAppService : IRegisterAppService
    {
        private readonly IRegisterService _registerService;
        private readonly IRoleService _roleService;

        public RegisterAppService(IRegisterService registerService, IRoleService roleService)
        {
            _registerService = registerService;
            _roleService = roleService;
        }

        public ResponseModelBase<RegisterPersonOutput> Create(PersonInput entity)
        {
            var person = Mapper.Map<Person>(entity);

            foreach (var roleId in entity.RoleIds)
            {
                var role = _roleService.GetById(roleId);
                var personRole = new PersonRole { Person = person, PersonId = person.Id, Roles = role, RoleId = roleId };
                person.PersonRoles.Add(personRole);
            }

            var response = _registerService.Create(person);
            var personOutput = Mapper.Map<RegisterPersonOutput>(response);

            return new ResponseModelBase<RegisterPersonOutput>().OkResult(personOutput, response.Validations.ErrorMessages);
        }

        public ResponseModelBase<RegisterPersonOutput> Update(PersonInput entity)
        {
            throw new NotImplementedException();
        }

        public ResponseModelBase<RegisterPersonOutput> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseModelBase<List<RegisterPersonOutput>> GetAll()
        {
            var person = _registerService.GetAll();

            var personOutput = Mapper.Map<List<RegisterPersonOutput>>(person);

            return new ResponseModelBase<List<RegisterPersonOutput>>().OkResult(personOutput, new List<string>());
        }

        public ResponseModelBase<List<RegisterPersonOutput>> GetByExpression(Expression<Func<PersonInput, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ResponseModelBase<RegisterPersonOutput> GetById(int id)
        {
            var person = _registerService.GetById(id);
            var personOutput = Mapper.Map<RegisterPersonOutput>(person);

            return new ResponseModelBase<RegisterPersonOutput>().OkResult(personOutput, new List<string>());
        }


    }
}
