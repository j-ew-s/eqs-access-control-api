using EQS.AccessControl.Domain.ObjectValue;

namespace EQS.AccessControl.Domain.Validation.Base
{
    public class BaseValidation
    {
        public BaseValidation()
        {
            if (Validators is null)
                Validators = new Validator() { IsValid = true };
        }
        public Validator Validators { get; set; }

        public void AddSpecification(string key, bool isValid, string message)
        {
            if (!isValid)
            {
                Validators.IsValid = false;
                Validators.ErrorMessages.Add(message);
            }
        }

        public Validator IsValid()
        {
            return Validators;
        }
    }
}
