using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class PostalMainForm : IPostalMainRepository
    {
        public string? PostalId { get; set; }
        public string? PostalCode { get; set; }
        public string? PostalArea { get; set; }

        public Task<object> GetAllPostalsByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostalMainForm>> RetrieveAllPostals()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllPostals(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
