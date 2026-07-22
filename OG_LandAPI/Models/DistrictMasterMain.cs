using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class DistrictMasterMain : IDistrictMasterRepository
    {
        public int Id { get; set; }
        public string? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public string? Notes { get; set; }

        public Task<object> GetAllDistricts(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DistrictMasterMain>> RetrieveAllDistricts()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllDistricts(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
