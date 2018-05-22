using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;

namespace EQS.AccessControl.API.JWT.Interface
{
    public interface ITokenGenerator
    {
        ResponseModelBase<LoginOutput> CreateToken(LoginOutput usuario);
    }
}
