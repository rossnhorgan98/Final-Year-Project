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
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public HomeController(InventoryContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
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

        public async Task<IActionResult> Map()
        {
            var inventoryContext = _context.City.Include(c => c.Country);
            return View(await inventoryContext.ToListAsync());
        }

        //Reference - https://youtu.be/LZc69CEOdJI
        public IActionResult Compare()
        {
            //Populate the dropdownlists with cities
            List<City> cityList = new List<City>();
            cityList = (from x in _context.City select x).ToList();         
            cityList.Insert(0, new City { CityId = 0, Name = "-- Select City --" });
            ViewBag.message = cityList;

            return View();
        }

        [HttpPost]
        public IActionResult Compare(CompareViewModel model)
        {
            //Reinitialise the model after posting
            List<City> cityList = new List<City>();
            cityList = (from x in _context.City select x).ToList();
            cityList.Insert(0, new City { CityId = 0, Name = "-- Select City --" });
            ViewBag.message = cityList;

            //Assign the selected cities to the cities in the database
            var viewModel = new CompareViewModel();

            viewModel.cityA = _context.City.Include(c => c.Country)
                                     .FirstOrDefault(m => m.CityId == model.cityA.CityId);

            viewModel.cityB = _context.City.Include(c => c.Country)
                                     .FirstOrDefault(m => m.CityId == model.cityB.CityId);

            return View(viewModel);
        }

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

        public IActionResult Register()
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
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    //homecountry = model.homecountry,
                    //homecity = model.homecity,
                    //currentcountry = model.currentcountry,
                    //currentcity = model.currentcity,
                    UserType = "user"
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

            return View(model);
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
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
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
