using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class CheckDetails : ICheckDetailsRepository
    {
        public int Id { get; set; }
        public string _1099Type { get; set; }
        public DateTime? AcctDate { get; set; }
        public string AcctPeriod { get; set; }
        public decimal? Amount { get; set; }
        public decimal? BankFees { get; set; }
        public decimal? SeveranceTax { get; set; }
        public decimal? OtherTaxes { get; set; }
        public decimal? MktExpenses { get; set; }
        public decimal? RecoupAmount { get; set; }
        public string TractId { get; set; }
        public string ChartOfAcctId { get; set; }
        public string LeaseId { get; set; }
        public string WellId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public decimal? MineralInterest { get; set; }
        public decimal? JibDeduction { get; set; }
        public decimal? RevenueInterest { get; set; }
        public DateTime? DueDate { get; set; }
        public string PaymentCode { get; set; }
        public string PayRegardless { get; set; }
        public string CheckDetsPk { get; set; }
        public string CheckId { get; set; }
        public string OwnerId { get; set; }

        public Task<object> GetAllCheckDetails(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CheckDetails>> RetrieveAllCheckDetails(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllCheckDetails(string name)
        {
            throw new NotImplementedException();
        }
    }
}
