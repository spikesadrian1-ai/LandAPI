using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class SpecialObligations
    {
        public int Id { get; set; }
        public DateTime? ObligationDate { get; set; }
        public string? ObligationType { get; set; }
        public string? ResponsiblePartyId { get; set; }
        public string? DescriptionOfObligation { get; set; }
        public string? RecurringObligation { get; set; }
        public int? RecurringPeriod { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? Recommendation { get; set; }
        public decimal? ObligationAmount { get; set; }
        public string? TractId { get; set; }
        public string? FormationId { get; set; }
        public string? LeaseId { get; set; }
        public string? OwnerId { get; set; }
        public string? WellId { get; set; }
        public string? UnitId { get; set; }
        public string? EasementId { get; set; }
        public string? SuaId { get; set; }
        public string? RowId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
