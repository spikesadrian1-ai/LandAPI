using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class Burdens : IBurdensRepository
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string InterestFormula { get; set; }
        public decimal? BurdenInterest { get; set; }
        public bool? FullInterest { get; set; }
        public string BurdenType { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal? BurdenAmount { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public string LeaseId { get; set; }
        public string WellId { get; set; }
        public string RoyId { get; set; }

        public Task<object> GetAllBurdens(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Burdens>> RetrieveAllBurdens(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchBurdens(string name)
        {
            throw new NotImplementedException();
        }
    }
}
