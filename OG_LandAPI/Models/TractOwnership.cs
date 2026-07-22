using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class TractOwnership
    {
        public int Id { get; set; }
        public string? OwnerId { get; set; }
        public string? FormationType { get; set; }
        public string? FullName { get; set; }
        public string? TractId { get; set; }
        public string? LeaseId { get; set; }
        public string? MoId { get; set; }
        public string? ToId { get; set; }
        public string? TractType { get; set; }
        public string? Formula { get; set; }
        public decimal? MineralInterest { get; set; }
        public decimal? SurfaceInterest { get; set; }
        public decimal? NetAcreage { get; set; }
        public decimal? SubsidenceInterest { get; set; }
        public string? LegalDescription { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? SuspenseCode { get; set; }
        public string? TenureCode { get; set; }
        public string? NoExecutiveRights { get; set; }
        public string? Tenant { get; set; }
        public string? TwnSurvey { get; set; }
        public string? Active { get; set; }
        public int? BeginningDepth { get; set; }
        public int? EndingDepth { get; set; }
        public string? DepthNotes { get; set; }
        public decimal? Total { get; set; }
        public decimal? Producing { get; set; }
        public decimal? NonProducing { get; set; }
        public decimal? Other { get; set; }
        public decimal? Outside { get; set; }
        public decimal? Developed { get; set; }
        public decimal? Undeveloped { get; set; }
        public decimal? ShutInPerAcre { get; set; }
        public string? Pooling { get; set; }
        public string? OptionToExtend { get; set; }
        public string? StatusOfLease { get; set; }
        public string? ProspectId { get; set; }
        public string? CountyId { get; set; }
        public string? StateId { get; set; }
        public string? WellIdNo { get; set; }
        public DateTime? LeaseDate { get; set; }
        public DateTime? _3rdPartyEffectiveDate { get; set; }
        public DateTime? _3rdPartyExpirationDate { get; set; }
        public string? _3rdPartyLesseeId { get; set; }
        public DateTime? FileDate { get; set; }
        public string? BookPage { get; set; }
        public decimal? LeaseTotalRental { get; set; }
        public decimal? LeaseTotalBonus { get; set; }
        public string? LeaseNotes { get; set; }
        public string? PropertyId { get; set; }
        public decimal? TractTotal { get; set; }
        public decimal? TractProducing { get; set; }
        public decimal? TractNonProducing { get; set; }
        public decimal? TractOther { get; set; }
        public decimal? TractOutside { get; set; }
        public decimal? TractDeveloped { get; set; }
        public decimal? TractUndeveloped { get; set; }
        public decimal? NpriGas { get; set; }
        public decimal? NpriOil { get; set; }
        public decimal? OrriGas { get; set; }
        public decimal? OrriOil { get; set; }
        public decimal? OtherInterest { get; set; }
        public decimal? RoyaltyGas { get; set; }
        public decimal? RoyaltyOil { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string? TractOwnerPk { get; set; }
    }
}
