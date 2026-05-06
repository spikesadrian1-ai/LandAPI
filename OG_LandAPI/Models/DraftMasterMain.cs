using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class DraftMasterMain : IDraftMasterMainRepository
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public string PropertyId { get; set; }
        public string DraftNo { get; set; }
        public DateTime DraftDate { get; set; }
        public string PayeeId { get; set; }
        public string BankIdNo { get; set; }
        public decimal DraftAmount { get; set; }
        public decimal BankFees { get; set; }
        public int DueDays { get; set; }
        public DateTime DatePaid { get; set; }
        public string PaidById { get; set; }
        public string DraftFormId { get; set; }

        public Task<object> GetAllDrafts(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DraftMasterMain>> RetrieveAllDrafts(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllDrafts(string name)
        {
            throw new NotImplementedException();
        }
    }
}
