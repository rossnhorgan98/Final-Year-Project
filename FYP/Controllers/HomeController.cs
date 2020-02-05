using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FYP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FYP.Controllers
{
    public class HomeController : Controller
    {
        private readonly InventoryContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public HomeController(InventoryContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)//, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Explore()
        {
            return View(await _context.Country.ToListAsync());
        }

        public async Task<IActionResult> CountryProfile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .Include(c => c.City)
                .FirstOrDefaultAsync(m => m.CountryId == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        public async Task<IActionResult> CityProfile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City
                .Include(c => c.Country)
                .FirstOrDefaultAsync(m => m.CityId == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        public IActionResult Map()
        {
            return View();
        }

        

        public async Task<IActionResult> Compare()
        {

            var list = new City();
           // list.CityList = new SelectList(_context.City, nameof(City.CityId), nameof(City.Name));

            //return View(list);
            var inventoryContext = _context.City.Include(c => c.Country);
            return View(await inventoryContext.ToListAsync());
            //return View(_context.City.FirstOrDefault());
        }

       /* [HttpPost]
        public async Task<IActionResult> Compare(City cityA, City cityB)
        {

        }*/

        public async Task<IActionResult> CityRankings()
        {
            var inventoryContext = _context.City.Include(c => c.Country);
            return View(await inventoryContext.ToListAsync());
        }

        public async Task<IActionResult> CountryRankings()
        {
            return View(await _context.Country.ToListAsync());
        }

        public IActionResult Sources()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn([Bind("UserId,Username,Email,Password,HomeCountry,HomeCity,CurrentCountry,CurrentCity,UserType")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }*/

        //Reference - https://csharp-video-tutorials.blogspot.com/2019/06/aspnet-core-identity-usermanager-and.html
        [HttpPost]
        public async Task<IActionResult> Register(User model)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Username,
                    Email = model.Email
                    // = model.HomeCountry

                };

                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View("LogIn", model);
        }

        //Reference - https://csharp-video-tutorials.blogspot.com/2019/06/show-or-hide-login-and-logout-links.html
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //Reference - https://csharp-video-tutorials.blogspot.com/2019/06/implementing-login-functionality-in.html
        [HttpPost]
        public async Task<IActionResult> LogIn(User user)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    user.Username, user.Password, true, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(user);
        }
        /* if ((user.Username == null) && (user.Password == null))
         {
             return NotFound();
         } else
         {
             var usernameId = await _context.User.FirstOrDefaultAsync(m => m.Username == user.Username);
             var passwordId = await _context.User.FirstOrDefaultAsync(m => m.Password == user.Password);

             if (usernameId == passwordId)
             {
                 return Content("Success");
             } else
             {
                 return Error();
             }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
