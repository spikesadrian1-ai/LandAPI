using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class RecordingInformation : IRecordingInformationRepository
    {
        public int Id { get; set; }
        public string TractId { get; set; }
        public string LeaseId { get; set; }
        public DateTime? FileDate { get; set; }
        public DateTime? RecordingDate { get; set; }
        public string Book { get; set; }
        public string Page { get; set; }
        public string Volume { get; set; }
        public string Entry { get; set; }
        public string MultiPayments { get; set; }
        public string IncludeTractIdsWithLegalDescription { get; set; }
        public string CreatePaymentHistory { get; set; }
        public string CreateRevenueReceipts { get; set; }
        public string CreateOptionToExtendBonuses { get; set; }

        public Task<object> GetRecordingInformationByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RecordingInformation>> RetrieveAllRecordingInformation()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllRecordingInformation(string name)
        {
            throw new NotImplementedException();
        }
    }
}
