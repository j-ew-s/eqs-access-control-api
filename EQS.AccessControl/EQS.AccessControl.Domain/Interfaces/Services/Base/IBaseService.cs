using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.ObjectValue;

namespace EQS.AccessControl.Domain.Interfaces.Services.Base
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByExpression(SearchObject predicate);
        TEntity Delete(int id);
    }
}
