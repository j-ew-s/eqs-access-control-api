using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Entities;

namespace EQS.AccessControl.Domain.Interfaces.Services
{
    public interface ILoginService: IDisposable
    {
        Person Login(Credential credential);
    }
}
