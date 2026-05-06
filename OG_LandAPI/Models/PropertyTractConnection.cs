using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class PropertyTractConnection : IPropertyTractConnectionRepository
    {
        public int Id { get; set; }
        public string PropertyId { get; set; }
        public string Description { get; set; }
        public string PropertyType { get; set; }
        public string TractId { get; set; }

        public Task<object> GetPropertyTractConnectionsByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PropertyTractConnection>> RetrieveAllPropertyTractConnections()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllPropertyTractConnections(string name)
        {
            throw new NotImplementedException();
        }
    }
}
