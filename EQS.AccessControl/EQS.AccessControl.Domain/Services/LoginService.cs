using System;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services;

namespace EQS.AccessControl.Domain.Services
{
    public class LoginService : ILoginService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Person Login(Credential credential)
        {
            //if(credential.Validations.IsValid)

        }
    }
}
