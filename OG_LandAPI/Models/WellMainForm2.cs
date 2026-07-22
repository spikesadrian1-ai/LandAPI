using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class WellMainForm2 : IWellMainFormRepository
    {
        public int Id { get; set; }
        public string? WellIdNo { get; set; }
        public string? WellName { get; set; }
        public string? OperWellId { get; set; }
        public string? OriginalIdNo { get; set; }
        public string? Api { get; set; }
        public string? RrcId { get; set; }
        public string? Tobin { get; set; }
        public string? WellType { get; set; }
        public string? WellStatus { get; set; }
        public string? AcquisitionCode { get; set; }
        public string? PayoutCode { get; set; }
        public string? ProspectId { get; set; }
        public string? DistrictId { get; set; }
        public string? RegionId { get; set; }
        public string? Active { get; set; }
        public string? OkToPay { get; set; }
        public string? Producing { get; set; }
        public string? SpiltStream { get; set; }
        public decimal? WellAcreage { get; set; }
        public string? AcreageType { get; set; }
        public int? TotalDepthFeet { get; set; }
        public string? PermitNo { get; set; }
        public string? TankBattery { get; set; }
        public string? ProducingFrom { get; set; }
        public string? Meter1 { get; set; }
        public string? Meter2 { get; set; }
        public string? Meter3 { get; set; }
        public string? Meter4 { get; set; }
        public DateTime? PermitEffective { get; set; }
        public DateTime? PermitExpire { get; set; }
        public DateTime? DateAcquired { get; set; }
        public DateTime? DateSold { get; set; }
        public DateTime? SpudDate { get; set; }
        public DateTime? Completion { get; set; }
        public DateTime? DateOnLine { get; set; }
        public DateTime? FirstSalesDate { get; set; }
        public DateTime? LastShutIn { get; set; }
        public DateTime? PluggedDate { get; set; }
        public DateTime? OtherDate { get; set; }
        public DateTime? OtherDate2 { get; set; }
        public DateTime? RigReleased { get; set; }
        public DateTime? LastFracDate { get; set; }
        public DateTime? DateTested { get; set; }
        public DateTime? DateTd { get; set; }
        public DateTime? Payout1 { get; set; }
        public DateTime? Payout2 { get; set; }
        public DateTime? Payout3 { get; set; }
        public DateTime? Payout4 { get; set; }
        public string? PurchasersInformation { get; set; }
        public string? RecordingInformation { get; set; }
        public string? StateId { get; set; }
        public string? CountyId { get; set; }
        public string? StateId2 { get; set; }
        public string? CountyId2 { get; set; }
        public string? SurveyTwnRng { get; set; }
        public string? Abstract { get; set; }
        public string? Lot { get; set; }
        public string? Blocks { get; set; }
        public string? Township { get; set; }
        public string? Parcel { get; set; }
        public string? PoolName { get; set; }
        public string? AreaName { get; set; }
        public decimal? XCoord { get; set; }
        public decimal? YCoord { get; set; }
        public decimal? ZCoord { get; set; }
        public string? InterestDescription { get; set; }
        public string? ResponsibleParty { get; set; }
        public string? CurrentOperator { get; set; }
        public string? PreviousOperator { get; set; }
        public string? AcquiredFrom { get; set; }
        public string? SoldTo { get; set; }
        public string? WellLegalDescription { get; set; }
        public string? LocationNotes { get; set; }
        public string? FormationCode { get; set; }
        public string? Field1 { get; set; }
        public string? Field2 { get; set; }
        public string? Field3 { get; set; }
        public string? Field4 { get; set; }
        public string? SpecialProvisionNotes { get; set; }
        public string? TractId { get; set; }
        public string? AcreageStatus { get; set; }
        public string? BasinId { get; set; }
        public string? Interest1Title { get; set; }
        public string? Interest2Title { get; set; }
        public string? Interest3Title { get; set; }
        public string? Interest4Title { get; set; }
        public string? Interest5Title { get; set; }
        public string? Interest6Title { get; set; }
        public DateTime? FracDate { get; set; }
        public string? LegalDescription { get; set; }
        public string? Meridian { get; set; }
        public string? Notes { get; set; }
        public string? PurchaserNotes { get; set; }
        public decimal? EntityNri1 { get; set; }
        public decimal? EntityNri2 { get; set; }
        public decimal? EntityNri3 { get; set; }
        public decimal? EntityNri4 { get; set; }
        public decimal? EntityNri5 { get; set; }
        public decimal? EntityOrri1 { get; set; }
        public decimal? EntityOrri2 { get; set; }
        public decimal? EntityOrri3 { get; set; }
        public decimal? EntityOrri4 { get; set; }
        public decimal? EntityOrri5 { get; set; }
        public decimal? EntityOther1 { get; set; }
        public decimal? EntityOther2 { get; set; }
        public decimal? EntityOther3 { get; set; }
        public decimal? EntityOther4 { get; set; }
        public decimal? EntityOther5 { get; set; }
        public string? AquiredFrom { get; set; }
        public string? Perforations { get; set; }
        public decimal? EntityRoyalty1 { get; set; }
        public decimal? EntityRoyalty2 { get; set; }
        public decimal? EntityRoyalty3 { get; set; }
        public decimal? EntityRoyalty4 { get; set; }
        public decimal? EntityRoyalty5 { get; set; }
        public decimal? EntityWi1 { get; set; }
        public decimal? EntityWi2 { get; set; }
        public decimal? EntityWi3 { get; set; }
        public decimal? EntityWi4 { get; set; }
        public decimal? EntityWi5 { get; set; }
        public decimal? EntityNri6 { get; set; }
        public decimal? EntityOrri6 { get; set; }
        public decimal? EntityOther6 { get; set; }
        public decimal? EntityRoyalty6 { get; set; }
        public decimal? EntityWi6 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string? TractOwnerPk { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Task<object> GetWellsByID(int ID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<WellMainForm2>> RetrieveAllWells()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<object> SearchAllWells(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
