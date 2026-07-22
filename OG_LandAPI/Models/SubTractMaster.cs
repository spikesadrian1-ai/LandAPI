using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class SubTractMaster
    {
        public int Id { get; set; }
        public string? TractId { get; set; }
        public string? OwnerId { get; set; }
        public string? SubTractId { get; set; }
        public string? SubTractType { get; set; }
        public decimal? Acreage { get; set; }
        public string? ShortDescription { get; set; }
        public string? SubTractLegalDescription { get; set; }
        public string? WellIdNo { get; set; }
        public string? UnitIdNo { get; set; }
        public string? TwnSurvey { get; set; }
        public string? RngAbstract { get; set; }
        public string? Section { get; set; }
        public string? Blocks { get; set; }
        public string? Lot { get; set; }
        public string? Position { get; set; }
        public decimal? WellParticipationFactor { get; set; }
        public decimal? UnitParticipationFactor { get; set; }
        public bool? OkToPayRentalsOnThisSubTract { get; set; }
        public string? Active { get; set; }
        public string? InclInTractAcresCalc { get; set; }
        public string? InclInSubTractAcresCalc { get; set; }
        public string? InclInWellAcresCalc { get; set; }
        public string? InclInUnitAcresCalc { get; set; }
        public string? InclInFormationCalc { get; set; }
        public string? InclInTwnRngSecCalc { get; set; }
        public int? BeginningDepth { get; set; }
        public int? EndingDepth { get; set; }
        public string? DepthNotes { get; set; }
        public decimal? Undeveloped { get; set; }
        public decimal? Developed { get; set; }
        public decimal? Other { get; set; }
        public decimal? Outside { get; set; }
    }
}
