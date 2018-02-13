using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Application.Interfaces
{
    public interface IBaseAppService<TEntity> where TEntity :class 
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByExpression(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);
        TEntity Delete(int id);
    }
}
