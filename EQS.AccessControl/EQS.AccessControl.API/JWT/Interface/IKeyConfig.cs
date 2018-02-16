using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace EQS.AccessControl.API.JWT.Interface
{
    public interface IKeyConfig
    {
        SecurityKey Key { get; }
        SigningCredentials SigningCredentials { get; }
    }
}
