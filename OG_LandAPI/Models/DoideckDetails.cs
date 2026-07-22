using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class DoideckDetails : IDoiDeckDetailsRepository
    {
        public int Id { get; set; }
        public string? OwnerId { get; set; }
        public string? InterestType { get; set; }
        public string? Interest { get; set; }
        public string? SuspenseCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? OtherDate { get; set; }
        public string? InterestFormula { get; set; }
        public string? PayRegardless { get; set; }
        public string? NoPay { get; set; }
        public string? PayWpt { get; set; }
        public string? PaySeveranceTax { get; set; }
        public string? Active { get; set; }
        public string? PayMarketingCosts { get; set; }
        public string? PayOtherTax1 { get; set; }
        public string? PayOtherTax2 { get; set; }
        public string? WellId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Task<object> GetDoiDeckDetailsByID(int ID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<DoideckDetails>> RetrieveAllDoiDeckDetails()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<object> SearchAllDoiDeckDetails(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
