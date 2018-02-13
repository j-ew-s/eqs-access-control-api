using EQS.AccessControl.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Domain.Entities
{
    public class Person : BaseEntity
    {
        public Person()
        {
            PersonRoles = new HashSet<PersonRole>();
        }
        public string Name { get; set; }
        public Credential Credential { get; set; }
        public int CredentialId { get; set; }
        public ICollection<PersonRole> PersonRoles { get; set; }

        public bool IsValid()
        {
           // var validation = new LoginConsistentValidation(this);
          //  Validations = validation.BaseValidation.IsValid();

           // return Validations.IsValid;
            return true;
        }
    }
}
