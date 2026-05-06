using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class DefaultBankMasters : IDefaultBankMasterRepository
    {
        public int Id { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public decimal? PerCheck { get; set; }
        public decimal? PerAccount { get; set; }
        public decimal? PerPayee { get; set; }
        public decimal? PerDeposit { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public string LeaseId { get; set; }
        public string OwnerId { get; set; }
        public string WellId { get; set; }
        public string UnitId { get; set; }
        public string Active { get; set; }
        public string Notes { get; set; }

        public Task<object> GetAllDefaultBanks(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DefaultBankMasters>> RetrieveAllDefaultBanks(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllDefaultBanks(string name)
        {
            throw new NotImplementedException();
        }
    }
}
