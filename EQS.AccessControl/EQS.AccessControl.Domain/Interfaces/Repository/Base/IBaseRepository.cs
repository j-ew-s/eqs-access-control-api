using System;
using System.Collections.Generic;
using System.Text;

namespace EQS.AccessControl.Domain.Interfaces.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity obj);

        TEntity Update(TEntity obj);

        TEntity Delete(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetByExpression(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);

        TEntity GetById(int id);

        int SaveChanges();
    }
}
