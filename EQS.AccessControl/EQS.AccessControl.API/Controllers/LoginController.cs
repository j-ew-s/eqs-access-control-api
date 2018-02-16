using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.API.JWT.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EQS.AccessControl.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        private readonly ILoginAppService _loginAppService;
        private readonly ITokenGenerator _tokenGenerator;

        public LoginController(ILoginAppService loginAppService, ITokenGenerator tokenGenerator)
        {
            _loginAppService = loginAppService;
            _tokenGenerator = tokenGenerator;
        }

        /// <summary>
        ///  Perform Login based on Credential Input object
        /// </summary>
        /// <param name="credential"> Credential Input Object </param>
        /// <returns>Returns a Response base model where the Payload contains the PersonOutput Object.</returns>
        [HttpPost]
        public ResponseModelBase<LoginOutput> Post([FromBody]CredentialInput credential)
        {
            var result = _loginAppService.Login(credential);
            if (!result.Error)
                return _tokenGenerator.CreateToken(result.Payload.FirstOrDefault());
            return result;
        }
    }
}
