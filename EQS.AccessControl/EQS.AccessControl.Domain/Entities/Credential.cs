using EQS.AccessControl.Domain.Entities.Base;
using EQS.AccessControl.Domain.Validation.Login;

namespace EQS.AccessControl.Domain.Entities
{
    public class Credential : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }

        public bool IsValid()
        {
            var validation = new LoginConsistentValidation(this);
            Validations = validation.BaseValidation.IsValid();

            return Validations.IsValid;
        }
    }
}
