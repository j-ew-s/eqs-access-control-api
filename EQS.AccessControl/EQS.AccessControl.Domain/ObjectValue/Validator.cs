using System.Collections.Generic;
namespace EQS.AccessControl.Domain.ObjectValue
{
    public class Validator
    {
        public Validator()
        {
            ErrorMessages = new List<string>();
        }

        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
