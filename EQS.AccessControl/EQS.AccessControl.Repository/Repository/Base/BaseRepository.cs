using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EQS.AccessControl.Domain.ObjectValue;
using EQS.AccessControl.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace EQS.AccessControl.Repository.Repository.Base
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected EntityFrameworkContext Db;
        protected DbSet<TEntity> DbSet;

        public BaseRepository(EntityFrameworkContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Create(TEntity obj)
        {
            var entity = DbSet.Add(obj);
            SaveChanges();
            return entity.Entity;
        }


        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
            return entry.Entity;
        }

        public virtual TEntity Delete(int id)
        {
            var entity = DbSet.Remove(DbSet.Find(id));
            SaveChanges();
            return entity.Entity;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public virtual IEnumerable<TEntity> GetByExpression(SearchObject predicate)
        {
            return DbSet.ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
