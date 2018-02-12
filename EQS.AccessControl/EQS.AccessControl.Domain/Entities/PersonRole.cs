using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Domain.Entities
{
    public class PersonRole
    {
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public Role Roles { get; set; }
        public int RoleId { get; set; }
    }
}
