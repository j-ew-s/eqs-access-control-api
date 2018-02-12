using System;
using System.Linq;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace EQS.AccessControl.Repository.Repository
{
    public class LoginRepository : BaseRepository<Credential>, ILoginRepository
    {
        public LoginRepository(EntityFrameworkContext context) : base(context)
        {

        }

        public Person Login(Credential credential)
        {
            return Db.Person.AsNoTracking()
                .FirstOrDefault(f => f.Credential.Username == credential.Username &&
                                     f.Credential.Password == credential.Password);
        }
    }
}
