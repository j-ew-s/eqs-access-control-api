using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EQS.AccessControl.Application.ViewModels.Input.RoleInsert
{
    public class RoleInsertInput
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

    }
}
