﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData.Model
{
    public class LoginVM
    {
        [Required]
        public string Email {  get; set; }
        
        [Required]
        public string Password { get; set; } 
    }
}
