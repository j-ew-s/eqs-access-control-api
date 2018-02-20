using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services;
using EQS.AccessControl.Domain.ObjectValue;

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

        public ResponseModelBase<List<RoleOutput>> GetByExpression(SearchObjectInput predicate)
        {
            var search = Mapper.Map<SearchObject>(predicate);
            var result =  _roleService.GetByExpression(search);
            var roleOutput = Mapper.Map<List<RoleOutput>>(result);
            return new ResponseModelBase<List<RoleOutput>>().OkResult(roleOutput, new List<string>());
        }

        public ResponseModelBase<RoleOutput> GetById(int id)
        {
            var result = _roleService.GetById(id);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, new List<string>());
        }

        public ResponseModelBase<RoleOutput> Create(RoleInput entity)
        {
            var roleEntity = Mapper.Map<Role>(entity);
            var result = _roleService.Create(roleEntity);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, result.Validations.ErrorMessages);
        }

        public ResponseModelBase<RoleOutput> Update(RoleUpdateInput entity)
        {
            var roleEntity = Mapper.Map<Role>(entity);
            var result = _roleService.Update(roleEntity);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, result.Validations.ErrorMessages);
        }

        public ResponseModelBase<RoleOutput> Delete(int id)
        {
            var result = _roleService.Delete(id);
            var roleOutput = Mapper.Map<RoleOutput>(result);

            return new ResponseModelBase<RoleOutput>().OkResult(roleOutput, result.Validations.ErrorMessages);
        }

        public void Dispose()
        {
            _roleService.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
