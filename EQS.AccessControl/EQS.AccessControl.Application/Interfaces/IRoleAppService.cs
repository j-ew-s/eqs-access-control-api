using System;
using System.Collections.Generic;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface IRoleAppService: IDisposable
    {
        ResponseModelBase<RoleOutput> Create(RoleInput entity);
        ResponseModelBase<RoleOutput> Update(RoleUpdateInput entity);
        ResponseModelBase<RoleOutput> GetById(int id);
        ResponseModelBase<List<RoleOutput>> GetAll();
        ResponseModelBase<List<RoleOutput>> GetByExpression(SearchObjectInput predicate);
        ResponseModelBase<RoleOutput> Delete(int id);
    }
}
