using System.Security.Cryptography;
using System.Text;
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

        public void EncryptedPassword()
        {
            StringBuilder senha = new StringBuilder();

            MD5 md5 = MD5.Create();
            byte[] combinated = Encoding.ASCII.GetBytes(Username + "_" + Password);
            byte[] hash = md5.ComputeHash(combinated);
            foreach (byte t in hash)
            {
                senha.Append(t.ToString("X2"));
            }
            Password = senha.ToString();

        }
    }
}
