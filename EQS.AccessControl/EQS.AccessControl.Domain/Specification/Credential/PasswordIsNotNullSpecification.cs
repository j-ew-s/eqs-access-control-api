using System;

namespace EQS.AccessControl.Domain.Specification.Credential
{
    public class PasswordIsNotNullSpecification
    {
        public bool IsSatisfyedBy(Entities.Credential entity)
        {
            return !String.IsNullOrEmpty(entity.Password);
        }
    }
}
