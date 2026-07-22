using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class CheckMasterMainForm : ICheckMasterRepository
    {
        public int Id { get; set; }
        public string? PropertyType { get; set; }
        public string? PropertyId { get; set; }
        public string? PayorBankNo { get; set; }
        public int? CheckNumber { get; set; }
        public string? CheckStatus { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? FederalTaxWithheld { get; set; }
        public decimal? BankCharges { get; set; }
        public string? PayeeId { get; set; }
        public string? DepBankId { get; set; }
        public string? AccountNo { get; set; }
        public string? CertifiedMailNo { get; set; }
        public DateTime? CertifiedMailDate { get; set; }
        public string? Active { get; set; }
        public string? ManualCheck { get; set; }
        public string? Cancelled { get; set; }
        public string? Voided { get; set; }
        public int? DraftIdNumber { get; set; }
        public DateTime? DraftDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public string? Search1 { get; set; }
        public string? Search2 { get; set; }
        public string? Search3 { get; set; }
        public string? Search4 { get; set; }
        public string? VoidedBy { get; set; }
        public DateTime? VoidedDate { get; set; }
        public string? TypeOfCheck { get; set; }
        public int? NewDraftCheckNo { get; set; }
        public DateTime? AcctDate { get; set; }
        public string? TractId { get; set; }
        public string? LeaseId { get; set; }

        public Task<object> GetAllChecks(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CheckMasterMainForm>> RetrieveAllChecks(string? name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllChecks(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
