using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository.Base;

namespace EQS.AccessControl.Domain.Interfaces.Repository
{
    public interface IRoleRepository : IBaseRepository<Role>, IDisposable
    {
    }
}
