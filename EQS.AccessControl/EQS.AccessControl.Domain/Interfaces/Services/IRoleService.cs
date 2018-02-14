using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services.Base;

namespace EQS.AccessControl.Domain.Interfaces.Services
{
    public interface IRoleService : IBaseService<Role>, IDisposable
    {
    }
}
