using System.Collections.Generic;

namespace EQS.AccessControl.Application.ViewModels.Output
{
   public class PersonOutput
    {
        public PersonOutput()
        {
            PersonRoles = new HashSet<PersonRoleOutput>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CredentialOutput Credential { get; set; }
        public int CredentialId { get; set; }
        public ICollection<PersonRoleOutput> PersonRoles { get; set; }
    }
}
