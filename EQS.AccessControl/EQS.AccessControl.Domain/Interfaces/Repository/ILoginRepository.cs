using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Entities;

namespace EQS.AccessControl.Domain.Interfaces.Repository
{
    public interface ILoginRepository: IDisposable
    {
        Person Login(Credential credential);
    }
}
