using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class OwnerConnection : IOwnerConnectionRepository
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string SuaId { get; set; }
        public string RowId { get; set; }
        public string EasementId { get; set; }

        public Task<IEnumerable<OwnerConnection>> RetrieveAllOwnerConnections()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchOwnerConnections(string name)
        {
            throw new NotImplementedException();
        }
    }
}
