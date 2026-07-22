using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class TractsRowconnection
    {
        public int Id { get; set; }
        public string? TractId { get; set; }
        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public decimal? TotalAcreage { get; set; }
        public string? TractType { get; set; }
        public string? DevTractId { get; set; }
        public decimal? DevelopedAcreage { get; set; }
        public decimal? UndevelopedAcreage { get; set; }
        public decimal? OutsideAcreage { get; set; }
        public decimal? OtherAcreage { get; set; }
        public decimal? TotalDeveloped { get; set; }
        public string? RowId { get; set; }
        public string? UnitId { get; set; }
        public string? WellId { get; set; }
        public string? TractMainId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid? TractOwnerPk { get; set; }
    }
}
