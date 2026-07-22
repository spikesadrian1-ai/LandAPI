using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class Npri : INpriRepository
    {
        public int Id { get; set; }
        public string? NpriOwnerId { get; set; }
        public string? FullInterest { get; set; }
        public string? NpriFormula { get; set; }
        public decimal? Interest { get; set; }
        public string? SuspenseCode { get; set; }
        public string? TractId { get; set; }
        public string? PrId { get; set; }
        public string? WellId { get; set; }
        public string? LeaseId { get; set; }
        public string? OwnerId { get; set; }
        public string? EasementId { get; set; }
        public string? RowId { get; set; }
        public string? SuaId { get; set; }

        public Task<object> AddNewNPRInterest(string? name)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetNPRInterest(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Npri>> RetrieveNPRInterest(string? name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchNPRInterest(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
