using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class SurveyTwnRngSecMasterMain
    {
        public int Id { get; set; }
        public string StateId { get; set; }
        public string IdNumber { get; set; }
        public string TypeOfLand { get; set; }
        public string SurveyName { get; set; }
        public string Abstract { get; set; }
        public string Twn { get; set; }
        public string Rng { get; set; }
        public string Sec { get; set; }
        public string TownshipName { get; set; }
        public string OffshoreBlock { get; set; }
        public string ParcelName { get; set; }
        public string Block { get; set; }
        public string LotNumber { get; set; }
        public string AreaName { get; set; }
        public string Map { get; set; }
        public string CountyId { get; set; }
        public decimal? Acreage { get; set; }
        public string Meridian { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public decimal? XCoordinate { get; set; }
        public decimal? YCoordinate { get; set; }
        public decimal? ZCoordinate { get; set; }
        public string Description { get; set; }
        public string Active { get; set; }
    }
}
