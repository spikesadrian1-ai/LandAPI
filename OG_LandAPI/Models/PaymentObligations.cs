using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class PaymentObligations //: IPaymentObligationsRepository
    {
        public int Id { get; set; }
        public string PayeeId { get; set; }
        public string PaymentType { get; set; }
        public string ResponsibleParty { get; set; }
        public DateTime? BeginningDueDate { get; set; }
        public int? PeriodFrequency { get; set; }
        public DateTime? EndingDate { get; set; }
        public decimal? NetAmount { get; set; }
        public string Recommendation { get; set; }
        public string SuspenseCode { get; set; }
        public string BankId { get; set; }
        public decimal? BankAccountNo { get; set; }
        public string AdditionalBankFees { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public string WellId { get; set; }
        public string LeaseId { get; set; }
        public string OwnerId { get; set; }
        public string OkToPay { get; set; }
        public string IncludeNotesOnCheck { get; set; }
        public string RecurringPayment { get; set; }
        public string PayRegardlessOfLeaseStateOfPayment { get; set; }
        public string Suspense { get; set; }
        public string RecoupablePayment { get; set; }
        public string Ppi { get; set; }
        public string EasementId { get; set; }
        public string SuaId { get; set; }
        public string RowId { get; set; }
        public string Formation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public Task<object> GetAllPaymentObligations(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentObligations>> RetrieveAllPaymentObligations(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllPaymentObligations(string name)
        {
            throw new NotImplementedException();
        }
    }
}
