using EQS.AccessControl.Domain.Specification.Role;
using EQS.AccessControl.Domain.Validation.Base;

namespace EQS.AccessControl.Domain.Validation.Role
{
    public class RoleConsistentValidation
    {
        public BaseValidation BaseValidation { get; set; }
        public RoleConsistentValidation(Entities.Role person)
        {
            BaseValidation = new BaseValidation();

            var nameSpecification = new NameIsNotNullSpecification();
            BaseValidation.AddSpecification("Name-Specification",
                nameSpecification.IsSatisfyedBy(person),
                "Name is null.");
        }
    }
}
