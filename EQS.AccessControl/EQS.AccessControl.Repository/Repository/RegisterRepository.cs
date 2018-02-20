using System;
using System.Collections.Generic;
using System.Linq;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.ObjectValue;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing.ExpressionVisitors.Transformation.PredefinedTransformations;

namespace EQS.AccessControl.Repository.Repository
{
    public class RegisterRepository : BaseRepository<Person>, IRegisterRepository
    {
        public RegisterRepository(EntityFrameworkContext context) : base(context)
        {

        }

        public override IEnumerable<Person> GetAll()
        {
            return Db.Person.AsNoTracking()
                .Include(i => i.PersonRoles).ThenInclude(t => t.Roles)
                .Include(i => i.Credential)
                .ToList();
        }

        public override Person GetById(int id)
        {
            return Db.Person.AsNoTracking()
                .Include(i => i.PersonRoles).ThenInclude(t => t.Roles)
                .Include(i => i.Credential)
                .FirstOrDefault(f => f.Id == id);
        }

        public Person getCredentialByPersonId(Person person)
        {
            return Db.Person.Include(i => i.Credential).FirstOrDefault(f => f.Credential.PersonId == person.Id);
        }

        public override IEnumerable<Person> GetByExpression(SearchObject predicate)
        {
            return Db.Person.AsNoTracking()
                .Where(w =>
                    string.IsNullOrEmpty(predicate.TextTerm)
                    || w.Name.Contains(predicate.TextTerm)
                )
               .Take(predicate.ItemQuantity)
               .ToList();
        }
    }
}
