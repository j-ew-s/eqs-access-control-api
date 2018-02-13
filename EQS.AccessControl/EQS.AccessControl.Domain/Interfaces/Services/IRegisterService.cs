using System;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services.Base;

namespace EQS.AccessControl.Domain.Interfaces.Services
{
    public interface IRegisterService : IBaseService<Person>, IDisposable
    {

    }
}
