using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string HomeCountry { get; set; }
        public string HomeCity { get; set; }
        public string CurrentCountry { get; set; }
        public string CurrentCity { get; set; }
        public string UserType { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and conformation password do not match.")]
        public string ConfirmPassword { get; set; }
        
    }
}
