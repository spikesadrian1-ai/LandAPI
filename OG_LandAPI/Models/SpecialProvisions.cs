using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class SpecialProvisions
    {
        public int Id { get; set; }
        public string? PoolingFlag { get; set; }
        public string? OptionToExtend { get; set; }
        public string? SpecialProvisionNotes { get; set; }
        public string? TractId { get; set; }
        public string? LeaseId { get; set; }
        public string? WellId { get; set; }
        public string? UnitId { get; set; }
        public string? EasementId { get; set; }
        public string? SuaId { get; set; }
        public string? RowId { get; set; }
        public string? FormationId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
