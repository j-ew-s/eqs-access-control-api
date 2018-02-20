using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EQS.AccessControl.Application.ViewModels.Input
{
    public class RoleInput
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
