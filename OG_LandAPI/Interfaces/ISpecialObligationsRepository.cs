using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface ISpecialObligationsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<SpecialObligations>> RetrieveAllSpecialObligations();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialObligations>> SearchAllSpecialObligationsByTractId(string TractId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialObligations>> SearchAllSpecialObligationsByLeaseId(string LeaseId);

    }
}
