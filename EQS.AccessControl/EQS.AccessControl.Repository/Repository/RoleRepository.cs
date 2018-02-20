using System.Collections.Generic;
using System.Linq;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.ObjectValue;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace EQS.AccessControl.Repository.Repository
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(EntityFrameworkContext context) : base(context)
        {

        }

        public List<Person> GetPeopleAssociatedToRoleId(int id)
        {
            return Db.PersonRole
                .AsNoTracking()
                .Where(w => w.RoleId == id)
                .Include(i => i.Person)
                .Include(i => i.Roles)
                .Select(s => s.Person).ToList();
        }

        public override IEnumerable<Role> GetByExpression(SearchObject predicate)
        {
            var result = Db.Role.AsNoTracking()
                .Skip(0)
                .Take(predicate.ItemQuantity)
                .ToList();

            return result;
        }
    }
}
