using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using AutoMapper;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Input.RoleInsert;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services;

namespace EQS.AccessControl.Application.Services
{
    public class RoleAppService : IRoleAppService
    {
        private readonly IRoleService _roleService;

        public RoleAppService(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public ResponseModelBase<List<RoleOutput>> GetAll()
        {
            var result = _roleService.GetAll();
            var roleOutput = Mapper.Map<List<RoleOutput>>(result);

            return new ResponseModelBase<List<RoleOutput>>().OkResult(roleOutput, new List<string>());
        }

        public ResponseModelBase<List<RoleOutput>> GetByExpression(Expression<Func<RoleInput, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ResponseModelBase<RoleOutput> GetById(int id)
        {
            var result = _roleService.GetById(id);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, new List<string>());
        }

        public ResponseModelBase<RoleOutput> Create(RoleInsertInput entity)
        {
            var roleEntity = Mapper.Map<Role>(entity);
            var result = _roleService.Create(roleEntity);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, result.Validations.ErrorMessages);
        }

        public ResponseModelBase<RoleOutput> Update(RoleInput entity)
        {
            var roleEntity = Mapper.Map<Role>(entity);
            var result = _roleService.Update(roleEntity);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, result.Validations.ErrorMessages);
        }

        public ResponseModelBase<RoleOutput> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _roleService.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
