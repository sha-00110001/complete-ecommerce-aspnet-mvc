﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using E_commerce.Models;

namespace E_commerce.Data.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
