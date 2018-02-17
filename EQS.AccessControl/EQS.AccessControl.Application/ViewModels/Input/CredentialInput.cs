using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EQS.AccessControl.Application.ViewModels.Input
{
    public class CredentialInput
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
