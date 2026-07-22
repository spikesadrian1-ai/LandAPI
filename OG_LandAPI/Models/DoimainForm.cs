using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class DoimainForm : IDOIMainRepository
    {
        public int Id { get; set; }
        public string? DoiId { get; set; }
        public string? Active { get; set; }
        public string? DoiName { get; set; }
        public DateTime? DoiDate { get; set; }
        public string? DoiType { get; set; }
        public string? CurrentStatus { get; set; }
        public string? CurrentOperator { get; set; }
        public string? OriginalOperator { get; set; }
        public string? UnitId { get; set; }
        public string? WellId { get; set; }
        public string? UnitCalcType { get; set; }
        public string? OpeningStatement { get; set; }
        public string? ClosingStatement { get; set; }

        public Task<object> GetMainDOIsByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoimainForm>> RetrieveAllMainDOIs()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllMainDOIs(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
