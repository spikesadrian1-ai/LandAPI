using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface IWellLeaseConnectionRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<WellLeaseConnection>> RetrieveAllWellLeaseConnections(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllWellLeaseConnections(string name/*, string tractid*/);

    }
}
