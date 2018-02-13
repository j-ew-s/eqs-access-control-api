using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Domain.Interfaces.Services.Base
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByExpression(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);
        TEntity Delete(int id);
    }
}
