using EQS.AccessControl.Domain.ObjectValue;

namespace EQS.AccessControl.Domain.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Validator Validations { get; set; }
    }
}
