using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Repository.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.Accesscontrol.Crosscutting
{
    public class RoleSeed : BaseRepository<Role>
    {
        public RoleSeed(string connectionString):base(connectionString)
        {


        }
    }
}
