using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Application.ViewModels.Input
{
    public class PersonRoleInput
    {
        public PersonInput Person { get; set; }
        public int PersonId { get; set; }
        public RoleInput Roles { get; set; }
        public int RoleId { get; set; }
    }
}
