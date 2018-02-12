using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Application.ViewModels.Output
{
   public class PersonRoleOutput
    {
        public PersonOutput Person { get; set; }
        public int PersonId { get; set; }
        public RoleOutput Roles { get; set; }
        public int RoleId { get; set; }
    }
}
