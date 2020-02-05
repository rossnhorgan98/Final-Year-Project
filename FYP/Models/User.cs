/* This class was scaffolded using the following packet manager console command:
   Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FYP.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
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
