using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.Application.ViewModels.Output.Register;
using EQS.AccessControl.Domain.Entities;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface IRegisterAppService
    {
        ResponseModelBase<RegisterPersonOutput> Create(PersonInput entity);
        ResponseModelBase<RegisterPersonOutput> Update(PersonInput entity);
        ResponseModelBase<RegisterPersonOutput> GetById(int id);
        ResponseModelBase<List<RegisterPersonOutput>> GetAll();
        ResponseModelBase<List<RegisterPersonOutput>> GetByExpression(SearchObjectInput predicate);
        ResponseModelBase<RegisterPersonOutput> Delete(int id);
    }
}
