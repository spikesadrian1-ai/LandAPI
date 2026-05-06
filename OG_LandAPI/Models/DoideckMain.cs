using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class DoideckMain : IDoiDeckMainRepository
    {
        public int Id { get; set; }
        public string DeckId { get; set; }
        public string Description { get; set; }
        public string PayoutCode { get; set; }
        public string Product { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string OpeningStatement { get; set; }
        public string ClosingStatement { get; set; }
        public string WellId { get; set; }
        public string OwnerId { get; set; }

        public Task<object> GetDoiDecksByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoideckMain>> RetrieveAllDoiDecks()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllDoiDecks(string name)
        {
            throw new NotImplementedException();
        }
    }
}
