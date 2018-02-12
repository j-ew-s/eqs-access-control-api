using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Application.ViewModels.Output
{
    public class RoleOutput
    {
        public RoleOutput()
        {
            PersonRoles = new HashSet<PersonRoleOutput>();
        }
        public string Name { get; set; }
        public ICollection<PersonRoleOutput> PersonRoles { get; set; }
    }
}
