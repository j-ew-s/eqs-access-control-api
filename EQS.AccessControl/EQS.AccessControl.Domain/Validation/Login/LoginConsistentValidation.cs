using EQS.AccessControl.Domain.Specification.Credential;
using EQS.AccessControl.Domain.Validation.Base;

namespace EQS.AccessControl.Domain.Validation.Login
{
    public class LoginConsistentValidation
    {
        public BaseValidation BaseValidation { get; set; }
        public LoginConsistentValidation(Entities.Credential credential)
        {
            BaseValidation = new BaseValidation();

            var usernameSpecification = new UsernameIsNotNullSpecification();
            BaseValidation.AddSpecification("Username-Specification", usernameSpecification.IsSatisfyedBy(credential), "Username is null.");

            var passwordSpecification = new PasswordIsNotNullSpecification();
            BaseValidation.AddSpecification("Password-Specification", passwordSpecification.IsSatisfyedBy(credential), "Password is null.");

        }
    }
}
