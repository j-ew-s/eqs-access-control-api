using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Interfaces.Services;

namespace EQS.AccessControl.Application.Services
{
    public class RegisterAppService : IRegisterAppService
    {
        private readonly IRegisterService _registerService;

        public RegisterAppService(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        public PersonOutput Create(PersonInput entity)
        {
            var person = Mapper.Map<Person>(entity);

            var result = _registerService.Create(person);

            var personInput = Mapper.Map<PersonOutput>(result);

            return personInput;
        }

        public PersonOutput Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonOutput> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonOutput> GetByExpression(Expression<Func<PersonInput, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public PersonOutput GetById(int id)
        {
            throw new NotImplementedException();
        }

        public PersonOutput Update(PersonInput entity)
        {
            throw new NotImplementedException();
        }
    }
}
