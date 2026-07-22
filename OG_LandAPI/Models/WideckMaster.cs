using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class WideckMaster
    {
        public int Id { get; set; }
        public string? DeckId { get; set; }
        public string? DeckName { get; set; }
        public string? Active { get; set; }
        public string? PayoutCode { get; set; }
        public string? DeckType { get; set; }
        public string? Product { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? SuspenseCode { get; set; }
        public string? UseInAcrCalcs { get; set; }
        public string? UseInDoiCalcs { get; set; }
        public string? UseInPymntCalcs { get; set; }
        public string? TractId { get; set; }
        public string? DeckPk { get; set; }
        public string? LeaseId { get; set; }
        public string? WellId { get; set; }
        public string? EasementId { get; set; }
        public string? SuaId { get; set; }
        public string? RowId { get; set; }
    }
}
