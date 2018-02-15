using System;
using System.Collections.Generic;
using System.Linq;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;

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
    }
}
