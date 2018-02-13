using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;

namespace EQS.AccessControl.Application.Services
{
    public class RegisterService : IRegisterAppService
    {
        public Person Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetByExpression(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
