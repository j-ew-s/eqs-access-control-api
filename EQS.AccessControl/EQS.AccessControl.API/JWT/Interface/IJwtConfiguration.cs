using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EQS.AccessControl.API.JWT.Interface
{
    public interface IJwtConfiguration
    {
        string Audience { get; }
        string Issuer { get; }
        int Seconds { get; }
    }
}
