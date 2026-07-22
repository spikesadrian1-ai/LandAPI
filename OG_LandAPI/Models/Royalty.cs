using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class Royalty
    {
        public int Id { get; set; }
        public string? OwnerId { get; set; }
        public string? InterestType { get; set; }
        public string? InterestFormula { get; set; }
        public string? OrriType { get; set; }
        public decimal? Interest { get; set; }
        public string? PayoutCode { get; set; }
        public string? Substance { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? Active { get; set; }
        public string? BurdensAllWiPartners { get; set; }
        public string? OrriReductionType { get; set; }
        public string? SuspenseCode { get; set; }
        public string? TractId { get; set; }
        public string? SubTractId { get; set; }
        public string? LeaseId { get; set; }
        public string? WellId { get; set; }
        public string? UnitId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? BurdenId { get; set; }
        public string? BurdenType { get; set; }
        public decimal? FlatAmount { get; set; }
        public string? RoyOwnerId { get; set; }
        public string? WiOwnerId { get; set; }
        public string? EasementId { get; set; }
        public string? SuaId { get; set; }
        public string? RowId { get; set; }
    }
}
