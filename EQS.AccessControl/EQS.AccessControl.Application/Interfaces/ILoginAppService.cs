using System;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface ILoginAppService : IDisposable
    {
        ResponseModelBase<LoginOutput> Login(CredentialInput credential);
    }
}
