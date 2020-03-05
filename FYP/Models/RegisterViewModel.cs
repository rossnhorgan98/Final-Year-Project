using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    /*Code below is based on:
      Register new user using asp.net core identity
      Pragimtech
      https://csharp-video-tutorials.blogspot.com/2019/06/register-new-user-using-aspnet-core.html */
    public class RegisterViewModel
    {
        public string Username { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and conformation password do not match.")]
        public string ConfirmPassword { get; set; }
        
    }
    //End
}
