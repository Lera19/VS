﻿using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models.Account
{
    public class LoginViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
    }
}