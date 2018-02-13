using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EQS.AccessControl.Application.ViewModels.Input
{
    public class RoleInput
    {
        public RoleInput()
        {
            PersonRoles = new HashSet<PersonRoleInput>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public ICollection<PersonRoleInput> PersonRoles { get; set; }
    }
}
