using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.API.Authorize;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EQS.AccessControl.API.Controllers
{
    /// <summary>
    ///  Role API
    /// </summary>
    [Produces("application/json")]
    [Route("api/Role")]
    [Authorize("Bearer")]
    [AuthorizeRole("Admin")]
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetByExpression")]
        public ResponseModelBase<List<RoleOutput>> GetByExpression([FromBody]SearchObjectInput search)
        {
            return _roleAppService.GetByExpression(search);
        }

        /// <summary>
        ///  Insert a new Role to DB
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost]
        public ResponseModelBase<RoleOutput> Post([FromBody]RoleInput role)
        {
            return _roleAppService.Create(role);
        }
        
        /// <summary>
        ///  Updates an existent Role
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut]
        public ResponseModelBase<RoleOutput> Put([FromBody]RoleUpdateInput value)
        {
            return _roleAppService.Update(value);
        }
        
        /// <summary>
        /// Delete a role
        /// </summary>
        /// <param name="id">Role Id</param>
        [HttpDelete("{id}")]
        public ResponseModelBase<RoleOutput> Delete(int id)
        {
            return  _roleAppService.Delete(id);
        }
    }
}
