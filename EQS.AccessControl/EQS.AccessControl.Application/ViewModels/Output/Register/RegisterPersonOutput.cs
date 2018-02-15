using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Application.ViewModels.Output.Register
{
    public class RegisterPersonOutput
    {
        public RegisterPersonOutput()
        {
            Roles = new HashSet<RegisterRoleOutput>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public RegisterCredentialOutput Credential { get; set; }
        public ICollection<RegisterRoleOutput> Roles { get; set; }
    }
}
