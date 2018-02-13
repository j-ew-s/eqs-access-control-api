using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services;
using EQS.AccessControl.Domain.Interfaces.Services.Base;

namespace EQS.AccessControl.Domain.Services
{
    public class RegisterService : IRegisterService
    {

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Person Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Delete(int id)
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

        IEnumerable<Person> IBaseService<Person>.GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetByExpression(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
