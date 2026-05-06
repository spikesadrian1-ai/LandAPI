using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface ISpecialProvisionsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisions();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisionsByTractId(string TractId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisionsByLeaseId(string LeaseId);

    }
}
