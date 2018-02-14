using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Entities.Base;
using EQS.AccessControl.Domain.Validation.Role;

namespace EQS.AccessControl.Domain.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            PersonRoles = new HashSet<PersonRole>();
        }
        public string Name { get; set; }
        public ICollection<PersonRole> PersonRoles { get; set; }

        public bool IsValidForCreate()
        {
            var validation = new RoleConsistentValidation(this);
            Validations = validation.BaseValidation.IsValid();

            return Validations.IsValid;
        }
    }
}
