using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    /*Code below is based on:
     Implementing login functionality in asp.net core
     Pragimtech
     https://csharp-video-tutorials.blogspot.com/2019/06/implementing-login-functionality-in.html */
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
    //End
}
