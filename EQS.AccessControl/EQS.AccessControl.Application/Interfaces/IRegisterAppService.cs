using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Domain.Entities;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface IRegisterAppService
    {
        PersonOutput Create(PersonInput entity);
        PersonOutput Update(PersonInput entity);
        PersonOutput GetById(int id);
        IEnumerable<PersonOutput> GetAll();
        IEnumerable<PersonOutput> GetByExpression(System.Linq.Expressions.Expression<Func<PersonInput, bool>> predicate);
        PersonOutput Delete(int id);
    }
}
