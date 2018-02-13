using System;

namespace EQS.AccessControl.Domain.Specification.Credential
{
    public class UsernameIsNotNullSpecification
    {
        public bool IsSatisfyedBy(Entities.Credential entity)
        {
            return !String.IsNullOrEmpty(entity.Username);
        }
    }
}
