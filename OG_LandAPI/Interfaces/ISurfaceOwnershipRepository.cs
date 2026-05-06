using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface ISurfaceOwnershipRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnerships();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnershipsByTractId(string TractId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnershipsByLeaseId(string LeaseId);

    }
}
