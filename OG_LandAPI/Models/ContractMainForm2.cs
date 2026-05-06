using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class ContractMainForm2 : IContractRepository
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public string AcctDeptId { get; set; }
        public string Active { get; set; }
        public string ContractType { get; set; }
        public string SubType { get; set; }
        public string ContractStatus { get; set; }
        public decimal? Consideration { get; set; }
        public decimal? OtherAmount1 { get; set; }
        public decimal? OtherAmount2 { get; set; }
        public string ContractDescription { get; set; }
        public string DescriptionMemo { get; set; }
        public string Responsible { get; set; }
        public string MainCompany { get; set; }
        public string Buyer { get; set; }
        public string Seller { get; set; }
        public string Gatherer { get; set; }
        public string Treater { get; set; }
        public string Processor { get; set; }
        public string Compressor { get; set; }
        public string RecordingInformation { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string StateId2 { get; set; }
        public string CountyId2 { get; set; }
        public string ProspectId { get; set; }
        public string DistrictId { get; set; }
        public string RegionId { get; set; }
        public string BasinId { get; set; }
        public string Location { get; set; }
        public string Area { get; set; }
        public string MapReference { get; set; }
        public string InHouse { get; set; }
        public string Country { get; set; }
        public string ContractLegalDescription { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? AcquiredDate { get; set; }
        public DateTime? BeginOperDate { get; set; }
        public DateTime? SignatureDate { get; set; }
        public DateTime? ObligationDate { get; set; }
        public string ContractTerm { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? RevisedDate { get; set; }
        public DateTime? LastAmended { get; set; }
        public DateTime? DivestedDate { get; set; }
        public DateTime? NextNotifyDate { get; set; }
        public int? NotifyDays { get; set; }
        public int? OptionDays { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? DrlgBeginDate { get; set; }
        public DateTime? DrlgEndingDate { get; set; }
        public string AssignmentClause { get; set; }
        public string SpecialProvisionsNotes { get; set; }
        public decimal? PriceSettlement { get; set; }
        public decimal? Fees { get; set; }
        public string CountyId1 { get; set; }
        public string PriceRedeterminationClause { get; set; }
        public DateTime? PriceRedeterminationDate { get; set; }
        public DateTime? OptionEffDate { get; set; }
        public string OptionPeriod { get; set; }
        public string OptionExpire { get; set; }
        public string PerpetualOptionClause { get; set; }
        public string OptionalAssignmentClause { get; set; }
        public int? Frequency { get; set; }
        public decimal? MinimumAcres { get; set; }
        public int? AdditionalLeaseDays { get; set; }
        public int? MaximumExtensionDays { get; set; }
        public int? MinimumAdverseConditionDays { get; set; }
        public int? ActualAdverseConditionDays { get; set; }
        public decimal? MinimumAcresRequired { get; set; }
        public decimal? TotalAcres { get; set; }
        public int? TotalMiles { get; set; }
        public int? TotalSections { get; set; }
        public int? TotalSurveys { get; set; }
        public int? TotalShotHoles { get; set; }
        public decimal? PricePerAcre { get; set; }
        public decimal? PricePerMile { get; set; }
        public decimal? PricePerSection { get; set; }
        public decimal? PricePerSurvey { get; set; }
        public decimal? PricePerShotHole { get; set; }
        public decimal? PricePerLease { get; set; }
        public decimal? PerpetualPeriod { get; set; }
        public string OptionNotes { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? Date3 { get; set; }
        public DateTime? Date4 { get; set; }
        public DateTime? Date5 { get; set; }
        public DateTime? Date6 { get; set; }
        public string SearchMemo1 { get; set; }
        public string SearchMemo2 { get; set; }
        public string SubTractId { get; set; }
        public string TractId { get; set; }
        public string LeaseId { get; set; }
        public string UnitId { get; set; }
        public string WellIdNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string PropertyId { get; set; }
        public decimal? Interest { get; set; }
        public string AllAfe { get; set; }
        public string AllLeases { get; set; }
        public string AllTracts { get; set; }
        public string AllWells { get; set; }
        public string PropertyType { get; set; }
        public string Type { get; set; }
        public string StatusCode { get; set; }

        public Task<object> GetAllContracts(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContractMainForm2>> RetrieveAllContracts()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllContracts(string name)
        {
            throw new NotImplementedException();
        }
    }
}
