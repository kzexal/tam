﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }


        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public int TypeAccount { get; set; } = 0; 
    }
}