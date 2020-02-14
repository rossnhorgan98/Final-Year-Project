using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string HomeCountry { get;  set; }
        public string HomeCity { get;  set; }
        public string CurrentCountry { get;  set; }
        public string CurrentCity { get;  set; }
        public string UserType { get;  set; }
    }
}
