using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class OwnerAddressesMain : IOwnerAddressesMainRepository
    {
        public int Id { get; set; }
        public string? OwnerId { get; set; }
        public string? Active { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? AddressType { get; set; }
        public string? TaxId { get; set; }
        public string? SpouseSsn { get; set; }
        public string? TaxIdType { get; set; }
        public string? FileAs { get; set; }
        public string? Send1099 { get; set; }
        public string? SevTaxExempt { get; set; }
        public string? ExpenseExempt { get; set; }
        public string? OtherExempt { get; set; }
        public string? FedTaxWithhold { get; set; }
        public string? InHouseOwner { get; set; }
        public string? Business { get; set; }
        public string? Business2 { get; set; }
        public string? Home { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? WebPage { get; set; }
        public string? TenureCode { get; set; }
        public string? GeneralClass { get; set; }
        public string? DefaultBankId { get; set; }
        public string? BankAccountNo { get; set; }
        public string? NoPayCode { get; set; }
        public string? AccountingDeptIdNo { get; set; }
        public string? OriginalIdNo { get; set; }
        public string? ContactName { get; set; }
        public DateTime? NextContactDate { get; set; }
        public string? SuspenseCode { get; set; }
        public decimal? Rentals { get; set; }
        public decimal? NonEmployeeComp { get; set; }
        public decimal? Royalties { get; set; }
        public decimal? FedTaxWithholding { get; set; }
        public string? TractId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string? TractOwnerPk { get; set; }

        public Task<object> GetOwnerAddressesMain(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OwnerAddressesMain>> RetrieveOwnerAddressesMain(string? name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchOwnerAddressesMain(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
