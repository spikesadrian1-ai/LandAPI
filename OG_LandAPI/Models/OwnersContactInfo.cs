using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class OwnersContactInfo : IOwnersContactInfoRepository
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string Address { get; set; }
        public string AddressType { get; set; }
        public string Business { get; set; }
        public string Home { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public Task<IEnumerable<IOwnersContactInfoRepository>> RetrieveOwnersContactInfo()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchOwnersContactInfo(string name)
        {
            throw new NotImplementedException();
        }
    }
}
