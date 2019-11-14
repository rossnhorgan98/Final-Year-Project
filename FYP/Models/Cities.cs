using System;
using System.Collections.Generic;

namespace FYP.Models
{
    public partial class Cities
    {
        public long CityId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal? CostOfLivingIndex { get; set; }
        public string ClimateType { get; set; }
        public long Population { get; set; }
        public int? NoOfUniversities { get; set; }
        public int? NoOfAirports { get; set; }
        public int? LightRailLines { get; set; }
        public decimal? TrafficRate { get; set; }
        public decimal? HomicideRate { get; set; }
        public decimal? IncomeTax { get; set; }
        public decimal? Vat { get; set; }
        public decimal? CorporationTax { get; set; }
    }
}
