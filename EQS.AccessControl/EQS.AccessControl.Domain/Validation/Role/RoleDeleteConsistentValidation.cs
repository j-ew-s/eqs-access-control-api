using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Specification.Role;
using EQS.AccessControl.Domain.Validation.Base;

namespace EQS.AccessControl.Domain.Validation.Role
{
    public class RoleDeleteConsistentValidation
    {
        public BaseValidation BaseValidation { get; set; }
        public IRoleRepository RoleRepository;

        public RoleDeleteConsistentValidation(Entities.Role role, IRoleRepository iRoleRepository)
        {
            RoleRepository = iRoleRepository;
            BaseValidation = new BaseValidation();

            var roleExists = new RoleExistsAtDbSpecification(RoleRepository);
            BaseValidation.AddSpecification("Role-Not-Found",
                roleExists.IsSatisfyedBy(role.Id),
                "Role does not exists in current DB.");

            var roleHaveNoPersonAssociated = new RoleHaveNoPersonAssociatedSpecification(RoleRepository);
            BaseValidation.AddSpecification("Role-Contains-Associated-Person",
                roleHaveNoPersonAssociated.IsSatisfyedBy(role.Id),
                "There is associated users to this role. Please, remove then first.");

        }
    }
}
