using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class ProspectMainForm
    {
        public int Id { get; set; }
        public string ProspectId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Producing { get; set; }
        public string Active { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string StateId2 { get; set; }
        public string CountyId2 { get; set; }
        public string RegionId { get; set; }
        public string DistrictId { get; set; }
        public string OperatorId { get; set; }
        public string LesseeId { get; set; }
        public string LandmanId { get; set; }
        public decimal? GrossAcres { get; set; }
        public decimal? NetAcres { get; set; }
        public decimal? BonusPerAcre { get; set; }
        public decimal? TotalBonus { get; set; }
        public decimal? BrokerFeesPerAcre { get; set; }
        public decimal? BrokerFees { get; set; }
        public decimal? OtherCosts { get; set; }
        public decimal? LeasedByUs { get; set; }
        public decimal? LeasedByOthers { get; set; }
        public decimal? UnleasedAndOpen { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string SpecialProvisionsNotes { get; set; }
    }
}
