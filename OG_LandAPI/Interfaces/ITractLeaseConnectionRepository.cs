using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface ITractLeaseConnectionRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<TractsLeaseConnection>> RetrieveAllTractsLease();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<TractsLeaseConnection>> SearchAllTractsLeaseConnectionsByTractId(string TractId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        //Task<TractsLeaseConnection> GetTractsLeaseConnectionsByTractID(string LeaseId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        Task<TractsLeaseConnection> AddNewTractsLeaseConnections(string TractId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<TractsLeaseConnection> DeleteTractsLeaseConnections(int Id);


    }
}
