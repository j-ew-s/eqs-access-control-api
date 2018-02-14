using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository.Base;

namespace EQS.AccessControl.Repository.Repository
{
    public class RoleRepository:BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(EntityFrameworkContext context) : base(context)
        {
            
            
        }
    }
}
