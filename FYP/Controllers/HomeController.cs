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

       /* [HttpPost]
        public IActionResult Convert(double amount, string currency)
        {

        }*/

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

        /*Code below is based on:
         ASP.NET Core MVC How To Get Selected Dropdown Value In jQuery 3.4.1
         Haritha Computers & Technology
         https://youtu.be/LZc69CEOdJI */
        public IActionResult CompareCities()
        {
            //Populate the dropdownlists with cities
            List<City> cityList = new List<City>();
            cityList = (from x in _context.City select x).ToList();         
            //cityList.Insert(0, new City { CityId = 0, Name = "-- Select City --" });
            ViewBag.cityList = cityList;

            return View();
        }
        //End

        [HttpPost]
        public IActionResult CompareCities(CompareViewModel model)
        {
            //Reinitialise the model after posting
            List<City> cityList = new List<City>();
            cityList = (from x in _context.City select x).ToList();
           // cityList.Insert(0, new City { CityId = 0, Name = "-- Select City --" });
            ViewBag.cityList = cityList;

            
                //Assign the selected cities to the cities in the database
                var viewModel = new CompareViewModel();

                viewModel.cityA = _context.City.Include(c => c.Country)
                                         .FirstOrDefault(m => m.CityId == model.cityA.CityId);

                viewModel.cityB = _context.City.Include(c => c.Country)
                                         .FirstOrDefault(m => m.CityId == model.cityB.CityId);

                return View(viewModel);
            
        }

        /*Code below is based on:
        ASP.NET Core MVC How To Get Selected Dropdown Value In jQuery 3.4.1
        Haritha Computers & Technology
        https://youtu.be/LZc69CEOdJI */
        public IActionResult CompareCountries()
        {
            //Populate the dropdownlists with cities
            List<Country> countryList = new List<Country>();
            countryList = (from x in _context.Country select x).ToList();           
            ViewBag.countryList = countryList;

            return View();
        }
        //End

        [HttpPost]
        public IActionResult CompareCountries(CompareViewModel model)
        {
            //Reinitialise the model after posting
            List<Country> countryList = new List<Country>();
            countryList = (from x in _context.Country select x).ToList();
            ViewBag.countryList = countryList;


            //Assign the selected cities to the cities in the database
            var viewModel = new CompareViewModel();

            viewModel.countryA = _context.Country.Include(c => c.City)
                                     .FirstOrDefault(m => m.CountryId == model.countryA.CountryId);

            viewModel.countryB = _context.Country.Include(c => c.City)
                                     .FirstOrDefault(m => m.CountryId == model.countryB.CountryId);

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

        /*Code below is based on:
          Show or hide login and logout links based on login status in asp.net core
          Pragimtech
          https://csharp-video-tutorials.blogspot.com/2019/06/show-or-hide-login-and-logout-links.html */
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        //End

    /*Code below is based on:
     Implementing login functionality in asp.net core
     Pragimtech
     https://csharp-video-tutorials.blogspot.com/2019/06/implementing-login-functionality-in.html */
    [HttpPost]
    public async Task<IActionResult> LogIn(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await signInManager.PasswordSignInAsync(
                model.Username, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Admin", "Home");
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
        }

        return View(model);
    }
        //End

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
