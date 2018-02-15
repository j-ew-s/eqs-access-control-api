using EQS.AccessControl.Domain.Interfaces.Repository;

namespace EQS.AccessControl.Domain.Specification.Role
{
    public class RoleHaveNoPersonAssociatedSpecification
    {
        private readonly IRoleRepository _roleRepository;

        public RoleHaveNoPersonAssociatedSpecification(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public bool IsSatisfyedBy(int roleId)
        {
            return _roleRepository.GetPeopleAssociatedToRoleId(roleId).Count == 0;
        }
    }
}
