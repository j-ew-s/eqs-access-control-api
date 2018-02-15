﻿using System.ComponentModel.DataAnnotations;

namespace EQS.AccessControl.Application.ViewModels.Input
{
    public class RoleInput
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
