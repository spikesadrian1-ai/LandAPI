using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class WellEasementConnection
    {
        public int Id { get; set; }
        public string WellId { get; set; }
        public string EasementId { get; set; }
        public string EasementLegalDescription { get; set; }
        public decimal? GrossAcres { get; set; }
        public decimal? NetAcres { get; set; }
        public int? PrimaryTerm { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid? TractOwnerPk { get; set; }
    }
}
