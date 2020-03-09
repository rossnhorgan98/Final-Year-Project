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
    public class CountriesController : Controller
    {
        private readonly InventoryContext _context;
        private readonly SignInManager<ApplicationUser> signInManager;

        public CountriesController(InventoryContext context, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
        }

        // Show list of countries in table
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                return View(await _context.Country.ToListAsync());
             } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Show country details
        public async Task<IActionResult> Details(int? id)
        {
            if (signInManager.IsSignedIn(User))
            {
                if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .FirstOrDefaultAsync(m => m.CountryId == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);

            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Render create country view
        public IActionResult Create()
        {
            if (signInManager.IsSignedIn(User))
            {
                return View();
            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Add a country to the country table
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CountryId,Name,Flag,Map,Population,LanguageS,Currency,Hdi,Gdp,Description,HealthcareRanking,AverageWage,AvgWorkHours,MinAnnualLeave,MinnimumWage,UnemploymentRate,PensionIndex,AvgUniCost,EducationDescription,MaxIncomeTax,MinIncomeTax,Vat,CorporationTax,HomicideRate,Continent")] Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Add(country);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        //Retrieve the edit country page
        public async Task<IActionResult> Edit(int? id)
        {
            if (signInManager.IsSignedIn(User))
            {
                if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            return View(country);

            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Save changes to a country
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CountryId,Name,Flag,Map,Population,LanguageS,Currency,Hdi,Gdp,Description,HealthcareRanking,AverageWage,AvgWorkHours,MinAnnualLeave,MinnimumWage,UnemploymentRate,PensionIndex,AvgUniCost,EducationDescription,MaxIncomeTax,MinIncomeTax,Vat,CorporationTax,HomicideRate,Continent")] Country country)
        {
            if (id != country.CountryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(country);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountryExists(country.CountryId))
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
            return View(country);
        }

        //Retrieve view for deleting country
        public async Task<IActionResult> Delete(int? id)
        {
            if (signInManager.IsSignedIn(User))
            {
                if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .FirstOrDefaultAsync(m => m.CountryId == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);

            } else
            {
               return RedirectToAction("Login", "Home");
            }
        }

        //Delete a country from table
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var country = await _context.Country.FindAsync(id);
            _context.Country.Remove(country);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CountryExists(int id)
        {
            return _context.Country.Any(e => e.CountryId == id);
        }
    }
}
