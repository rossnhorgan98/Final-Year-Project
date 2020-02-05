/* This class was scaffolded using the following packet manager console command:
   Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models */

using System;
using System.Collections.Generic;

namespace FYP.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string? Flag { get; set; }
        public string? Map { get; set; }
        public int? Population { get; set; }
        public string LanguageS { get; set; }
        public string Currency { get; set; }
        public decimal? Hdi { get; set; }
        public int? Gdp { get; set; }
        public string Description { get; set; }
        public int? HealthcareRanking { get; set; }
        public decimal? AverageWage { get; set; }
        public int? AvgWorkHours { get; set; }
        public int? MinAnnualLeave { get; set; }
        public decimal? MinnimumWage { get; set; }
        public decimal? UnemploymentRate { get; set; }
        public decimal? PensionIndex { get; set; }
        public int? AvgUniCost { get; set; }
        public decimal? MaxIncomeTax { get; set; }
        public decimal? MinIncomeTax { get; set; }
        public decimal? Vat { get; set; }
        public decimal? CorporationTax { get; set; }
        public decimal? HomicideRate { get; set; }
        public string Continent { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
