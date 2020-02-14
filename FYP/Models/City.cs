/* This class was scaffolded using the following packet manager console command:
   Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models */

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace FYP.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int? Population { get; set; }
        public string? GeneralPicture { get; set; }
        public string Description { get; set; }
        public decimal? QualityOfLifeIndex { get; set; }
        public decimal? CostOfLivingIndex { get; set; }
        public decimal? RentIndex { get; set; }
        public decimal? PurchasingPowerIndex { get; set; }
        public string ClimateType { get; set; }
        public string? ClimateImage { get; set; }
        public string ClimateDescription { get; set; }
        public decimal? TrafficRate { get; set; }
        public int? LightRailLines { get; set; }
        public int? NoOfAirports { get; set; }
        public string? TransportImage { get; set; }
        public int? NoOfUniversities { get; set; }
        public decimal? SafetyIndex { get; set; }
        public decimal? PollutionIndex { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual Country Country { get; set; }
        
    }
}
