using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class Nri : INriRepository
    {
        public int Id { get; set; }
        public string LeaseId { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public decimal? WorkingInterest { get; set; }
        public string LeaseWorking { get; set; }
        public decimal? Nri1 { get; set; }
        public string WellId { get; set; }
        public string OwnerId { get; set; }

        public Task<object> GetNRInterest(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Nri>> RetrieveAllNRInterest(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllNRInterest(string name)
        {
            throw new NotImplementedException();
        }
    }
}
