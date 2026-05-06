using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class UnitLegalForm
    {
        public int Id { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string StateId2 { get; set; }
        public string CountyId2 { get; set; }
        public string SurveyTwnRng { get; set; }
        public string Abstract { get; set; }
        public string Lot { get; set; }
        public string Block { get; set; }
        public string Township { get; set; }
        public string Parcel { get; set; }
        public string PoolName { get; set; }
        public string AreaName { get; set; }
        public decimal XCoord { get; set; }
        public decimal YCoord { get; set; }
        public decimal ZCoord { get; set; }
        public string UnitLegalDescription { get; set; }
        public string LocationNotes { get; set; }
        public string PerforationInformation { get; set; }
    }
}
