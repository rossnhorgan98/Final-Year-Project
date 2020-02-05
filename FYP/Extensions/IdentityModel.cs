using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FYP.Extensions
{
    public class ApplicationUser : IdentityUser
    {
        public string HomeCountry { get; internal set; }
        public string HomeCity { get; internal set; }
        public string CurrentCountry { get; internal set; }
        public string CurrentCity { get; internal set; }
        public string UserType { get; internal set; }

       /* public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            //var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
           // userIdentity.AddClaim(new Claim("FirstName", this.FirstName));

            return userIdentity;
        }*/
    }
}
