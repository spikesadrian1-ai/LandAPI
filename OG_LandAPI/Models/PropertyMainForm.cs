using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class PropertyMainForm : IPropertyMainRepository
    {
        public int Id { get; set; }
        public string PropertyId { get; set; }
        public string AcctIdNo { get; set; }
        public string Description { get; set; }
        public string PropertyType { get; set; }
        public string GrantorId { get; set; }
        public string GranteeId { get; set; }
        public DateTime? Acquired { get; set; }
        public DateTime? Divested { get; set; }
        public decimal? Original { get; set; }
        public decimal? Current { get; set; }
        public string ElectricityOn { get; set; }
        public string WaterOn { get; set; }
        public string GasOn { get; set; }
        public string IsDamaged { get; set; }
        public string IsVacant { get; set; }
        public string IsUnsecured { get; set; }
        public string ForSale { get; set; }
        public string CattleOk { get; set; }
        public string Active { get; set; }
        public string SoldTo { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string SurveyTwnRng { get; set; }
        public string Abstract { get; set; }
        public string Block { get; set; }
        public string Lot { get; set; }
        public string Section { get; set; }
        public string FieldName { get; set; }
        public string AreaName { get; set; }
        public string LegalDescription { get; set; }
        public decimal? SurfaceInterest { get; set; }
        public decimal? MineralInterest { get; set; }
        public decimal? RoyaltyInterest { get; set; }
        public decimal? SubsidenceInterest { get; set; }
        public decimal? OrriInterest { get; set; }
        public decimal? NetRevenueInterest { get; set; }
        public decimal? OtherInterest1 { get; set; }
        public decimal? OtherInterest2 { get; set; }
        public decimal? OtherInterest3 { get; set; }
        public decimal? OtherInterest4 { get; set; }
        public decimal? GrossAcresTotalMineralAcres { get; set; }
        public decimal? NetAcresTotalMineralAcres { get; set; }
        public decimal? ProducingMineralAcres { get; set; }
        public decimal? NetProducingMineralAcres { get; set; }
        public decimal? LeasedMineralAcres { get; set; }
        public decimal? NetLeasedMineralAcres { get; set; }
        public decimal? GrossAcresRoyaltyAcres { get; set; }
        public decimal? NetAcresRoyaltyAcres { get; set; }
        public decimal? ProducingRoyaltyAcres { get; set; }
        public decimal? LeaseRoyaltyAcres { get; set; }
        public decimal? NetLeaseRoyaltyAcres { get; set; }
        public decimal? GrossAcresSurfaceAcres { get; set; }
        public decimal? NetAcresSurfaceAcres { get; set; }
        public decimal? GrossAcresOrriAcres { get; set; }
        public decimal? NetAcresOrriAcres { get; set; }
        public decimal? OrriAcresProducing { get; set; }
        public decimal? NetOrriAcresProducing { get; set; }
        public decimal? LeasedOrriAcres { get; set; }
        public decimal? NetLeasedOrriAcres { get; set; }
        public decimal? GrossAcresOtherAcres { get; set; }
        public decimal? NetAcresOtherAcres { get; set; }
        public decimal? OtherAcresProducing { get; set; }
        public decimal? NetOtherAcresProducing { get; set; }
        public decimal? LeasedOtherAcres { get; set; }
        public decimal? NetLeasedOtherAcres { get; set; }
        public decimal? GrossAcresSubsidenceAcres { get; set; }
        public decimal? NetAcresSubsidenceAcres { get; set; }
        public string ApprDistrictId { get; set; }
        public DateTime? ApprDistributonYear { get; set; }
        public decimal? LandValue { get; set; }
        public decimal? ImprovementValue { get; set; }
        public string TaxYear { get; set; }
        public decimal? TaxAmount1 { get; set; }
        public decimal? TaxAmount2 { get; set; }
        public decimal? TaxAmount3 { get; set; }
        public decimal? TaxAmount4 { get; set; }
        public string TaxRemarks { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string HuntingRate { get; set; }
        public string HuntingUnit { get; set; }
        public string MaxUnits { get; set; }
        public string HuntingNotes { get; set; }
        public string RecordingInformation { get; set; }
        public string TimberType { get; set; }
        public string AverageAge { get; set; }
        public string AverageHeight { get; set; }
        public string AverageGirth { get; set; }
        public int? EstimatedNumberOfTrees { get; set; }
        public decimal? EstimatedTimberValue { get; set; }
        public DateTime? LastCutDate { get; set; }
        public string LastCutBy { get; set; }
        public DateTime? NextCutDate { get; set; }
        public string NextCutBy { get; set; }
        public string TimberRemarks { get; set; }
        public string CarrierId { get; set; }
        public string InsuranceType { get; set; }
        public string Description2 { get; set; }
        public decimal? InsuranceCost { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string InsuranceNotes { get; set; }
        public string MortgageCompanyId { get; set; }
        public string LoanNumber { get; set; }
        public string AgentName { get; set; }
        public string AgentPhone { get; set; }
        public string AgentAddress { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string SpecialProvisionsNotes { get; set; }
        public string SurfaceOwnershipType { get; set; }
        public string ProspectId { get; set; }
        public string RegionId { get; set; }
        public string AcctIdNo2 { get; set; }
        public decimal? DeedAcres { get; set; }
        public string InsuranceDescription { get; set; }
        public decimal? Interest { get; set; }
        public string InterestType { get; set; }
        public decimal? NetProducingRoyaltyAcres { get; set; }

        public Task<object> GetPropertiesByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PropertyMainForm>> RetrieveAllProperty()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchProperty(string name)
        {
            throw new NotImplementedException();
        }
    }
}
