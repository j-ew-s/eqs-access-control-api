using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.Application.ViewModels.Output.Register;
using Microsoft.AspNetCore.Mvc;

namespace EQS.AccessControl.API.Controllers
{
    /// <summary>
    ///  Register API
    /// </summary>
    [Produces("application/json")]
    [Route("api/Register")]
    public class RegisterController : Controller
    {
        private readonly IRegisterAppService _registerAppService;

        public RegisterController(IRegisterAppService registerAppService)
        {
            _registerAppService = registerAppService;
        }

        
        /// <summary>
        /// Get all the People 
        /// </summary>
        /// <returns>List of People</returns>
        [HttpGet("GetAll")]
        public ResponseModelBase<List<RegisterPersonOutput>> Get()
        {
            return _registerAppService.GetAll();
        }

        // GET: api/Register/5
        [HttpGet("{id}")]
        public ResponseModelBase<RegisterPersonOutput> Get(int id)
        {
            return _registerAppService.GetById(id);
        }
        
        // POST: api/Register
        [HttpPost]
        public ResponseModelBase<RegisterPersonOutput> Post([FromBody]PersonInput person)
        {
           return _registerAppService.Create(person);
        }
        
        // PUT: api/Register/5
        [HttpPut]
        public ResponseModelBase<RegisterPersonOutput> Put( [FromBody]PersonInput person)
        {
            return _registerAppService.Update(person);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ResponseModelBase<RegisterPersonOutput> Delete(int id)
        {
            return _registerAppService.Delete(id);
        }
    }
}
