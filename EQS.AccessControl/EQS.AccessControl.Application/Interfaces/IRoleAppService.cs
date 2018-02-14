﻿using System;
using System.Collections.Generic;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Input.RoleInsert;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface IRoleAppService: IDisposable
    {
        ResponseModelBase<RoleOutput> Create(RoleInsertInput entity);
        ResponseModelBase<RoleOutput> Update(RoleInput entity);
        ResponseModelBase<RoleOutput> GetById(int id);
        ResponseModelBase<List<RoleOutput>> GetAll();
        ResponseModelBase<List<RoleOutput>> GetByExpression(System.Linq.Expressions.Expression<Func<RoleInput, bool>> predicate);
        ResponseModelBase<RoleOutput> Delete(int id);
    }
}