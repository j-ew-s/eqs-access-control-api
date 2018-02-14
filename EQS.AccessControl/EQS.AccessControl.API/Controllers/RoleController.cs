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
    [Route("api/Role")]
    public class RoleController : Controller
    {
        private readonly IRoleAppService _roleAppService;

        public RoleController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        
       /// <summary>
       /// Returns all roles 
       /// </summary>
       /// <returns>Roles</returns>
        [HttpGet]
        public ResponseModelBase<List<RoleOutput>> Get()
        {
            return _roleAppService.GetAll();
        }

        /// <summary>
        /// returns a specific role 
        /// </summary>
        /// <param name="id">Role's id</param>
        /// <returns>Role</returns>
        [HttpGet("{id}", Name = "Get")]
        public ResponseModelBase<RoleOutput> Get(int id)
        {
            return _roleAppService.GetById(id);
        }
        
        // POST: api/Role
        [HttpPost]
        public void Post([FromBody]RoleInput role)
        {
            return _roleAppService.Create(role);
        }
        
        // PUT: api/Role/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
