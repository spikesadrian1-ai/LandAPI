using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface IWellTractsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<WellTractsConnection>> RetrieveAllWellTractsConnections();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WellId"></param>
        /// <returns></returns>
        Task<IEnumerable<WellTractsConnection>> SearchAllWellTractsConnectionsByWellId(string WellId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        Task<IEnumerable<WellTractsConnection>> SearchAllWellTractsConnectionsByTractId(string TractId);

    }
}
