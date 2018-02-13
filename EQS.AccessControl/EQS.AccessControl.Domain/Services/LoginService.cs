using System;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Interfaces.Services;

namespace EQS.AccessControl.Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _iLoginRepository;

        public LoginService(ILoginRepository iLoginRepository)
        {
            _iLoginRepository = iLoginRepository;
        }

        public void Dispose()
        {
            _iLoginRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Person Login(Credential credential)
        {
            //if(credential.Validations.IsValid)

        }
    }
}
