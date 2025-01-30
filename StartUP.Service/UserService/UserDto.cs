﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Service.UserService
{
    public class UserDto
    {
        public string UserName { get; set; }

        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public int SSN { get; set; }
        public string Image { get; set; }
    }
}
