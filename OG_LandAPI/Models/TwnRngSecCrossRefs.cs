using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class TwnRngSecCrossRefs
    {
        public int Id { get; set; }
        public string? TwnRngId { get; set; }
        public string? PropertyType { get; set; }
        public decimal? GrossAcres { get; set; }
        public decimal? GrossOverlap { get; set; }
        public decimal? GrossDevelop { get; set; }
        public decimal? GrossDevelopOverlap { get; set; }
        public decimal? NetAcres { get; set; }
        public decimal? NetDeveloped { get; set; }
        public string? ShortComment { get; set; }
        public string? Position { get; set; }
        public string? TractId { get; set; }
        public string? SubTractId { get; set; }
        public string? LeaseId { get; set; }
        public string? WellId { get; set; }
        public bool? IncludeInTrsCalc { get; set; }
    }
}
