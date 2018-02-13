using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EQS.AccessControl.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        private readonly ILoginAppService _loginAppService;

        public LoginController(ILoginAppService loginAppService)
        {
            _loginAppService = loginAppService;
        }
        
        /// <summary>
        ///  Perform Login based on Credential Input object
        /// </summary>
        /// <param name="credential"> Credential Input Object </param>
        /// <returns>Returns a Response base model where the Payload contains the PersonOutput Object.</returns>
        [HttpPost]
        public ResponseModelBase<PersonOutput> Post([FromBody]CredentialInput credential)
        {
           return _loginAppService.Login(credential);
        }
    }
}
