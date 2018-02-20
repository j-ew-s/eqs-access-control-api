using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.ObjectValue;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface IBaseAppService<TEntity> where TEntity :class 
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByExpression(SearchObject predicate);
        TEntity Delete(int id);
    }
}
