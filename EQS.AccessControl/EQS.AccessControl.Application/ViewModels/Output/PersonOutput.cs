using System.Collections.Generic;

namespace EQS.AccessControl.Application.ViewModels.Output
{
   public class PersonOutput
    {
        public PersonOutput()
        {
            Roles = new HashSet<RoleOutput>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CredentialOutput Credential { get; set; }
        public int CredentialId { get; set; }
        public ICollection<RoleOutput> Roles { get; set; }
    }
}
