using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class FilingInformation : IFilingInformationRepository
    {
        public int Id { get; set; }
        public DateTime? FilingDate { get; set; }
        public DateTime? RecordingDate { get; set; }
        public string? StateId { get; set; }
        public string? CountyId { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Volume { get; set; }
        public string? Entry { get; set; }
        public string? Other { get; set; }
        public string? QuickNote { get; set; }
        public string? CotId { get; set; }
        public string? TractId { get; set; }
        public string? LeaseId { get; set; }
        public string? GrantorId { get; set; }
        public string? GranteeId { get; set; }

        public Task<object> GetAllFilings(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FilingInformation>> RetrieveAllFilings(string? name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllFilings(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
