using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository.Base;

namespace EQS.AccessControl.Repository.Repository
{
    public class RegisterRepository : BaseRepository<Person>, IRegisterRepository
    {
        public RegisterRepository(EntityFrameworkContext context) : base(context)
        {

        }

    }
}
