using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using Microsoft.AspNetCore.Http;
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

        
        // GET: api/Register
        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Register/5
        [HttpGet("{id}:int")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Register
        [HttpPost]
        public void Post([FromBody]PersonInput person)
        {
            _registerAppService.Create(person);
        }
        
        // PUT: api/Register/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PersonInput person)
        {
            _registerAppService.Update(person);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _registerAppService.Delete(id);
        }
    }
}
