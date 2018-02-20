using System;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository.Base;

namespace EQS.AccessControl.Domain.Interfaces.Repository
{
    public interface IRegisterRepository: IBaseRepository<Person>, IDisposable
    {
        Person getCredentialByPersonId(Person person);
    }
}
