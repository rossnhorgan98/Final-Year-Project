using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FYP.Models;
using Microsoft.EntityFrameworkCore;

namespace FYP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InventoryContext _context;

        public HomeController(ILogger<HomeController> logger, InventoryContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Explore()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Compare()
        {
            return View();
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
