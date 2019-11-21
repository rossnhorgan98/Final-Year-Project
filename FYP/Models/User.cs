/* This class was scaffolded using the following packet manager console command:
   Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models */

using System;
using System.Collections.Generic;

namespace FYP.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HomeCountry { get; set; }
        public string HomeCity { get; set; }
        public string CurrentCountry { get; set; }
        public string CurrentCity { get; set; }
    }
}
