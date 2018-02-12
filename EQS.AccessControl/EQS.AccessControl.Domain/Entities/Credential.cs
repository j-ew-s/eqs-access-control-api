using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Entities.Base;

namespace EQS.AccessControl.Domain.Entities
{
    public class Credential : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
