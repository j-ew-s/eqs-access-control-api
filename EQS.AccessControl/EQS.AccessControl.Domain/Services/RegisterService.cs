using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Interfaces.Services;
using EQS.AccessControl.Domain.Interfaces.Services.Base;

namespace EQS.AccessControl.Domain.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository _registerRepository;

        public RegisterService(IRegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Person Create(Person entity)
        {
            entity.Credential.EncryptedPassword();
            if (entity.IsValidForRegister())
                return _registerRepository.Create(entity);
            return null;

        }

        public Person Delete(int id)
        {
            return _registerRepository.Delete(id);
        }

        public Person GetById(int id)
        {
            return _registerRepository.GetById(id);
        }

        public Person Update(Person entity)
        {
            return _registerRepository.Update(entity);
        }

        IEnumerable<Person> IBaseService<Person>.GetAll()
        {
            return _registerRepository.GetAll();
        }

        public IEnumerable<Person> GetByExpression(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
