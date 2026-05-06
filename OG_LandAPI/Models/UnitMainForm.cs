using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class UnitMainForm
    {
        public int Id { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string StateUnitId { get; set; }
        public string ApiNumber { get; set; }
        public string UnitType { get; set; }
        public string UnitStatus { get; set; }
        public string AcquisitionCode { get; set; }
        public string PayoutCode { get; set; }
        public decimal Acres { get; set; }
        public int DepthInFeet { get; set; }
        public string ProspectId { get; set; }
        public string DistrictId { get; set; }
        public string RegionId { get; set; }
        public bool OkToPay { get; set; }
        public bool Producing { get; set; }
        public bool SplitStream { get; set; }
        public bool Active { get; set; }
    }
}
