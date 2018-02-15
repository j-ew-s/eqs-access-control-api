using EQS.AccessControl.Domain.Interfaces.Repository;

namespace EQS.AccessControl.Domain.Specification.Role
{
    public class RoleExistsAtDbSpecification
    {
        private readonly IRoleRepository _roleRepository;

        public RoleExistsAtDbSpecification(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public bool IsSatisfyedBy(int id)
        {
            return _roleRepository.GetById(id) != null;
        }
    }
}
