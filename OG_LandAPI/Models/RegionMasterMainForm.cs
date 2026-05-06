using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class RegionMasterMainForm : IRegionMasterRepository
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        public string FormationCodes { get; set; }
        public string Active { get; set; }
        public string RegionId { get; set; }

        public Task<IEnumerable<RegionMasterMainForm>> RetrieveAllRegions()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllRegions(string name)
        {
            throw new NotImplementedException();
        }
    }
}
