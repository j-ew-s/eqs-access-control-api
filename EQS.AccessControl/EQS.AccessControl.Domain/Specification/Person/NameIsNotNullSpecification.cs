using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Domain.Specification.Person
{
    public class NameIsNotNullSpecification
    {
        public bool IsSatisfyedBy(Entities.Person entity)
        {
            return !String.IsNullOrEmpty(entity.Name);
        }
    }
}
