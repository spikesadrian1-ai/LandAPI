using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class FormationMasterMain : IFormationMasterMainRepository
    {
        public int Id { get; set; }
        public string FormationId { get; set; }
        public string FormationType { get; set; }
        public string Description { get; set; }
        public string TypeOfRock { get; set; }
        public string Permeability { get; set; }
        public int? AvgDepth { get; set; }
        public string MainProduct { get; set; }
        public string Porosity { get; set; }
        public decimal? AvgThickness { get; set; }
        public string Status { get; set; }
        public string Class { get; set; }
        public string GeologistName { get; set; }
        public string Area { get; set; }
        public string Active { get; set; }
        public string Abstract { get; set; }
        public decimal? BonusPerAcre { get; set; }
        public string InstrumentCode { get; set; }
        public string LeaseStatus { get; set; }
        public string LeaseType { get; set; }
        public string CountyId { get; set; }
        public decimal? DamagesPerAcre { get; set; }
        public string FormId { get; set; }
        public decimal? MinimumRoyalty { get; set; }
        public string FormDescription { get; set; }
        public string Notes { get; set; }
        public string BrokerId { get; set; }
        public string LesseeId { get; set; }
        public string OperatorId { get; set; }
        public string PaidUp { get; set; }
        public string PughClause { get; set; }
        public string VerticalPugh { get; set; }
        public decimal? RentPerAcre { get; set; }
        public int? RentFrequency { get; set; }
        public decimal? RoyaltyInterestText { get; set; }
        public decimal? ShutInPerAcre { get; set; }
        public string StateId { get; set; }
        public string SurveyTwnRngSec { get; set; }
        public int? LeaseTermMonths { get; set; }
        public int? LeaseTermYrs { get; set; }
        public string TopLease { get; set; }
        public string WellId { get; set; }

        public Task<object> GetAllFormations(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FormationMasterMain>> RetrieveAllFormations(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllFormations(string name)
        {
            throw new NotImplementedException();
        }
    }
}
