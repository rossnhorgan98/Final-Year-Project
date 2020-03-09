//This controller was scaffolded by using the "add MVC Controller with Views, using Entity Framework" option 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FYP.Models;
using Microsoft.AspNetCore.Identity;

namespace FYP.Controllers
{
    public class CitiesController : Controller
    {
        private readonly InventoryContext _context;
        private readonly SignInManager<ApplicationUser> signInManager;

        public CitiesController(InventoryContext context, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
        }

        // Show list of cities in table
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                var inventoryContext = _context.City.Include(c => c.Country);
            return View(await inventoryContext.ToListAsync());
        } else
            {
               return RedirectToAction("Login", "Home");
    }
}

        // Show city details
        public async Task<IActionResult> Details(int? id)
        {
            if (signInManager.IsSignedIn(User))
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
            
            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        // Render create country view
        public IActionResult Create()
        {
            if (signInManager.IsSignedIn(User))
            {
                ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name");
            return View();
            
            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Add a city to the city table
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CityId,Name,CountryId,Population,GeneralPicture,Description,QualityOfLifeIndex,CostOfLivingIndex,RentIndex,PurchasingPowerIndex,ClimateType,ClimateImage,ClimateDescription,TrafficRate,LightRailLines,NoOfAirports,TransportImage,NoOfUniversities,SafetyIndex,PollutionIndex")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Add(city);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", city.CountryId);
            return View(city);
        }

        //Retrieve the edit city page
        public async Task<IActionResult> Edit(int? id)
        {
            if (signInManager.IsSignedIn(User))
            {
                if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", city.CountryId);
            return View(city);
            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Save changes to a city
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CityId,Name,CountryId,Population,GeneralPicture,Description,QualityOfLifeIndex,CostOfLivingIndex,RentIndex,PurchasingPowerIndex,ClimateType,ClimateImage,ClimateDescription,TrafficRate,LightRailLines,NoOfAirports,TransportImage,NoOfUniversities,SafetyIndex,PollutionIndex")] City city)
        {
            if (id != city.CityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(city);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(city.CityId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", city.CountryId);
            return View(city);
        }

        //Retrieve view for deleting city
        public async Task<IActionResult> Delete(int? id)
        {
            if (signInManager.IsSignedIn(User))
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
            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        // Delete a city from table
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var city = await _context.City.FindAsync(id);
            _context.City.Remove(city);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(int id)
        {
            return _context.City.Any(e => e.CityId == id);
        }
    }
}
