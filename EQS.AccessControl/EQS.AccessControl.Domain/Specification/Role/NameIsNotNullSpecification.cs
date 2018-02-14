using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Domain.Specification.Role
{
    public class NameIsNotNullSpecification
    {
        public bool IsSatisfyedBy(Entities.Role entity)
        {
            return !String.IsNullOrEmpty(entity.Name);
        }
    }
}
